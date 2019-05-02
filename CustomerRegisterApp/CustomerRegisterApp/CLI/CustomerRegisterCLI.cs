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
        private ICommand _currentCommand;
        public bool InputIsValid { get; private set; }

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
                InputIsValid = true;
            else
                InputIsValid = false;
        }

        public void CallCommand(string input)
        {
            if (_currentCommand.CommandName == input.ToLower())
                _currentCommand.RunCommand();
        }

        private bool IsInputAValidCommand(string input)
        {
            foreach (ICommand command in _commandList)
            {
                if (input.ToLower() == command.CommandName)
                {
                    _currentCommand = command;
                    return true;
                }
            }

            return false;
        }
    }
}
