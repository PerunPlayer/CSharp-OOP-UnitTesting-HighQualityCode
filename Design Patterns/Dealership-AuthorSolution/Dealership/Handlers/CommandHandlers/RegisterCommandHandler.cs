using System;
using System.Linq;

using Dealership.Common.Enums;
using Dealership.Contracts.Engine;

namespace Dealership.Handlers.CommandHandlers
{
    public class RegisterCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "RegisterUser";
        private const string UserAlreadyExist = "User {0} already exist. Choose a different username!";
        private const string UserRegisterеd = "User {0} registered successfully!";
        
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
            var firstName = command.Parameters[1];
            var lastName = command.Parameters[2];
            var password = command.Parameters[3];

            var role = Role.Normal;

            if (command.Parameters.Count > 4)
            {
                role = (Role)Enum.Parse(typeof(Role), command.Parameters[4]);
            }

            if (engine.LoggedUser != null)
            {
                return string.Format(CommandHandler.UserLoggedInAlready, engine.LoggedUser.Username);
            }

            if (engine.Users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return string.Format(UserAlreadyExist, username);
            }

            var user = engine.Factory.CreateUser(username, firstName, lastName, password, role.ToString());
            engine.LoggedUser = user;
            engine.Users.Add(user);

            return string.Format(UserRegisterеd, username);
        }
    }
}