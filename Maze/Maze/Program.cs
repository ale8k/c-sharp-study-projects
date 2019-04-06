using System;
using Maze.CLI;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersInput = "";
            CLIObj cli = new CLIObj();

            while (true)
            {
                usersInput = Console.ReadLine();
                cli.Command(usersInput);

            }
        }
    }
}
