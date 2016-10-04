using System;

namespace MatrixWalk
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter size of the matrix!");
            int size = int.Parse(Console.ReadLine());

            var generator = new MatrixGenerator(size);
            Console.WriteLine(generator);
        }
    }
}
