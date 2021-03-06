﻿namespace Dealership.Contracts.Vehicles
{
    using Comments;
    using Dealership.Common.Enums;

    public interface IVehicle : ICommentable, IPriceable
    {
        int Wheels { get; }

        VehicleType Type { get; }

        string Make { get; }

        string Model { get;  }
    }
}
