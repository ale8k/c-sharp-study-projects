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
        private readonly List<int> _gameMap = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly MapConstructor mc = new MapConstructor();

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
            if(opponent is Ai)
            {
                StartAiOpponentGameLoop(mainPlayer, opponent);
            }
            else
            {
                StartPlayerOpponentGameLoop(mainPlayer, opponent);
            }
        }
        /*
         * Our main game loops, all instances of the game are held here.
         */
        public void StartAiOpponentGameLoop(MainPlayer mainPlayer, IOpponent opponent)
        {
            throw new NotImplementedException("To be done at later date");
        }

        public void StartPlayerOpponentGameLoop(MainPlayer mainPlayer, IOpponent opponent)
        {
            IOpponent playerOpponent = opponent as Player;
            while(true)
            {
                
                // idea is to have:
                // mc.Draw(_gameMap);
                Console.WriteLine("Main has:");
                foreach (int i in _gameMap)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.Write("List1 has:");
                bool mhm = mainPlayer.MainPlayerMap is null; // null issues
                foreach (int i in mainPlayer.MainPlayerMap)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(opponent.GetType());
                break;
            }
            Console.ReadLine();
        }
    }
}
