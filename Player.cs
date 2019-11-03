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
        public string Name { get; set; }

        public Player(string name,int playerNum, List<Card> cards)
        {
            this.Name = name;
            foreach (var card in cards)
            {
                card.Owner = this;
                card.DisplayOwnerName();
            }

            this.PlayerNum = playerNum;
            this.Cards = cards;
        }

        /// <summary>
        /// Removes and returns next card in players deck
        /// </summary>
        /// <returns>Card</returns>
        public Card PopCard()
        {
            Card card = Cards.ElementAtOrDefault(0);
            Cards.Remove(card);
            return card;
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
        /// Adds cards to player's deck. Changes the ownership of the cards.
        /// </summary>
        /// <param name="newCards">List of cards</param>
        public void AddCards(List<Card> newCards)
        {
            foreach(var card in newCards)
            {
                card.Owner = this;
            }

            this.Cards.AddRange(newCards);
        }

        /// <summary>
        /// Adds card to player's deck. Changes the ownership of the card.
        /// </summary>
        /// <param name="card">Card to be added</param>
        public void AddCards(Card card)
        {
            card.Owner = this;

            this.Cards.Add(card);
        }
    }
}
