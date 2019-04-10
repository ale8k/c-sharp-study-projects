using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0.Entities
{
    public class Player : IPlayer, IOpponent
    {
        public string Title { get; set; }
        public List<int> Map { get; set; }
        public int Input { get; set; }

        public Player()
        {
            Title = "Player Opponent / Player 2";
            Map = new List<int>();
        }
    }
}
