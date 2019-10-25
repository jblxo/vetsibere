using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace vetsibere
{
    public partial class Game : Form
    {
        private Factory factory;
        public Game()
        {
            factory = new Factory();

            InitializeComponent();
        }

        private void Game_Load(object sender, System.EventArgs e)
        {
            GenerateCards();
            ShuffleCards();
            DistributeCards();
        }

        private void DistributeCards()
        {
            int playerCount = GameData.Instance.PlayersCount;
            var cards = GameData.Instance.Cards;
            var cardsPerPlayer = cards.Count / playerCount;
            var cardsToDiscard = cards.Count % playerCount;
            cards.RemoveRange(cards.Count - cardsToDiscard - 1, cardsToDiscard);

            Console.WriteLine(GameData.Instance.Cards.Count);
        }

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

        private void GenerateCards()
        {
            var cardTypes = Enum.GetValues(typeof(CardTypes)).Cast<CardTypes>();
            var cardNames = Enum.GetValues(typeof(CardNames)).Cast<CardNames>().ToList();
            List<Card> cards = new List<Card>();

            foreach (var cardType in cardTypes)
            {
                foreach (var cardName in cardNames)
                {
                    Card card = factory.CreateCard(cardType, (int) cardName);
                    cards.Add(card);
                }
            }

            GameData.Instance.Cards = cards;
        }
    }
}
