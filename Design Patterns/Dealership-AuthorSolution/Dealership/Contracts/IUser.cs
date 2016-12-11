using System.Collections.Generic;

using Dealership.Common.Enums;
using Dealership.Contracts.Comments;
using Dealership.Contracts.Vehicles;

namespace Dealership.Contracts
{
    public interface IUser
    {
        string Username { get; }

        string FirstName { get; }

        string LastName { get; }

        string Password { get; }

        Role Role { get; }

        IList<IVehicle> Vehicles { get; }

        void AddVehicle(IVehicle vehicle);

        void RemoveVehicle(IVehicle vehicle);

        void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment);

        void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment);

        string PrintVehicles();
    }
}
