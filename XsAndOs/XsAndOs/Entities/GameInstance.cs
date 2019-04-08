using System;
using System.Collections.Generic;
using XsAndOs.Entities.GameMap;
using XsAndOs.Entities.PlayerEntities;

namespace XsAndOs.Entities
{
    public class GameInstance
    {
        private bool _gameIsActive;
        private string _usersInput;
        private Map _map;

        private Player _player1;
        private Player _player2;

        private readonly List<int> _positions;

        public GameInstance()
        {
            _map = new Map();
            _player1 = new Player(1);
            _player2 = new Player(2);
            _positions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public void StartGameLoop()
        {
            _gameIsActive = true;

            while (_gameIsActive)
            {
                Console.WriteLine(_map.GetMapString());
                Console.WriteLine($"It is player null 's turn");
                // UpdatePlayer(PlayersTurn())
                _usersInput = Console.ReadLine();
                CheckUsersInput(_usersInput);
                StopGameLoop(_usersInput);
            }
        }

        public void CheckUsersInput(string input)
        {
            switch(input)
            {
                case "1":
                    _positions.Remove(1);
                    _player1.CurrentPositionsTaken.Add(1);
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
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
