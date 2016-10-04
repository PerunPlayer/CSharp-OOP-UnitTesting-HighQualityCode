namespace Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            var result = (Height * Width) / 2;
            return result;
        }
    }
}
