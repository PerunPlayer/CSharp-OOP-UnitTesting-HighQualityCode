namespace VisitingCell
{
    class StartUp
    {
        public void Main()
        {
            var chef = new Chef();
            var potato = new Potato();

            chef.CheckIfPotatoIsReadyForCooking(potato);

            var cellVisitor = new VisitCells();

            cellVisitor.VisitCell();
        }
    }
}
