using System;
using System.Collections.Generic;
using NortAndCrosses_2._0.Entities;

/*
 * Ai implementation will come after.
 * For now, only player will be completed.
 */

namespace NortAndCrosses_2._0
{
    public class GameInstance
    {
        private string _opponentType;
        private readonly MainPlayer _mainPlayer = new MainPlayer();
        private readonly IOpponent _opponent;

        public GameInstance()
        {
            _opponentType = SelectOpponentType();
            _opponent = CreateOpponent(_opponentType);
            InitaliseGameLoop(_mainPlayer, _opponent);
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

        private IOpponent CreateOpponent(string opType)
        {
            if (opType == "ai")
                return new Ai();
            else
                return new Player();
        }

        private void InitaliseGameLoop(MainPlayer mainPlayer, IOpponent opponent)
        {

        }
    }
}
