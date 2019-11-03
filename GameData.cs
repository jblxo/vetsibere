﻿using System.Collections.Generic;

namespace vetsibere
{
    public class GameData
    {
        public static GameData Instance = new GameData();
        public int PlayersCount = 2;
        public List<Card> Cards = new List<Card>(32);
        public List<Player> Players = new List<Player>();
        public GameData() { }
    }
}
