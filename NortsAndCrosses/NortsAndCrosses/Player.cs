using System;
using System.Collections.Generic;

namespace NortsAndCrosses
{
    public class Player
    {

        public int PlayerID { get; private set; }

        public List<int> PlayersMap { get; set; }

        public Player(int id)
        {
            PlayerID = id;
            PlayersMap = new List<int>();
        }
    }
}
