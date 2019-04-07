using System;
using System.Text;

namespace XsAndOs.CLI
{
    public class Help
    {
        private StringBuilder sb = new StringBuilder();

        public void Command()
        {
            sb.Append("The commands for x's and o's are:")
                .AppendLine()
                .AppendLine()
                .Append("- Help: gives a list of all available commands in the game.")
                .AppendLine()
                .Append("- Start: starts an instance of the game.")
                .AppendLine()
                .Append("- Close: closes the game.");
            Console.WriteLine(sb);
            sb.Clear();
        }
    }
}
