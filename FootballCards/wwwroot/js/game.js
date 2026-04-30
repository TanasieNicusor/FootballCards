const connection = new signalR.HubConnectionBuilder()
    .withUrl("/gameHub")
    .build();

const findMatchBtn = document.getElementById("find-match-btn");
const lobbyStatus = document.getElementById("lobby-status");

const lobbyView = document.getElementById("lobby-view");
const gameView = document.getElementById("game-view");

const myHand = document.getElementById("my-hand");
const oppHand = document.getElementById("opponent-hand");
const mySlot = document.getElementById("my-play-slot");
const oppSlot = document.getElementById("opponent-play-slot");

const myScoreEl = document.getElementById("my-score");
const oppScoreEl = document.getElementById("opponent-score");
const deckCountEl = document.getElementById("deck-count");
const myStatusEl = document.getElementById("my-status");
const oppStatusEl = document.getElementById("opponent-status");
const roundNumberEl = document.getElementById("round-number");

const deckDrawEl = document.getElementById("deck-draw");

let myId = null;
let isRoundAnimating = false;

// Connect to SignalR
connection.start().catch(err => console.error(err.toString()));

findMatchBtn.addEventListener("click", () => {
    findMatchBtn.disabled = true;
    lobbyStatus.innerText = "Joining queue...";
    connection.invoke("FindMatch").catch(err => console.error(err.toString()));
});

// SignalR Events
connection.on("WaitingForMatch", () => {
    lobbyStatus.innerText = "Waiting for an opponent...";
});

connection.on("GameStarted", (state) => {
    lobbyView.classList.add("d-none");
    gameView.classList.remove("d-none");
    updateUI(state);
});

connection.on("UpdateState", (state) => {
    // Don't wipe play slots while a round result animation is still playing
    if (!isRoundAnimating) {
        mySlot.innerHTML = '';
        oppSlot.innerHTML = '';
    }
    updateUI(state);

    if (!isRoundAnimating) {
        if (state.myPlayedCards && state.myPlayedCards.length > 0) {
            state.myPlayedCards.forEach(card => {
                mySlot.insertAdjacentHTML('beforeend', createCardHtml(card));
                mySlot.lastElementChild.classList.add("played-card");
            });
        }
        if (state.opponentPlayedCards && state.opponentPlayedCards.length > 0) {
            state.opponentPlayedCards.forEach(card => {
                oppSlot.insertAdjacentHTML('beforeend', createCardHtml(card));
                oppSlot.lastElementChild.classList.add("played-card");
            });
        }
    }
});

connection.on("RoundResult", async (result) => {
    isRoundAnimating = true;
    mySlot.innerHTML = '';
    oppSlot.innerHTML = '';

    const myCards = result.myCards;
    const oppCards = result.opponentCards;

    let tieAlert = document.getElementById('tiebreak-alert');
    let myTieSumEl = document.getElementById('my-tie-sum');
    let oppTieSumEl = document.getElementById('opponent-tie-sum');
    let myTieSumVal = myTieSumEl ? myTieSumEl.querySelector('span') : null;
    let oppTieSumVal = oppTieSumEl ? oppTieSumEl.querySelector('span') : null;

    let isTiebreak = myCards.length > 1;

    let myCurrentSum = 0;
    let oppCurrentSum = 0;

    // Sequential reveal - one pair at a time
    for (let i = 0; i < myCards.length; i++) {
        mySlot.insertAdjacentHTML('beforeend', createCardHtml(myCards[i]));
        oppSlot.insertAdjacentHTML('beforeend', createCardHtml(oppCards[i]));

        mySlot.lastElementChild.classList.add("played-card");
        oppSlot.lastElementChild.classList.add("played-card");

        if (isTiebreak) {
            if (i === 0) {
                // Show the cards that tied
                await new Promise(r => setTimeout(r, 300));

                // Flash the TIEBREAK message for 2 seconds
                if (tieAlert) tieAlert.classList.remove('d-none');
                await new Promise(r => setTimeout(r, 2000));
                if (tieAlert) tieAlert.classList.add('d-none');

                // Show the summations and wait briefly before drawing tiebreak cards
                if (myTieSumEl) myTieSumEl.classList.remove('d-none');
                if (oppTieSumEl) oppTieSumEl.classList.remove('d-none');
                if (myTieSumVal) myTieSumVal.innerText = '0';
                if (oppTieSumVal) oppTieSumVal.innerText = '0';
                await new Promise(r => setTimeout(r, 2500));
            } else {
                myCurrentSum += myCards[i].ovrRating;
                oppCurrentSum += oppCards[i].ovrRating;
                if (myTieSumVal) myTieSumVal.innerText = myCurrentSum;
                if (oppTieSumVal) oppTieSumVal.innerText = oppCurrentSum;
                await new Promise(r => setTimeout(r, 1500));
            }
        }
    }

    const allMyEls = Array.from(mySlot.querySelectorAll('.card-item'));
    const allOppEls = Array.from(oppSlot.querySelectorAll('.card-item'));

    // Show winner/loser glow after 600ms
    await new Promise(r => setTimeout(r, 600));
    if (result.winnerId === myId) {
        allMyEls.forEach(el => el.classList.add("winner-glow"));
        allOppEls.forEach(el => el.classList.add("loser-dim"));
    } else if (result.winnerId !== "") {
        allOppEls.forEach(el => el.classList.add("winner-glow"));
        allMyEls.forEach(el => el.classList.add("loser-dim"));
    }

    // Collection animation after 2 more seconds
    await new Promise(r => setTimeout(r, 2000));
    if (result.winnerId !== "") {
        const animClass = result.winnerId === myId ? "collect-win" : "collect-loss";
        allMyEls.forEach(el => el.classList.add(animClass));
        allOppEls.forEach(el => el.classList.add(animClass));
    }

    // Clear after animation finishes
    await new Promise(r => setTimeout(r, 700));
    mySlot.innerHTML = '';
    oppSlot.innerHTML = '';

    if (isTiebreak) {
        if (tieAlert) tieAlert.classList.add('d-none');
        if (myTieSumEl) myTieSumEl.classList.add('d-none');
        if (oppTieSumEl) oppTieSumEl.classList.add('d-none');
    }

    isRoundAnimating = false;
});

