using System;
using CohesionAndCoupling.Contracts;

namespace CohesionAndCoupling.Models
{
    public class Figure : I2DFigure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be negative number or zero!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be negative number or zero!");
                }

                this.height = value;
            }
        }
    }
}
