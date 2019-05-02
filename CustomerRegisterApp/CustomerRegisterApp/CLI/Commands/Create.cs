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
            string path = _path + $@"\Customer{Directory.GetFiles(_path).Length}.txt";
            StreamWriter sw = File.CreateText(path);
            sw.Dispose();
        }
    }
}