connection.on("GameEnded", async (result) => {
    // Wait for the final round's animations to complete fully before showing Game Over
    while (isRoundAnimating) {
        await new Promise(r => setTimeout(r, 200));
    }

    isRoundAnimating = true;

    // Brief delay after the round clears before transitioning
    await new Promise(r => setTimeout(r, 1000));
    gameView.classList.add("d-none");
    const endGameView = document.getElementById("end-game-view");
    endGameView.classList.remove("d-none");

    const isP1 = myId === result.p1Id;
    const myTop11 = isP1 ? result.p1Top11 : result.p2Top11;
    const oppTop11 = isP1 ? result.p2Top11 : result.p1Top11;

    const myRoundsWon = isP1 ? result.p1RoundsWon : result.p2RoundsWon;
    const oppRoundsWon = isP1 ? result.p2RoundsWon : result.p1RoundsWon;

    const myTotalTarget = isP1 ? result.p1TotalScore : result.p2TotalScore;
    const oppTotalTarget = isP1 ? result.p2TotalScore : result.p1TotalScore;

    const myGrid = document.getElementById("my-reveal-grid");
    const oppGrid = document.getElementById("opp-reveal-grid");
    const myCalc = document.getElementById("calc-my-score");
    const oppCalc = document.getElementById("calc-opp-score");
    const roundInfo = document.getElementById("calc-round-info");

    let myCurrentTally = 0;
    let oppCurrentTally = 0;

    // 1. Reveal Round Bonus first
    roundInfo.innerText = "MATCH BONUS (+3 per win)";
    await new Promise(r => setTimeout(r, 1000));

    const myBonus = myRoundsWon * 3;
    const oppBonus = oppRoundsWon * 3;

    if (myBonus > 0) {
        myCalc.parentElement.classList.add("bonus-animation");
        myCurrentTally += myBonus;
        animateScore(myCalc, myCurrentTally);
    }
    if (oppBonus > 0) {
        oppCalc.parentElement.classList.add("bonus-animation");
        oppCurrentTally += oppBonus;
        animateScore(oppCalc, oppCurrentTally);
    }

    await new Promise(r => setTimeout(r, 2000));
    myCalc.parentElement.classList.remove("bonus-animation");
    oppCalc.parentElement.classList.remove("bonus-animation");

    // 2. Reveal Top 11 Cards one by one
    roundInfo.innerText = "TOP 11 REVEAL";
    const maxCards = Math.max(myTop11.length, oppTop11.length);

    for (let i = 0; i < maxCards; i++) {
        if (myTop11[i]) {
            myGrid.insertAdjacentHTML('beforeend', createCardHtml(myTop11[i]));
            const cardEl = myGrid.lastElementChild;
            cardEl.classList.add("reveal-card");
            myCurrentTally += myTop11[i].ovrRating;
            animateScore(myCalc, myCurrentTally);
        }

        if (oppTop11[i]) {
            oppGrid.insertAdjacentHTML('beforeend', createCardHtml(oppTop11[i]));
            const cardEl = oppGrid.lastElementChild;
            cardEl.classList.add("reveal-card");
            oppCurrentTally += oppTop11[i].ovrRating;
            animateScore(oppCalc, oppCurrentTally);
        }

        await new Promise(r => setTimeout(r, 800));
    }

    // Final check to match exact server scores
    animateScore(myCalc, myTotalTarget);
    animateScore(oppCalc, oppTotalTarget);

    await new Promise(r => setTimeout(r, 2000));

    // 3. Show Final Overlay
    const winnerText = result.winnerId === myId ? "MATCH WINNER!" : (result.winnerId === "" ? "STALEMATE" : "DEFEAT");
    const summary = `
        <div class="game-over-overlay">
            <h1 style="font-size: 5rem;">${winnerText}</h1>
            <div class="score-summary">
                <div class="score-col">
                    <h3>YOU</h3>
                    <p class="final-score" style="color: #00ff88;">${myTotalTarget}</p>
                </div>
                <div class="score-col">
                    <h3 style="color: #666;">VS</h3>
                </div>
                <div class="score-col">
                    <h3>OPPONENT</h3>
                    <p class="final-score" style="color: #e74c3c;">${oppTotalTarget}</p>
                </div>
            </div>
            <button class="main-btn mt-4 px-5 py-3 fs-3 rounded-pill" onclick="location.reload()">REMATCH</button>
        </div>
    `;
    document.body.insertAdjacentHTML('beforeend', summary);
});

