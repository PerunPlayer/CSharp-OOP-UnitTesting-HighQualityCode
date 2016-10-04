namespace Cooking.Models.Comsumables
{
    using System.Collections.Generic;

    using Contracts;

    public class Bowl : IContainable
    {
        private List<IVegetable> bowlContent;

        public Bowl()
        {
            this.bowlContent = new List<IVegetable>();
        }

        public IList<IVegetable> Contents
        {
            get
            {
                return this.bowlContent;
            }
        }

        public void Add(IVegetable vegetable)
        {
            this.bowlContent.Add(vegetable);
        }
    }
}
