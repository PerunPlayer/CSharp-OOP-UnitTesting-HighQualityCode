namespace Dealership.Contracts.Vehicles
{
    public interface ITruck : IVehicle
    {
        int WeightCapacity { get; }
    }
}
