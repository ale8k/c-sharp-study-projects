using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomerRegisterApp.CLI.Commands
{
    public class View : ICommand
    {
        public string CommandName { get; } = "view";

        public void RunCommand()
        {
            // for colour idea, create hashcode based on file content then assign colour
            // to hashcode, store each hash code in dictionary with corresponding colours
            // done?
            string[] files = Directory.GetFiles("Customers");

            foreach (string file in files)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    // Git change
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }

    }
}
