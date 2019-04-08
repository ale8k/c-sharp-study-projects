using System;
using System.Collections.Generic;

namespace NortsAndCrosses
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private readonly List<int> _gameMap;

        public Game()
        {
            _player1 = new Player(1);
            _player2 = new Player(2);
            _gameMap = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        /*
         * TODO: make player logic, someway to get the player based on their ID
         */

        public List<int> GetGameMap()
        {
            return _gameMap;
        }

        public void PrintGameMap()
        {
            foreach (int i in _gameMap)
            {
                Console.Write(i + " ");
            }
        }

        public Player GetPlayer(int playerID)
        {
            if (_player1.PlayerID == 1)
                return _player1;
            else
                return _player2;  
        }

        public bool ValidatePlayersInput(string input)
        {
            if (input.Length == 1 && Char.IsDigit(Convert.ToChar(input)) && input != "0")
                return true;
            else
                return false;
        }




    }
}
