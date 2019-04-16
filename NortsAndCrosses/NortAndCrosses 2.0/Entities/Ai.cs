using System.Collections.Generic;
using NortAndCrosses_2._0;

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

        public void TakeTurn(List<int> gameMap)
        {
            // get comp input, use method below to just validate everything is ok for sure

            // does the input the computer has done exist in game map??
            GameInstance.ValidInputForMap(gameMap, 0); // something to think about
        }
    }
}
