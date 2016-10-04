using System;
using HighQualityClasses.Contracts;

namespace HighQualityClasses.Models
{
    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();

        public override string ToString()
        {
            var output = string.Format(
                "I am a {2}. My perimeter is {0:f2}. My surface is {1:f2}.",
                this.CalculatePerimeter(),
                this.CalculateSurface(),
                this.GetType().Name);

            return output;
        }
    }
}
