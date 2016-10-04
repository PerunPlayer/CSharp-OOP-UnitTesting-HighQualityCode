namespace DefineClass
{
    using System;

    class Display
    {
        public decimal size;
        public int colors;

        public Display(decimal size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }

        public decimal Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (size <= 0)
                {
                    throw new ArgumentException("The size is always positive number!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (colors <= 0)
                {
                    throw new ArgumentException("The colors are always positive number!");
                }
                else
                {
                    this.size = value;
                }
            }
        }
    }
}
