using System;

using Dealership.Contracts.Engine;
using Dealership.Contracts.Handlers;

namespace Dealership.Handlers.CommandHandlers
{
    public abstract class CommandHandler : ICommandHandler
    {
        protected const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        protected const string RemovedVehicleDoesNotExist = "Cannot remove comment! The vehicle does not exist!";
        protected const string NoSuchUser = "There is no user with username {0}!";

        private const string InvalidCommand = "Invalid command!";
        private const string UserNotLogged = "You are not logged! Please login first!";
        
        protected ICommandHandler Successor { get; private set; }

        public void SetSuccessor(ICommandHandler successor)
        {
            this.Successor = successor;
        }

        public string HandleCommand(ICommand command, IDealershipEngine engine)
        {
            if (command.Name != "RegisterUser" && command.Name != "Login")
            {
                if (engine.LoggedUser == null)
                {
                    return UserNotLogged;
                }
            }

            if (this.CanHandleCommand(command))
            {
                return this.ProcessCommand(command, engine);
            }
            else if (this.Successor != null)
            {
                return this.Successor.HandleCommand(command, engine);
            }
            else
            {
                string errorMessage = string.Format(InvalidCommand, command.Name);
                return errorMessage;
            }
        }

        protected static void ValidateRange(int? value, int min, int max, string message)
        {
            if (value < min || value >= max)
            {
                throw new ArgumentException(message);
            }
        }

        protected abstract bool CanHandleCommand(ICommand command);

        protected abstract string ProcessCommand(ICommand command, IDealershipEngine engine);
    }
}