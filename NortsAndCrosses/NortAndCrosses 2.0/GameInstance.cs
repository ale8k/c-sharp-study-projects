using System;
using System.Collections.Generic;
using NortAndCrosses_2._0.Entities;
using NortAndCrosses_2._0.Validators;

/*
 * Ai implementation will come after.
 * For now, only player will be completed.
 */

namespace NortAndCrosses_2._0
{
    public class GameInstance
    {
        private readonly MainPlayer _mainPlayer = new MainPlayer();
        private string _opponentType;
        private readonly IOpponent _opponent;
        private readonly List<int> _gameMap = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly SequenceValidator sv = new SequenceValidator();
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
            bool winnerHasBeenFound = false;
            IPlayer ipOpponent = (IPlayer)opponent;

            while (!winnerHasBeenFound)
            {

                // mc.Draw(_gameMap);
                Console.WriteLine("Left in the game:");
                foreach (int i in _gameMap)
                {
                    Console.Write(i + " ");
                }

                TakeTurnFor(mainPlayer);
                // update map
                winnerHasBeenFound = HasPlayerWon(mainPlayer);

                TakeTurnFor(ipOpponent);
                // update map
                winnerHasBeenFound = HasPlayerWon(ipOpponent);

                if (winnerHasBeenFound)
                    Console.ReadLine();
            } 
        }

        private bool ValidInputForMap(List<int> gameMap, int input)
        {
            if (gameMap.Contains(input))
                return true;
            else
                return false;
        }

        private int ValidatePlayersInput(IPlayer player, List<int> gameMap)
        {
            bool mapValidated = false;
            
            while (!mapValidated)
            {
                player.Input = UserInputValidator.ValidateInput(Console.ReadLine());
                mapValidated = ValidInputForMap(gameMap, player.Input);

                if(!mapValidated)
                    Console.WriteLine($"Please pick a number on the map, {player.Input} couldn't be found");
            }
            return player.Input;
        }

        private void TakeTurnFor(IPlayer player)
        {
            Console.WriteLine($"It is {player.Title}'s turn");
            int pInput = ValidatePlayersInput(player, _gameMap);
            player.Map.Add(pInput);
            _gameMap.Remove(pInput);
        }

        private bool HasPlayerWon(IPlayer player)
        {
            bool won = sv.ValidateSequence(player.Map);

            if (won)
            {
                Console.WriteLine($"{player.Title} has won.");
                return true;
            }
            return false;
        }

    }
}
