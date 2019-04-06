using System;

namespace XsAndOs.CLI
{
    public class CLIInstance
    {
        // All fields contain command references
        // command refs are their own classes
        private Help _help = new Help();

        public CLIInstance()
        {
            Console.WriteLine("CLI instance successfully created");
        }
        /*
         * Our 'ui' of sorts... Lol 
         */
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
