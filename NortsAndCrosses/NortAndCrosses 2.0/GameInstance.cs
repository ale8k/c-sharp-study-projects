﻿using System;
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
        private readonly List<int> _gameMap = new List<int> {  2, 3, 4, 5, 6, 7, 8, 9 };
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
            IPlayer ipOpponent = (IPlayer)opponent;

            while (true)
            {

                // mc.Draw(_gameMap);
                Console.WriteLine("Left in the game:");
                foreach (int i in _gameMap)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine(mainPlayer.Title);
                int mpsInput = ValidatePlayersMap(mainPlayer, _gameMap);
                Console.WriteLine("main players input is on the map and is ok to use");

                Console.WriteLine(ipOpponent.Title);
                int opsInput = ValidatePlayersMap(ipOpponent, _gameMap);
                Console.WriteLine("opponents input validated boyo continue m'lord");
                
            } 
        }

        private bool ValidateMap(List<int> gameMap, int input)
        {
            if (gameMap.Contains(input))
                return true;
            else
                return false;
        }

        private int ValidatePlayersMap(IPlayer player, List<int> gameMap)
        {
            bool mapValidated = false;
            
            while (!mapValidated)
            {
                player.Input = UserInputValidator.ValidateInput(Console.ReadLine());
                mapValidated = ValidateMap(gameMap, player.Input);

                if(!mapValidated)
                    Console.WriteLine($"Please pick a number on the map, {player.Input} couldn't be found");
            }
            return player.Input;
        }
    }
}
