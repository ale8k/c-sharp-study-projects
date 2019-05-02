using System;
using System.IO;

namespace CustomerRegisterApp.CLI.Commands
{
    public class Edit : ICommand
    {
        private int _areaToEdit;
        public string CommandName { get; } = "edit";

        public void RunCommand()
        {
            Console.WriteLine("Enter the customer file name you would like to edit: (e.g., Customer2)");

            Console.WriteLine("Please enter area you would like edit in the file:");
            Console.WriteLine("First name: 'first name', second name: 'second name', Mobile: 'tel' or Date of birth: 'dob'");
            _areaToEdit = GetAreaToEdit();
            Console.WriteLine(_areaToEdit);
            // split file into sub strings at the |
            // edit area according to array index, done. fappy hays
        }
        private void GetFileToEdit()
        {
            FileInfo fi1 = new FileInfo(path)
        }

        private int GetAreaToEdit()
        {
            string input = Console.ReadLine().ToLower();
            bool correctInput = false;
            while (!correctInput)
            {
                switch (input)
                {
                    case "first name":
                        correctInput = true;
                        return 1;
                    case "second name":
                        correctInput = true;
                        return 2;
                    case "tel":
                        correctInput = true;
                        return 3;
                    case "dob":
                        correctInput = true;
                        return 4;
                }

                input = Console.ReadLine().ToLower();
            }
            return 0;
        }

    }
}
