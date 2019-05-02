using System;
using System.IO;
using System.Text.RegularExpressions;

/*
 * A command of the CLI for creating new customer files & creates the initial director
 */

namespace CustomerRegisterApp.CLI.Commands
{
    public class Create : ICommand
    {
        private string _path;
        public string CommandName { get; } = "create";

        public Create()
        {
            _path = Path.GetFullPath("Customers");
        }

        public void RunCommand()
        {
            CreateDirectoryIfDoesNotExist();
            CreateFileIfDoesNotExist();
        }
        private void CreateDirectoryIfDoesNotExist()
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
        }

        private void CreateFileIfDoesNotExist()
        {
            // default method to increment each customer by 1
            string path = _path + $@"\Customer{Directory.GetFiles(_path).Length}.txt";
            // Create a file to write to.
            StreamWriter sw = File.CreateText(path);
            sw.Dispose();
        }
        private string GetAndValidateUserInput()
        {
            // did not have time to learn c# regex lib, as such this is done manually

            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.Contains(@"/") || input.Contains(@"\"))
                    Console.WriteLine(@"File names cannot contain '\' or '/'");
                else
                    return input;
            }
        }

        private void CreateFileIfDoesNotExist(string fileName)
        {
            // alternative method to create custom names
            string path = $@"{_path}\{fileName}.txt";
            // Create a file to write to.
            StreamWriter sw = File.CreateText(path);
            sw.Dispose();
        }

    }
}
