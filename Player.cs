using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetsibere
{
    public class Player
    {
        public readonly int PlayerNum;
        public List<Card> Cards { get; }

        public Player(int playerNum, List<Card> cards)
        {
            foreach (var card in cards)
            {
                card.Owner = this;
            }

            this.PlayerNum = playerNum;
            this.Cards = cards;
        }

        /// <summary>
        /// Returns next card in players deck
        /// </summary>
        /// <returns>Card</returns>
        public Card PopCard()
        {
            return this.Cards.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Removes card from player's deck
        /// </summary>
        /// <param name="card">Card to be removed</param>
        /// <returns>If card removal was successful</returns>
        public bool RemoveCard(Card card)
        {
            return Cards.Remove(card);
        }

        /// <summary>
        /// Adds cards to player's deck
        /// </summary>
        /// <param name="newCards">List of cards</param>
        public void AddCards(List<Card> newCards)
        {
            this.Cards.AddRange(newCards);
        }

        /// <summary>
        /// Adds card to player's deck
        /// </summary>
        /// <param name="card">Card to be added</param>
        public void AddCards(Card card)
        {
            this.Cards.Add(card);
        }
    }
}
