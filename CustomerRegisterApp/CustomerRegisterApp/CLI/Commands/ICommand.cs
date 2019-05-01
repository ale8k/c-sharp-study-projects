/*
 * Represents all commands for polymorphic behaviour
 */

namespace CustomerRegisterApp.CLI.Commands
{
    public interface ICommand
    {
        string CommandName { get; }
    }
}
