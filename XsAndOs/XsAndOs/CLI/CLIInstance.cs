﻿using System;
using XsAndOs.Entities;

namespace XsAndOs.CLI
{
    public class CLIInstance
    {
        private Help _help = new Help();
        private GameInstance _gameInstance;
        private bool _gameActive;

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

                    _gameActive = true;
                    _gameInstance = new GameInstance(_gameActive);
                    Console.WriteLine("successfully broken out of game loop");
                    break;

                case "close":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
