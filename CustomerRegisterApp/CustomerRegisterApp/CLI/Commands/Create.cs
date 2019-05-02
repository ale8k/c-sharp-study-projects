using System;

/*
 * A command of the CLI for creating new customer files
 */

namespace CustomerRegisterApp.CLI.Commands
{
    public class Create : ICommand
    {
        private FileManager _fm;
        public string CommandName { get; } = "create";

        public Create(FileManager FM)
        {
            _fm = FM;
        }

        public void RunCommand()
        {
            Console.Clear();
            Console.WriteLine("Running create");
            Console.ReadLine();
        }


    }
}
