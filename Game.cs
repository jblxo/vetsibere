using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace vetsibere
{
    public partial class Game : Form
    {
        private readonly Factory _factory;
        private List<Player> players;

        /// <summary>
        /// Current cards on the field
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// Cards that will be added after single player has won.
        /// </summary>
        private List<Card> cardsPile;
        public Game()
        {
            _factory = new Factory();
            players = GameData.Instance.Players;
            cards = new List<Card>();
            cardsPile = new List<Card>();

            InitializeComponent();
        }

        private void Game_Load(object sender, System.EventArgs e)
        {
            GenerateCards();
            ShuffleCards();
            DistributeCards();
            AddPlayerUc();
        }

        /// <summary>
        /// Adds Player UC to panel
        /// </summary>
        private void AddPlayerUc()
        {
            foreach (var player in players)
            {
                PlayerUC playerUc = _factory.CreatePlayerUc(player);
                playerUCPanel.Controls.Add(playerUc);
            }
        }

        /// <summary>
        /// Adds Card to the Game Field Panel
        /// </summary>
        /// <param name="card">Card to be displayed</param>
        private void DisplayCard(Card card)
        {
            gameField.Controls.Add(card);
        }

        /// <summary>
        /// Generates players and gives them cards
        /// </summary>
        private void DistributeCards()
        {
            int playerCount = GameData.Instance.PlayersCount;
            var cards = GameData.Instance.Cards;
            var cardsPerPlayer = cards.Count / playerCount;
            var cardsToDiscard = cards.Count % playerCount;
            cards.RemoveRange(cards.Count - cardsToDiscard - 1, cardsToDiscard);

            for (int i = 0; i < playerCount; i++)
            {
                var playerCards = cards.GetRange(i * cardsPerPlayer, cardsPerPlayer);
                Player player = _factory.CreatePlayer(i, playerCards);
                GameData.Instance.Players.Add(player);
            }
        }

        /// <summary>
        /// Shuffles cards
        /// </summary>
        private void ShuffleCards()
        {
            Random r = new Random();

            for (int i = 0; i < 2000; i++)
            {
                int position = r.Next(GameData.Instance.Cards.Count);
                int newPosition = r.Next(GameData.Instance.Cards.Count);

                Card card = GameData.Instance.Cards[position];
                GameData.Instance.Cards[position] = GameData.Instance.Cards[newPosition];
                GameData.Instance.Cards[newPosition] = card;
            }
        }

        /// <summary>
        /// Generates cards
        /// </summary>
        private void GenerateCards()
        {
            var cardTypes = Enum.GetValues(typeof(CardTypes)).Cast<CardTypes>().ToList();
            var cardNames = Enum.GetValues(typeof(CardNames)).Cast<CardNames>().ToList();
            List<Card> cards = new List<Card>();

            foreach (var cardType in cardTypes)
            {
                foreach (var cardName in cardNames)
                {
                    Card card = _factory.CreateCard(cardType, cardName);
                    cards.Add(card);
                }
            }

            GameData.Instance.Cards = cards;
        }

        /// <summary>
        /// Controls stepped game-play
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event Args</param>
        private void BtnRound_Click(object sender, EventArgs e)
        {
            PlayRound(players);
            RefreshPlayerPanel();
        }

        /// <summary>
        /// Refreshes Player UC data
        /// </summary>
        private void RefreshPlayerPanel()
        {
            List<PlayerUC> playerUcs = playerUCPanel.Controls.OfType<PlayerUC>().ToList();
            foreach (var playerUc in playerUcs)
            {
                playerUc.RefreshData();
            }
        }

        /// <summary>
        /// Code which handles one player turn
        /// </summary>
        /// <param name="playersList">List of players who are currently playing</param>
        private void PlayRound(List<Player> playersList)
        {
            EmptyField();
            TakePlayersCards(playersList);
            List<Card> winners = GetWinnerCards();
            if (winners.Count > 1)
            {
                PlayRound(SelectWinnerPlayers(winners));
            }
            SelectWinnerPlayers(winners)[0].AddCards(cards);
            CheckEnd();
        }

        /// <summary>
        /// Removes players with no cards left. Check for game winner.
        /// </summary>
        private void CheckEnd()
        {
            List<Player> playersToRemove = new List<Player>();

            foreach (var player in players)
            {
                if (player.Cards.Count == 0)
                {
                    playersToRemove.Add(player);
                }
            }

            foreach (var player in playersToRemove)
            {
                players.Remove(player);
            }

            if (players.Count == 0)
            {
                MessageBox.Show("Vyhral hrac " + players[0].Name);
                Close();
            }
        }

        /// <summary>
        /// Select players whose cards have won (same value)
        /// </summary>
        /// <param name="winners">List of cards</param>
        /// <returns>List of players</returns>
        private List<Player> SelectWinnerPlayers(List<Card> winners)
        {
            List<Player> winnerPlayers = new List<Player>(winners.Count);

            foreach (var card in winners)
            {
                winnerPlayers.Add(card.Owner);
            }

            return winnerPlayers;
        }

        /// <summary>
        /// Empty the field and cards list
        /// </summary>
        private void EmptyField()
        {
            cards.Clear();
            gameField.Controls.Clear();
        }

        /// <summary>
        /// Returns list of cards with highest value on the field. Adds loser cards to cards pile.
        /// </summary>
        /// <returns>List of cards with highest value</returns>
        private List<Card> GetWinnerCards()
        {
            var highestValueCard = cards.Max(x => (int) x.CardName);
            var winnerCards = cards.Where(x => (int) x.CardName == highestValueCard).ToList();
            var loserCards = cards.Where(x => (int)x.CardName != highestValueCard).ToList();
            cardsPile.AddRange(loserCards);
            return winnerCards;
        }


        /// <summary>
        /// Removes card from top of player's deck and puts it on the field
        /// </summary>
        private void TakePlayersCards(List<Player> playersList)
        {
            foreach (var player in playersList)
            {
                Card card = player.PopCard();
                cards.Add(card);
                DisplayCard(card);
            }
        }
    }
}
