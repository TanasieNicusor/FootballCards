using Microsoft.AspNetCore.SignalR;
using FootballCards.Models;
using FootballCards.Services;
using System.Linq;  

namespace FootballCards.Hubs
{
    public class GameHub : Hub
    {
        private readonly GameManager _gameManager;

        public GameHub(GameManager gameManager)
        {
            _gameManager = gameManager;
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var game = _gameManager.GetGameForPlayer(Context.ConnectionId);
            if (game != null)
            {
                var opponentId = game.Player1Id == Context.ConnectionId ? game.Player2Id : game.Player1Id;
                await Clients.Client(opponentId).SendAsync("OpponentDisconnected");
                _gameManager.EndGame(game.GameId);
            }
            else
            {
                var queueList = _gameManager.WaitingPlayers.ToList();
                _gameManager.WaitingPlayers.Clear();
                foreach (var p in queueList)
                {
                    if (p != Context.ConnectionId) _gameManager.WaitingPlayers.Enqueue(p);
                }
            }
            await base.OnDisconnectedAsync(exception);
        }

        public async Task FindMatch()
        {
            if (_gameManager.WaitingPlayers.TryDequeue(out var opponentId))
            {
                var game = await _gameManager.CreateGameAsync(opponentId, Context.ConnectionId);
                if (game != null)
                {
                    await NotifyStateChange(game, "GameStarted");
                }
            }
            else
            {
                _gameManager.WaitingPlayers.Enqueue(Context.ConnectionId);
                await Clients.Caller.SendAsync("WaitingForMatch");
            }
        }

        public async Task DrawCard()
        {
            var game = _gameManager.GetGameForPlayer(Context.ConnectionId);
            if (game == null) return;

            bool isPlayer1 = Context.ConnectionId == game.Player1Id;
            
            // Allow draw if it's their turn
            if (game.CurrentTurnPlayerId != Context.ConnectionId) return;

            if (_gameManager.DrawCard(Context.ConnectionId))
            {
                game.CurrentTurnPlayerId = isPlayer1 ? game.Player2Id : game.Player1Id;
                await NotifyStateChange(game, "UpdateState");
            }
        }

        public async Task PlayCard(int cardId)
        {
            var game = _gameManager.GetGameForPlayer(Context.ConnectionId);
            if (game == null) return;
            
            bool isPlayer1 = Context.ConnectionId == game.Player1Id;
            if (game.CurrentTurnPlayerId != Context.ConnectionId) return;

            // If already played in this sub-turn, ignore
            if (isPlayer1 && game.Player1PlayedCards.Count > 0 && game.Player2PlayedCards.Count == 0) return;
            if (!isPlayer1 && game.Player2PlayedCards.Count > 0 && game.Player1PlayedCards.Count == 0) return;

            var hand = isPlayer1 ? game.Player1Hand : game.Player2Hand;
            var cardToPlay = hand.FirstOrDefault(c => c.Id == cardId);
            if (cardToPlay == null) return;

            hand.Remove(cardToPlay);
            if (isPlayer1) game.Player1PlayedCards.Add(cardToPlay);
            else game.Player2PlayedCards.Add(cardToPlay);

            // Replenish hand immediately
            if (game.Deck.Count > 0)
            {
                var newCard = game.Deck[0];
                game.Deck.RemoveAt(0);
                hand.Add(newCard);
            }

            // Pass turn
            game.CurrentTurnPlayerId = isPlayer1 ? game.Player2Id : game.Player1Id;

            // Did both play their initial cards?
            if (game.Player1PlayedCards.Count == 1 && game.Player2PlayedCards.Count == 1)
            {
                await ResolveRound(game);
                // If game ended inside ResolveRound, don't send further state
                if (_gameManager.GetGameForPlayer(game.Player1Id) == null) return;
            }

            await NotifyStateChange(game, "UpdateState");
        }

