using System;
using System.IO;
using CustomerRegisterApp.Customer;

namespace CustomerRegisterApp.CLI.Commands
{
    public class Edit : ICommand
    {
        private FileInfo _fi;
        private int _areaToEdit;
        private bool _fileExists;

        public string CommandName { get; } = "edit";

        public void RunCommand()
        {
            Console.WriteLine("Enter the customer ID of the customer you would like to edit: (e.g., 2)");
            _fileExists = GetFileToEdit(Console.ReadLine());

            if (_fileExists)
            {
                Console.WriteLine("Please enter area you would like edit in the file:");
                Console.WriteLine("First name: 'first name', second name: 'second name', Mobile: 'tel' or Date of birth: 'dob'");
                _areaToEdit = GetAreaToEdit();

                if (_areaToEdit >= 1 && _areaToEdit <= 4)
                {
                    string newInput = GetNewInputForArea(_areaToEdit);
                    UpdateFile(_fi, _areaToEdit, newInput);
                }
            }
        }
        private bool GetFileToEdit(string ID)
        {
            FileInfo fi = new FileInfo(Path.GetFullPath($@"Customers\Customer{ID}.txt"));
            if (fi.Exists)
            {
                _fi = fi;
                return true;
            }
            Console.WriteLine($"Cannot find customer {ID}");
            return false;
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

        private string GetNewInputForArea(int areaToEdit)
        {
            switch (areaToEdit)
            {
                case 1:
                case 2:
                    return CustomerBuilder.GetValidCustomerName();
                case 3:
                    return CustomerBuilder.GetValidCustomerTelNum();
                case 4:
                    return CustomerBuilder.GetValidDOB().ToString();
            }
            return "";
        }

        private void UpdateFile(FileInfo FI, int areaToEdit, string updatedText)
        {
            // split file into sub strings at the |
            // edit area according to array index, done. fappy hays
            // need to get the shit out of fi and turn into sub strings, then, depending on area to edit
            // change that substring

        }

    }
}
