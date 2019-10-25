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
        public Game()
        {
            _factory = new Factory();
            players = GameData.Instance.Players;
            cards = new List<Card>();

            InitializeComponent();
        }

        private void Game_Load(object sender, System.EventArgs e)
        {
            GenerateCards();
            ShuffleCards();
            DistributeCards();
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
            EmptyField();
            TakePlayersCards();
            List<Card> winners = GetWinnerCards();
            Player winner = CheckWinner(winners);
            winner.AddCards(cards);
            CheckEnd();
        }

        private void CheckEnd()
        {
            foreach (var player in players)
            {
                Console.WriteLine("Cards left: " + player.Cards.Count);
                if (player.Cards.Count == 0)
                {
                    this.Close();
                }
            }
        }

        private Player CheckWinner(List<Card> winners)
        {
            if (winners.Count == 1)
            {
                var winner = winners[0];
                return winner.Owner;
            }
            
            // TODO: implement cards with same value

            return null;
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
        /// Returns list of cards with highest value on the field
        /// </summary>
        /// <returns>List of cards with highest value</returns>
        private List<Card> GetWinnerCards()
        {
            var highestValueCard = cards.Max(x => (int) x.CardName);
            var winnerCards = cards.Where(x => (int) x.CardName == highestValueCard).ToList();
            return winnerCards;
        }


        /// <summary>
        /// Removes card from top of player's deck and puts it on the field
        /// </summary>
        private void TakePlayersCards()
        {
            foreach (var player in players)
            {
                Card card = player.PopCard();
                cards.Add(card);
                DisplayCard(card);
                player.RemoveCard(card);
            }
        }
    }
}
