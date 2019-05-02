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
        private readonly CustomerRegisterCLI _cli;

        public CustomerRegister()
        {
            _cli = new CustomerRegisterCLI();
            CreateInstance(_cli);
        }

        private void CreateInstance(CustomerRegisterCLI CLI)
        {
            CustomerRegisterCLI cli = CLI;

            string usersInput;

            while (true)
            {
                Console.WriteLine("Please enter a command:");
                usersInput = Console.ReadLine();
                cli.ValidateUsersInput(usersInput); // validates if input is a command name
                if (cli.InputIsValid) // property to check input
                    cli.CallCommand(); // call command if input is golden
                else
                    Console.WriteLine("Sorry, that is not a command.");
            }
        }
    }
}
