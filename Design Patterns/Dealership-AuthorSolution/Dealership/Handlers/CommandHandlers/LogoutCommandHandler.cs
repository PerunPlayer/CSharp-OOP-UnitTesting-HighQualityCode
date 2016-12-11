using Dealership.Contracts.Engine;
using Dealership.Contracts.Handlers;

namespace Dealership.Handlers.CommandHandlers
{
    public class LogoutCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "Logout";
        private const string UserLoggedOut = "You logged out!";
        
        protected override bool CanHandleCommand(ICommand command)
        {
            if (command.Name == RequiredCommandName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override string ProcessCommand(ICommand command, IDealershipEngine engine)
        {
            engine.LoggedUser = null;
            return UserLoggedOut;
        }
    }
}