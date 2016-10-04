namespace People
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var id = int.Parse(Console.ReadLine());

            var human = Human.HumanFactory(id);
        }
    }
}
