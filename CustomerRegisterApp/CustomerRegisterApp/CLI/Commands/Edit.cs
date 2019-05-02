using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegisterApp.CLI.Commands
{
    public class Edit : ICommand
    {
        public string CommandName { get; } = "edit";

        public void RunCommand()
        {
            Console.WriteLine("Please enter area you would like edit in the file:");
            Console.WriteLine("First name: 'first name', second name: 'second name', Mobile: 'tel' or Date of birth: 'dob'");
            int area = GetAreaToEdit();
            Console.WriteLine(area);
            // select file to edit
            // select firstname, secondname, w/e to update
            // update it
            // save
            // display it - done
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
