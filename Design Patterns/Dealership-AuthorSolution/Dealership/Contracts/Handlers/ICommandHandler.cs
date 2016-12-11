using Dealership.Contracts.Engine;

namespace Dealership.Contracts.Handlers
{
    public interface ICommandHandler
    {
        string HandleCommand(ICommand command, IDealershipEngine engine);
    }
}