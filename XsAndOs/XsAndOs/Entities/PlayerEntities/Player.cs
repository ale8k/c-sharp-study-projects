using System.Collections.Generic;

namespace XsAndOs.Entities.PlayerEntities
{
    public class Player
    {
        public int PlayerID { get; private set; }
        private readonly List<int> _currentPositionsTaken;

        public Player(int id)
        {
            _currentPositionsTaken = new List<int>();
            PlayerID = id;
        }

        public List<int> CurrentPositionsTaken
        {
            get
            {
                return _currentPositionsTaken;
            }
        }
    }
}
