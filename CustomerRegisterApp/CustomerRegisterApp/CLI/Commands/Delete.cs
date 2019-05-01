/*
 * A command of the CLI for deleting customer files
 */

namespace CustomerRegisterApp.CLI.Commands
{
    public class Delete : ICommand
    {
        public string CommandName { get; } = "delete";
    }
}
