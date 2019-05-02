/*
 * A command of the CLI for deleting customer files
 */

namespace CustomerRegisterApp.CLI.Commands
{
    public class Delete : ICommand
    {
        private FileManager _fm;
        public string CommandName { get; } = "delete";

        public Delete(FileManager FM)
        {
            _fm = FM;
        }
        public void RunCommand()
        {
            System.Console.Clear();
            System.Console.WriteLine("Running delete");
            System.Console.ReadLine();
        }
    }
}
