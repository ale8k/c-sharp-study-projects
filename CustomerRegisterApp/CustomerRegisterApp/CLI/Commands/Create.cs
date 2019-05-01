/*
 * A command of the CLI for creating new customer files
 */

namespace CustomerRegisterApp.CLI.Commands
{
    public class Create : ICommand
    {
        public string CommandName { get; } = "create";
    }
}
