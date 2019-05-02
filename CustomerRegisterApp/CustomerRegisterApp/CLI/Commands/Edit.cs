using System;
using System.IO;

namespace CustomerRegisterApp.CLI.Commands
{
    public class Edit : ICommand
    {
        private FileInfo _fi;
        private int _areaToEdit;
        
        public string CommandName { get; } = "edit";

        public void RunCommand()
        {
            Console.WriteLine("Enter the customer ID of the customer you would like to edit: (e.g., 2)");
            GetFileToEdit(Console.ReadLine());

            Console.WriteLine("Please enter area you would like edit in the file:");
            Console.WriteLine("First name: 'first name', second name: 'second name', Mobile: 'tel' or Date of birth: 'dob'");
            _areaToEdit = GetAreaToEdit();

            EditFileArea(_fi, _areaToEdit);
        }
        private void GetFileToEdit(string ID)
        {
            FileInfo fi = new FileInfo(Path.GetFullPath($@"Customers\Customer{ID}.txt"));
            if (fi.Exists)
                _fi = fi;
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

        private void EditFileArea(FileInfo FI, int areaToEdit)
        {
            // split file into sub strings at the |
            // edit area according to array index, done. fappy hays
            // need to get the shit out of fi and turn into sub strings, then, depending on area to edit
            // change that substring

        }

    }
}
