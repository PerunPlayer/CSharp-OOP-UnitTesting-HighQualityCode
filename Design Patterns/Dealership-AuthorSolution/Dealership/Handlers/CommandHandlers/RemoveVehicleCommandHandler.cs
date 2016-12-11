using Dealership.Contracts.Engine;

namespace Dealership.Handlers.CommandHandlers
{
    public class RemoveVehicleCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "RemoveVehicle";
        private const string VehicleRemovedSuccessfully = "{0} removed vehicle successfully!";
        
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
            CommandHandler.ValidateRange(vehicleIndex, 0, engine.LoggedUser.Vehicles.Count, CommandHandler.RemovedVehicleDoesNotExist);

            var vehicle = engine.LoggedUser.Vehicles[vehicleIndex];

            engine.LoggedUser.RemoveVehicle(vehicle);
            return string.Format(VehicleRemovedSuccessfully, engine.LoggedUser.Username);
        }
    }
}