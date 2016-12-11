using Dealership.Contracts.Factories;

namespace Dealership.Contracts.Engine
{
    public interface IEngine
    {
        void Start();

        void Reset(IDealershipFactory factory);
    }
}
