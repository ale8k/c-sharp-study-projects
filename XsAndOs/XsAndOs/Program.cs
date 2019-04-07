using System;
using XsAndOs.CLI;

namespace XsAndOs
{
    class Program
    {
        static void Main(string[] args)
        {
            CLIInstance cli = new CLIInstance();

            while(true)
            {
                string usersInput = Console.ReadLine();
                cli.Commands(usersInput);
                Console.WriteLine("cli loop");
            }
        }
    }
}
