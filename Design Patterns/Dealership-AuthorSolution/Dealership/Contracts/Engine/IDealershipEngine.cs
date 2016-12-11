using System.Collections.Generic;

using Dealership.Contracts.Factories;

namespace Dealership.Contracts.Engine
{
    public interface IDealershipEngine : IEngine
    {
        IUser LoggedUser { get; set; }

        ICollection<IUser> Users { get; }

        IDealershipFactory Factory { get;  }
    }
}