using System.Collections.Generic;

namespace vetsibere
{
    class GameData
    {
        public static GameData Instance = new GameData();
        public int PlayersCount = 2;
        public List<Card> Cards = new List<Card>(32);
        public GameData() { }
    }
}
