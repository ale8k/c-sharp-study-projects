using System;
using System.Collections.Generic;
using CustomerRegisterApp.CLI.Commands;
/*
 * Responds to input and calls appropriate command
 */

namespace CustomerRegisterApp.CLI
{
    public class CustomerRegisterCLI
    {
        private readonly List<ICommand> _commandList;
        private bool _isInputValid;

        public CustomerRegisterCLI()
        {
            _commandList = new List<ICommand>() {
                new Create(),
                new Delete()
            };
        }

        public void ValidateUsersInput(string input)
        {
            if (IsInputAValidCommand(input))
                Console.WriteLine("valid");
            else
                _isInputValid = false;
        }

        private bool IsInputAValidCommand(string input)
        {
            foreach (ICommand command in _commandList)
            {
                if (input.ToLower() == command.CommandName)
                    return true;
            }

            return false;
        }
    }
}
