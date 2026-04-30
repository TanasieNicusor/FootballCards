using Microsoft.Extensions.DependencyInjection;
using FootballCards.Data;
using FootballCards.Models;
using System.Collections.Concurrent;
using System.Linq;

namespace FootballCards.Services
{
    public class GameState
    {
        public required string GameId { get; set; }
        public required string Player1Id { get; set; }
        public required string Player2Id { get; set; }
        public List<Card> Deck { get; set; } = new();
        public List<Card> Player1Hand { get; set; } = new();
        public List<Card> Player2Hand { get; set; } = new();
        public int Player1Score { get; set; } = 0;
        public int Player2Score { get; set; } = 0;
        public string CurrentTurnPlayerId { get; set; } = string.Empty;
        
        public List<Card> Player1PlayedCards { get; set; } = new();
        public List<Card> Player2PlayedCards { get; set; } = new();

        public List<Card> Player1WonCards { get; set; } = new();
        public List<Card> Player2WonCards { get; set; } = new();

        public int TotalRoundsPlayed { get; set; } = 0;
        public string RoundStarterPlayerId { get; set; } = string.Empty;
    }

    public class GameManager
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public ConcurrentQueue<string> WaitingPlayers { get; } = new();
        public ConcurrentDictionary<string, GameState> ActiveGames { get; } = new();
        public ConcurrentDictionary<string, string> PlayerGames { get; } = new();

        public GameManager(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public async Task<GameState?> CreateGameAsync(string player1Id, string player2Id)
        {
            var gameId = Guid.NewGuid().ToString();
            
            var gameState = new GameState
            {
                GameId = gameId,
                Player1Id = player1Id,
                Player2Id = player2Id,
                CurrentTurnPlayerId = player1Id, // P1 starts game
                RoundStarterPlayerId = player1Id
            };

            // Fetch deck
            using (var scope = _scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var allCards = db.Cards.ToList();
                
                // Calculate ranks per country
                var countryGroups = allCards.GroupBy(c => c.Country);
                foreach (var group in countryGroups)
                {
                    var sortedCards = group.OrderBy(c => c.OvrRating).ThenBy(c => c.Name).ToList();
                    int total = sortedCards.Count;
                    for (int i = 0; i < total; i++)
                    {
                        sortedCards[i].CountryRank = i + 1;
                        sortedCards[i].CountryTotalCount = total;
                    }
                }

                // Shuffle
                var rnd = new Random();
                gameState.Deck = allCards.OrderBy(x => rnd.Next()).ToList();
            }

            // Deal 5 cards each
            for (int i = 0; i < 5; i++)
            {
                if (gameState.Deck.Count > 0)
                {
                    gameState.Player1Hand.Add(gameState.Deck[0]);
                    gameState.Deck.RemoveAt(0);
                }
                if (gameState.Deck.Count > 0)
                {
                    gameState.Player2Hand.Add(gameState.Deck[0]);
                    gameState.Deck.RemoveAt(0);
                }
            }

            ActiveGames.TryAdd(gameId, gameState);
            PlayerGames.TryAdd(player1Id, gameId);
            PlayerGames.TryAdd(player2Id, gameId);

            return gameState;
        }

        public GameState? GetGameForPlayer(string playerId)
        {
            if (PlayerGames.TryGetValue(playerId, out var gameId))
            {
                if (ActiveGames.TryGetValue(gameId, out var game))
                {
                    return game;
                }
            }
            return null;
        }

        public bool DrawCard(string playerId)
        {
            var game = GetGameForPlayer(playerId);
            if (game == null) return false;
            
            if (game.CurrentTurnPlayerId != playerId) return false;
            if (game.Deck.Count == 0) return false;

            var card = game.Deck[0];
            game.Deck.RemoveAt(0);

            if (game.Player1Id == playerId)
                game.Player1Hand.Add(card);
            else
                game.Player2Hand.Add(card);

            return true;
        }

        public void EndGame(string gameId)
        {
            if (ActiveGames.TryRemove(gameId, out var game))
            {
                PlayerGames.TryRemove(game.Player1Id, out _);
                PlayerGames.TryRemove(game.Player2Id, out _);
            }
        }
    }
}
