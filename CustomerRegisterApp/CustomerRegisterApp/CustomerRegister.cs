using System;
using System.Collections.Generic;
using System.IO;
using CustomerRegisterApp.CLI;

/*
 * Represents the App as a class, ideally just for composition
 */

namespace CustomerRegisterApp
{
    public class CustomerRegister
    {
        private readonly FileManager _fm;
        private readonly CustomerRegisterCLI _cli;

        public CustomerRegister()
        {
            _fm = new FileManager();
            _cli = new CustomerRegisterCLI();
            CreateInstance(_cli, _fm);
        }

        private void CreateInstance(CustomerRegisterCLI CLI, FileManager FM)
        {
            CustomerRegisterCLI cli = CLI;
            FileManager fm = FM;

            string usersInput;

            while (true)
            {
                Console.WriteLine("Please enter a command:");
                usersInput = Console.ReadLine();
                cli.ValidateUsersInput(usersInput); // validates if input is a command name
                if (cli.InputIsValid) // property to check input
                    cli.CallCommand(usersInput); // call command if input is golden
                else
                    Console.WriteLine("Sorry, that is not a command.");
            }
        }
    }
}
