using System;

namespace XsAndOs.Entities
{
    public class GameInstance
    {
        private bool _gameIsActive;
        private string _usersInput;

        public GameInstance(bool gameIsActive)
        {
            Console.WriteLine("Game instance successfully created");
            _gameIsActive = true;

            while (_gameIsActive)
            {
                _usersInput = Console.ReadLine();

                
                CheckForStop(_usersInput);
                Console.WriteLine("game active loop");
            }
        }

        private void CheckForStop(string usersInput)
        {
            usersInput.ToLower();
            if (usersInput == "stop")
            {
                _gameIsActive = false;
                Console.WriteLine("Game successfully stopped.");
            }
        }


    }
}
