using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0.Entities
{
    public class MainPlayer : IPlayer
    {
        public string Title { get; set; } 
        public List<int> Map { get; set; }
        public int Input { get; set; }

        public MainPlayer()
        {
            Title = "Main Player / Player 1: O's";
            Map = new List<int>();
        }
    }
}
