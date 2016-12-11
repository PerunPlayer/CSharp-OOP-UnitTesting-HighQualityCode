using Dealership.Config;
using Dealership.Contracts.Engine;

using Ninject;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(new EngineModuleBinding());

            var engine = kernel.Get<IEngine>();
            engine.Start();
        }
    }
}
