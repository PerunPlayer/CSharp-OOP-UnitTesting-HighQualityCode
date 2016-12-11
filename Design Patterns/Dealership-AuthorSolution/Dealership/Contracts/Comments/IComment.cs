namespace Dealership.Contracts.Comments
{
    public interface IComment
    {
        string Content { get; }

        string Author { get; set; }
    }
}
