using System.Linq;

using Dealership.Contracts.Engine;
using Dealership.Contracts.Handlers;

namespace Dealership.Handlers.CommandHandlers
{
    public class AddCommentCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "AddComment";
        private const string VehicleDoesNotExist = "The vehicle does not exist!";
        private const string CommentAddedSuccessfully = "{0} added comment successfully!";
        
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
            var content = command.Parameters[0];
            var author = command.Parameters[1];
            int vehicleIndex = int.Parse(command.Parameters[2]) - 1;

            var comment = engine.Factory.CreateComment(content);
            comment.Author = engine.LoggedUser.Username;
            var user = engine.Users.FirstOrDefault(u => u.Username == author);

            if (user == null)
            {
                return string.Format(CommandHandler.NoSuchUser, author);
            }

            CommandHandler.ValidateRange(vehicleIndex, 0, user.Vehicles.Count, VehicleDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];

            engine.LoggedUser.AddComment(comment, vehicle);

            return string.Format(CommentAddedSuccessfully, engine.LoggedUser.Username);
        }
    }
}