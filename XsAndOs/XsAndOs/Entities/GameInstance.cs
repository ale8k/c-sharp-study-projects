using System;
using XsAndOs.CLI;
using XsAndOs.Entities.GameMap;

namespace XsAndOs.Entities
{
    public class GameInstance
    {
        private bool _gameIsActive;
        private string _usersInput;
        private Map _map;

        public GameInstance()
        {
            _map = new Map();
        }

        public void StartGameLoop()
        {
            _gameIsActive = true;
;
            while (_gameIsActive)
            {
                Console.WriteLine(_map.GetMapString());
                Console.WriteLine("It is player 1's turn");
                _usersInput = Console.ReadLine();
                StopGameLoop(_usersInput);
            }
        }

        public void StopGameLoop(string input)
        {
            if (input.ToLower() == "stop")
            {
                _gameIsActive = false;
                Console.WriteLine("Ended game loop");
            }
        }
    }
}
