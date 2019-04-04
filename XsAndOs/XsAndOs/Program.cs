using System;
using XsAndOs.CLI;
using XsAndOs.Entities;

// Build game command, by command.

namespace XsAndOs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game started");
            CLIInstance cli = new CLIInstance();

            while(true)
            {
                string usersInput = Console.ReadLine();
                cli.Commands(usersInput);
            }
        }
    }
}
