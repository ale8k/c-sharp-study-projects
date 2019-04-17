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
            // Input = compLogic(); // delegate of comp logic methods?

            // comp logic should check if a pattern is missing a piece of its pattern
            // if it is, then that is the next choice for the computer
            // pattern set must be built up of say 123, 147, 456 etc etc
            // compare comp list, to game list, what pattern does comp have and is it available
            // in the game list to complete, if yes, choose this
            // if no, try next pattern

            // TODO: clean this logic up and implement

            // WITH comp input, use method below to just validate everything is ok for sure

            // does the input the computer has done exist in game map??
            GameInstance.ValidInputForMap(gameMap, 0); // something to think about
        }
    }
}
