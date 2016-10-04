namespace Cooking.Contracts
{
    public interface IVegetable
    {
        bool IsRotten { get; }

        bool IsPeeled { get; set; }

        bool IsCut { get; set; }

        bool IsCooked { get; set; }
    }
}
