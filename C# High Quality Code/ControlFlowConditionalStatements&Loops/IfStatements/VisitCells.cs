namespace VisitingCell
{
    using System;
    
    public class VisitCells
    {
        private const int MinXValue = -100;
        private const int MaxXValue = 100;
        private const int MinYValue = -100;
        private const int MaxYValue = 100;

        public void VisitCell()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var isXInRange = MinXValue <= x && x <= MaxXValue;
            var isYInRange = MinYValue <= y && y <= MaxYValue;
            bool shouldVisitCell = true;

            if (isXInRange && isYInRange && shouldVisitCell)
            {
                Visit();
            }
            else
            {
                Console.WriteLine("Cell not visited!");
            }
        }

        private void Visit()
        {
            Console.WriteLine("The cell is visited!");
        }
    }
}
