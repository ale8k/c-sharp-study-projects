using System;
using System.Collections.Generic;

namespace NortsAndCrosses
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private readonly List<int> _map;

        public Game()
        {
            _player1 = new Player(1);
            _player2 = new Player(2);

            _map = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public void GetCurrentGameMapState()
        {
            foreach (int i in _map)
            {
                Console.Write(i + " ");
            }
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
