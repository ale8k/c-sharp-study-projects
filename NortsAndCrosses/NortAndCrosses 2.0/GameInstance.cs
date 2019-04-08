using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0
{
    public class GameInstance
    {
        private string opponentType;
        private IOpponent opponent;

        public GameInstance()
        {
            opponentType = SelectOpponentType();
        }

        private string SelectOpponentType()
        {
            bool found = false;
            string opType = "no opponent found";
            while(!found)
            {
                opType = Console.ReadLine();
                if (opType.ToLower() == "ai" || opType.ToLower() == "human")
                    found = true;
            }
            return opType;
        }
    }
}
