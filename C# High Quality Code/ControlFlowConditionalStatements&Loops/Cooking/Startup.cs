namespace Cooking
{
    using Models.Staff;

    public class Startup
    {
        public static void Main()
        {
            var chef = new Chef("Andre Tokev");
            chef.Cook();
        }
    }
}
