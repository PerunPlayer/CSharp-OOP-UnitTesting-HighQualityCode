using System.Text;

using Dealership.Common.Enums;
using Dealership.Contracts.Engine;

namespace Dealership.Handlers.CommandHandlers
{
    public class ShowUsersCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "ShowUsers";
        private const string YouAreNotAnAdmin = "You are not an admin!";
        
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
            if (engine.LoggedUser.Role != Role.Admin)
            {
                return YouAreNotAnAdmin;
            }

            var builder = new StringBuilder();
            builder.AppendLine("--USERS--");
            var counter = 1;
            foreach (var user in engine.Users)
            {
                builder.AppendLine(string.Format("{0}. {1}", counter, user.ToString()));
                counter++;
            }

            return builder.ToString().Trim();
        }
    }
}