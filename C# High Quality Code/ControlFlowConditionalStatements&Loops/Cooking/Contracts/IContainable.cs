namespace Cooking.Contracts
{
    using System.Collections.Generic;

    interface IContainable
    {
        IList<IVegetable> Contents { get; }
    }
}
