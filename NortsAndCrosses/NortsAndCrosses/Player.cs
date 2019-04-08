using System;
using System.Collections.Generic;

namespace NortsAndCrosses
{
    public class Player
    {

        public int PlayerID { get; private set; }
        private List<int> _playersMap;

        public Player(int id)
        {
            PlayerID = id;
            _playersMap = new List<int>();
        }

        public List<int> PlayersMap
        {
            get
            {
                return _playersMap;
            }
        }
    }

}
