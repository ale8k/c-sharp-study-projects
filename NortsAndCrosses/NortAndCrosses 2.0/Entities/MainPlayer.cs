using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0.Entities
{
    public class MainPlayer
    {
        public List<int> MainPlayerMap { get; set; }
        public int MainPlayerInput { get; set; }

        public MainPlayer()
        {
            MainPlayerMap = new List<int>();
        }
    }
}
