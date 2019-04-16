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
            Console.WriteLine("What kind of opponent would you like? 'Ai' or 'Human'");
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
                Console.BackgroundColor = ConsoleColor.White;
                StartPlayerOpponentGameLoop(mainPlayer, opponent);
            }
        }
        /*
         * Our main game loops, all instances of the game are held here.
         */
        public void StartAiOpponentGameLoop(MainPlayer mainPlayer, IOpponent opponent)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            // throw new NotImplementedException("To be done at later date");
            mc.Draw(_gameMap, mainPlayer, opponent as Player);

            while (true)
            {
                Play(_gameMap, mainPlayer, opponent as IPlayer);
                Play(_gameMap, opponent as IPlayer, mainPlayer);
            }
            
        }

        public void StartPlayerOpponentGameLoop(MainPlayer mainPlayer, IOpponent opponent)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            IPlayer ipOpponent = (IPlayer)opponent;
            mc.Draw(_gameMap, mainPlayer, ipOpponent);

            while (true)
            {
                Play(_gameMap, mainPlayer, ipOpponent);
                Play(_gameMap, ipOpponent, mainPlayer);
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
            if (player is Ai == false)
            {
                Console.WriteLine($"It is {player.Title}'s turn");
                int pInput = ValidatePlayersInput(player, _gameMap);
                player.Map.Add(pInput);
                _gameMap.Remove(pInput);
            }
            else
            {
                Console.WriteLine(player.Title + " is taking a turn...");
                // computer ai logic.
                player.Map.Add(1);

                Console.WriteLine("Turn taken for" + player.Title);
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }

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

        private void Play(List<int> gameMap, IPlayer currentPlayerTurn, IPlayer opponent)
        {
            bool winnerHasBeenFound;

            TakeTurnFor(currentPlayerTurn);
            
            winnerHasBeenFound = HasPlayerWon(currentPlayerTurn);

            if (winnerHasBeenFound)
            {
                Console.Clear();
                Console.WriteLine($"{currentPlayerTurn.Title} wins");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (gameMap.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Draw");
                Console.ReadLine();
                Environment.Exit(0);
            }
            mc.Update(currentPlayerTurn);
            Console.Clear();
            mc.Draw(gameMap, currentPlayerTurn, opponent);
        }
    }
}
