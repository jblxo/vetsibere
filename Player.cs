using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetsibere
{
    class Player
    {
        public readonly int PlayerNum;
        private readonly List<Card> cards;

        public Player(int playerNum, List<Card> cards)
        {
            this.PlayerNum = playerNum;
            this.cards = cards;
        }

        /// <summary>
        /// Returns next card in players deck
        /// </summary>
        /// <returns>Card</returns>
        public Card PopCard()
        {
            return this.cards.ElementAtOrDefault(0);
        }
    }
}
