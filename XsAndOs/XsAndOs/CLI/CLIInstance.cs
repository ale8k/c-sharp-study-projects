using System;
using XsAndOs.Entities;

namespace XsAndOs.CLI
{
    public class CLIInstance
    {
        private Help _help = new Help();
        private GameInstance _gameInstance;

        public CLIInstance()
        {
            Console.WriteLine("CLI instance successfully created");
        }

        public void Commands(string usersInput)
        {
            string _usersInput = usersInput.ToLower();

            switch(_usersInput)
            {
                case "help":
                    _help.Command();
                    break;

                case "start":
                    _gameInstance = new GameInstance();
                    _gameInstance.StartGameLoop();
                    break;

                case "close":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
