using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0.Entities
{
    public class Ai : IOpponent, IPlayer
    {
        public List<int> Map { get; set; }
        public string Title { get; set; }
        public int Input { get; set; }

        public Ai()
        {
            Title = "Computer";
            Map = new List<int>();
        }
    }
}