function animateScore(element, target) {
    const startValue = parseInt(element.innerText) || 0;
    const duration = 600;
    const startTime = performance.now();

    function update(currentTime) {
        const elapsed = currentTime - startTime;
        const progress = Math.min(elapsed / duration, 1);
        const currentValue = Math.floor(startValue + (target - startValue) * progress);
        element.innerText = currentValue;

        if (progress < 1) {
            requestAnimationFrame(update);
        }
    }
    requestAnimationFrame(update);
}

connection.on("OpponentDisconnected", () => {
    alert("Opponent disconnected. You win!");
    location.reload();
});


function updateUI(state) {
    if (state.myId) myId = state.myId;

    myScoreEl.innerText = state.myScore;
    oppScoreEl.innerText = state.opponentScore;
    //deckCountEl.innerText = state.deckCount;

    if (roundNumberEl) {
        roundNumberEl.innerText = Math.min(state.totalRoundsPlayed + 1, 15); // rounds at html file (now 1-15)
    }

    if (state.isMyTurn) {
        myTurnUIUpdate(state);
    } else {
        opponentTurnUIUpdate(state);
    }

    // Render Hands
    renderMyHand(state.myHand, state.isMyTurn, state.iPlayed);
    renderOpponentHand(state.opponentHandCount);
}

function myTurnUIUpdate(state) {

    myScoreEl.innerText = state.myScore;
    oppScoreEl.innerText = state.opponentScore;

    myStatusEl.innerText = "Your Turn";
    myStatusEl.classList.add("active");
    oppStatusEl.innerText = "Waiting...";
    oppStatusEl.classList.remove("active");
}

function opponentTurnUIUpdate(state) {
    myScoreEl.innerText = state.myScore;
    oppScoreEl.innerText = state.opponentScore;

    myStatusEl.innerText = "Waiting...";
    myStatusEl.classList.remove("active");
    oppStatusEl.innerText = "Their Turn";
    oppStatusEl.classList.add("active");
}

let previousHandLength = 0;

function renderMyHand(cards, isMyTurn, iPlayed) {
    const isNewDraw = cards.length > previousHandLength;
    previousHandLength = cards.length;

    myHand.innerHTML = "";
    cards.forEach((card, index) => {
        const cardHtml = createCardHtml(card);
        myHand.insertAdjacentHTML('beforeend', cardHtml);
        const cardEl = myHand.lastElementChild;

        // Add draw animation if this is the new card
        if (isNewDraw && index === cards.length - 1) {
            cardEl.classList.add("draw-animate");
        }

        cardEl.addEventListener("click", () => {
            playCard(card.id, isMyTurn, iPlayed);
        });
    });
}

function playCard(cardId, canPlay, alreadyPlayed) {
    if (canPlay && !isRoundAnimating && !alreadyPlayed) {
        connection.invoke("PlayCard", cardId).catch(err => console.error(err.toString()));
    }
}

function renderOpponentHand(count) {
    oppHand.innerHTML = "";
    for (let i = 0; i < count; i++) {
        oppHand.insertAdjacentHTML('beforeend', '<div class="card-back shadow-sm"></div>');
    }
}

function createCardHtml(card) {
    let imgPath = card.cardImage && card.cardImage !== "tbd"
        ? `url(${card.cardImage})`
        : "linear-gradient(135deg, #1f4037, #99f2c8)";

    let iconClass = card.isIcon ? "icon-card" : "";

    return `
        <div class="card-item shadow ${iconClass}" style="background-image: ${imgPath}">
            <div class="card-header">${card.name}
            </div>
            <div class="card-body">
            </div>
            <div class="card-footer">
                <span class="ovr-label">OVR: ${card.ovrRating}</span>
                <span class="ovr-label">${card.countryRank}/${card.countryTotalCount}</span>
            </div>
        </div>
    `;
}
