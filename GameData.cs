using System.Collections.Generic;

namespace vetsibere
{
    class GameData
    {
        public static GameData Instance = new GameData();
        public int PlayersCount => PlayerNames.Count;
        public List<Card> Cards = new List<Card>(32);
        public List<string> PlayerNames = new List<string>();
        public List<Player> Players = new List<Player>();
        public int AutoplayTimerLength = 1;
        public GameData() { }
    }
}
