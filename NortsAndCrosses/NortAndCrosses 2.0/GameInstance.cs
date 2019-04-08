using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NortAndCrosses_2._0.Entities;
/*
 * Ai implementation will come after.
 * For now, only player will be completed.
 */

namespace NortAndCrosses_2._0
{
    public class GameInstance
    {
        private string opponentType;
        private IOpponent opponent;

        public GameInstance()
        {
            opponentType = SelectOpponentType();

            opponent = SelectOpponent(opponentType);
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

        private IOpponent SelectOpponent(string opType)
        {
            if (opType == "ai")
                return new Ai();
            else
                return new Player();
        }
    }
}
