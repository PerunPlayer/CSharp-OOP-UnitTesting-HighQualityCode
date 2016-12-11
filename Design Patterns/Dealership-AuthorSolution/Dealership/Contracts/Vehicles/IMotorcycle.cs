namespace Dealership.Contracts.Vehicles
{
    public interface IMotorcycle : IVehicle
    {
        string Category { get; }
    }
}
