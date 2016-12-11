namespace Dealership.Contracts.Vehicles
{
    public interface ICar : IVehicle
    {
        int Seats { get; }
    }
}