        private async Task ResolveRound(GameState game)
        {
            int p1Initial = game.Player1PlayedCards[0].OvrRating;
            int p2Initial = game.Player2PlayedCards[0].OvrRating;

            string winnerId = string.Empty;
            List<Card> allCardsInPlay = new();
            allCardsInPlay.AddRange(game.Player1PlayedCards);
            allCardsInPlay.AddRange(game.Player2PlayedCards);

            if (p1Initial > p2Initial) winnerId = game.Player1Id;
            else if (p2Initial > p1Initial) winnerId = game.Player2Id;
            else
            {
                // SUDDEN DEATH TIE-BREAKER
                bool settled = false;
                while (!settled)
                {
                    List<Card> p1Draws = new();
                    List<Card> p2Draws = new();

                    for (int i = 0; i < 3; i++)
                    {
                        p1Draws.Add(game.Deck[0]); game.Deck.RemoveAt(0);
                        p2Draws.Add(game.Deck[0]); game.Deck.RemoveAt(0);
                    }

                    game.Player1PlayedCards.AddRange(p1Draws);
                    game.Player2PlayedCards.AddRange(p2Draws);
                    allCardsInPlay.AddRange(p1Draws);
                    allCardsInPlay.AddRange(p2Draws);

                    int p1Sum = p1Draws.Sum(c => c.OvrRating);
                    int p2Sum = p2Draws.Sum(c => c.OvrRating);

                    if (p1Sum > p2Sum) { winnerId = game.Player1Id; settled = true; }
                    else if (p2Sum > p1Sum) { winnerId = game.Player2Id; settled = true; }
                    // if still tie, while loop repeats
                }
            }

            if (!string.IsNullOrEmpty(winnerId))
            {
                if (winnerId == game.Player1Id)
                {
                    game.Player1Score++;
                    game.Player1WonCards.AddRange(allCardsInPlay);
                }
                else
                {
                    game.Player2Score++;
                    game.Player2WonCards.AddRange(allCardsInPlay);
                }
            }

            // Increment round count
            game.TotalRoundsPlayed++;
            
            // Swap round starter for the NEXT round
            game.RoundStarterPlayerId = game.RoundStarterPlayerId == game.Player1Id ? game.Player2Id : game.Player1Id;

            // Sync players before clearing
            await Clients.Client(game.Player1Id).SendAsync("RoundResult", new { MyCards = game.Player1PlayedCards, OpponentCards = game.Player2PlayedCards, WinnerId = winnerId });
            await Clients.Client(game.Player2Id).SendAsync("RoundResult", new { MyCards = game.Player2PlayedCards, OpponentCards = game.Player1PlayedCards, WinnerId = winnerId });

            // Clear play area
            game.Player1PlayedCards.Clear();
            game.Player2PlayedCards.Clear();

            // Next turn starts with the next round's starter
            game.CurrentTurnPlayerId = game.RoundStarterPlayerId;

            // Check if game ended (15 rounds)
            if (game.TotalRoundsPlayed >= 15)
            {
                await HandleGameEnd(game);
            }
        }

        private async Task HandleGameEnd(GameState game)
        {
            var p1Top11 = game.Player1WonCards.OrderByDescending(c => c.OvrRating).Take(11).ToList();
            var p2Top11 = game.Player2WonCards.OrderByDescending(c => c.OvrRating).Take(11).ToList();

            int p1Score = p1Top11.Sum(c => c.OvrRating) + (game.Player1Score * 3);
            int p2Score = p2Top11.Sum(c => c.OvrRating) + (game.Player2Score * 3);

            await Clients.Clients(game.Player1Id, game.Player2Id).SendAsync("GameEnded", new {
                P1Id = game.Player1Id,
                P1Top11 = p1Top11,
                P2Top11 = p2Top11,
                P1RoundsWon = game.Player1Score,
                P2RoundsWon = game.Player2Score,
                P1TotalScore = p1Score,
                P2TotalScore = p2Score,
                WinnerId = p1Score > p2Score ? game.Player1Id : (p2Score > p1Score ? game.Player2Id : "")
            });
            _gameManager.EndGame(game.GameId);
        }

        private int CalculateFinalScore(List<Card> wonCards, int roundsWon)
        {
            var top11Sum = wonCards.OrderByDescending(c => c.OvrRating).Take(11).Sum(c => c.OvrRating);
            return top11Sum + (roundsWon * 3);
        }

        private async Task NotifyStateChange(GameState game, string messageName)
        {
            await Clients.Client(game.Player1Id).SendAsync(messageName, new {
                DeckCount = game.Deck.Count,
                MyHand = game.Player1Hand,
                OpponentHandCount = game.Player2Hand.Count,
                MyScore = game.Player1Score,
                OpponentScore = game.Player2Score,
                IsMyTurn = game.CurrentTurnPlayerId == game.Player1Id,
                MyPlayedCards = game.Player1PlayedCards,
                OpponentPlayedCards = game.Player2PlayedCards,
                MyId = game.Player1Id,
                TotalRoundsPlayed = game.TotalRoundsPlayed
            });
            await Clients.Client(game.Player2Id).SendAsync(messageName, new {
                DeckCount = game.Deck.Count,
                MyHand = game.Player2Hand,
                OpponentHandCount = game.Player1Hand.Count,
                MyScore = game.Player2Score,
                OpponentScore = game.Player1Score,
                IsMyTurn = game.CurrentTurnPlayerId == game.Player2Id,
                MyPlayedCards = game.Player2PlayedCards,
                OpponentPlayedCards = game.Player1PlayedCards,
                MyId = game.Player2Id,
                TotalRoundsPlayed = game.TotalRoundsPlayed
            });
        }
    }
}
