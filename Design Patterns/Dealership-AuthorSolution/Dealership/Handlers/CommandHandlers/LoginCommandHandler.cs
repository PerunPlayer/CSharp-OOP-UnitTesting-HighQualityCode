using System.Linq;

using Dealership.Contracts.Engine;
using Dealership.Contracts.Handlers;

namespace Dealership.Handlers.CommandHandlers
{
    public class LoginCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "Login";
        private const string UserLoggedIn = "User {0} successfully logged in!";
        private const string WrongUsernameOrPassword = "Wrong username or password!";
        
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
            var password = command.Parameters[1];

            if (engine.LoggedUser != null)
            {
                return string.Format(CommandHandler.UserLoggedInAlready, engine.LoggedUser.Username);
            }

            var userFound = engine.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (userFound != null && userFound.Password == password)
            {
                engine.LoggedUser = userFound;
                return string.Format(UserLoggedIn, username);
            }
            else
            {
                return WrongUsernameOrPassword;
            }
        }
    }
}
