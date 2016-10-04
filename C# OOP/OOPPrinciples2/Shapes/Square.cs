﻿namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double width) : base(width, width)
        {

        }

        public override double CalculateSurface()
        {
            var result = Width * Width;
            return result;
        }
    }
}
