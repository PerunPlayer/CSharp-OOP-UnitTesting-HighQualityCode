using System.Linq;

using Dealership.Contracts.Engine;
using Dealership.Contracts.Handlers;

namespace Dealership.Handlers.CommandHandlers
{
    public class RemoveCommentCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "RemoveComment";
        private const string CommentRemovedSuccessfully = "{0} removed comment successfully!";
        private const string RemovedCommentDoesNotExist = "Cannot remove comment! The comment does not exist!";
        
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
            var vehicleIndex = int.Parse(command.Parameters[0]) - 1;
            var commentIndex = int.Parse(command.Parameters[1]) - 1;
            var username = command.Parameters[2];
            var user = engine.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return string.Format(CommandHandler.NoSuchUser, username);
            }

            CommandHandler.ValidateRange(vehicleIndex, 0, user.Vehicles.Count, CommandHandler.RemovedVehicleDoesNotExist);
            CommandHandler.ValidateRange(commentIndex, 0, user.Vehicles[vehicleIndex].Comments.Count, RemovedCommentDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];
            var comment = user.Vehicles[vehicleIndex].Comments[commentIndex];

            engine.LoggedUser.RemoveComment(comment, vehicle);
            return string.Format(CommentRemovedSuccessfully, engine.LoggedUser.Username);
        }
    }
}