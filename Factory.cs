using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetsibere
{
    class Factory
    {
        public Factory() { }

        /// <summary>
        /// Generates Card
        /// </summary>
        /// <param name="type">Type for card</param>
        /// <param name="name">Name for card</param>
        /// <returns>New card</returns>
        public Card CreateCard(CardTypes type, CardNames name)
        {
            Card card = new Card(type, name);
            return card;
        }

        /// <summary>
        /// Generates a player with a deck
        /// </summary>
        /// <param name="userId">Player ID</param>
        /// <param name="cards">Player's deck of Cards</param>
        /// <returns>New Player</returns>
        public Player CreatePlayer(int userId, List<Card> cards)
        {
            Player player = new Player(userId, cards);
            return player;
        }

        /// <summary>
        /// Creates a new Player UC
        /// </summary>
        /// <param name="player">Player to create UC from</param>
        /// <returns>A new Player UC</returns>
        public PlayerUC CreatePlayerUc(Player player)
        {
            PlayerUC playerUc = new PlayerUC(player);
            return playerUc;
        }
    }
}
