using System.Linq;

using Dealership.Contracts.Engine;

namespace Dealership.Handlers.CommandHandlers
{
    public class ShowVehiclesCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "ShowVehicles";

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
            var username = command.Parameters[0];
            var user = engine.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                return string.Format(CommandHandler.NoSuchUser, username);
            }

            return user.PrintVehicles();
        }
    }
}