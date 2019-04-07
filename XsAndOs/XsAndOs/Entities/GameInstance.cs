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
            Console.WriteLine("Game instance successfully created.");
        }

        public void StartGameLoop()
        {
            _gameIsActive = true;
            _map = new Map();

            while (_gameIsActive)
            {
                _usersInput = Console.ReadLine();
                Console.WriteLine(_map.UpdateMap());
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
