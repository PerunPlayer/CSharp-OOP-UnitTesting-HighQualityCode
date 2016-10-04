namespace Cooking.Models.Vegetables
{
    using System;

    using Contracts;

    public class Vegetable : IVegetable
    {
        private bool isCut;
        private bool isPeeled;

        protected Vegetable() : this(false, false)
        {
        }

        protected Vegetable(bool isPeeled, bool isCut)
        {
            this.IsCut = isCut;
            this.IsPeeled = isPeeled;
        }

        public bool IsCooked
        {
            get
            {
                return this.IsCooked;
            }

            set
            {
                if (this.IsCooked)
                {
                    throw new ArgumentException("The vegetable has been cooked already!");
                }

                this.IsCooked = value;
            }
        }

        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                if (this.isCut && !value)
                {
                    throw new ArgumentException("The vegetable has been cut already!");
                }

                this.isCut = value;
            }
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                if (this.isPeeled && !value)
                {
                    throw new ArgumentException("The vegetable has been peeled already!");
                }

                this.isCut = value;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.IsRotten;
            }
        }
    }
}
