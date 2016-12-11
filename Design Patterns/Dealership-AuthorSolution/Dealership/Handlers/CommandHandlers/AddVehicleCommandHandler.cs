﻿using System;

using Dealership.Common.Enums;
using Dealership.Contracts.Engine;
using Dealership.Contracts.Vehicles;

namespace Dealership.Handlers.CommandHandlers
{
    public class AddVehicleCommandHandler : CommandHandler
    {
        private const string RequiredCommandName = "AddVehicle";
        private const string VehicleAddedSuccessfully = "{0} added vehicle successfully!";
        
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
            var type = command.Parameters[0];
            var make = command.Parameters[1];
            var model = command.Parameters[2];
            var price = decimal.Parse(command.Parameters[3]);
            var additionalParam = command.Parameters[4];

            var typeEnum = (VehicleType)Enum.Parse(typeof(VehicleType), type, true);
            IVehicle vehicle = null;

            if (typeEnum == VehicleType.Car)
            {
                vehicle = engine.Factory.CreateCar(make, model, price, int.Parse(additionalParam));
            }
            else if (typeEnum == VehicleType.Motorcycle)
            {
                vehicle = engine.Factory.CreateMotorcycle(make, model, price, additionalParam);
            }
            else if (typeEnum == VehicleType.Truck)
            {
                vehicle = engine.Factory.CreateTruck(make, model, price, int.Parse(additionalParam));
            }

            engine.LoggedUser.AddVehicle(vehicle);
            return string.Format(VehicleAddedSuccessfully, engine.LoggedUser.Username);
        }
    }
}