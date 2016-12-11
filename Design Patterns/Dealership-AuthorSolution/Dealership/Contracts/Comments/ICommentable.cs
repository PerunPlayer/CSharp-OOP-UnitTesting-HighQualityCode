using System.Collections.Generic;

namespace Dealership.Contracts.Comments
{
    public interface ICommentable
    {
        IList<IComment> Comments { get; }
    }
}
