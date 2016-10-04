namespace Shapes
{
    using System;

    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5.5, 10),
                new Square(3.5),
                new Triangle(5.5, 10),
                new Rectangle(2,1),
                new Square(2.3),
                new Triangle(2, 2)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("The surface of the {0} is {1} square meters.", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
