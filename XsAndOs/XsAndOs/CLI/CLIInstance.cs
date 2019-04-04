using System;

namespace XsAndOs.CLI
{
    public class CLIInstance
    {
        private Help _help = new Help();

        public CLIInstance()
        {
            Console.WriteLine("CLI instance successfully created");
        }

        public void Commands(string usersInput)
        {
            string _usersInput = usersInput.ToLower();

            switch(_usersInput)
            {
                case "help":
                    _help.Command();
                    break;
                case "close":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
