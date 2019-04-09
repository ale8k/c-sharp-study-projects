using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0.Entities
{
    public class Player : IOpponent
    {
        public List<int> Map { get; set; }

        public Player()
        {
            Map = new List<int>();
        }
    }
}
