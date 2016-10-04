namespace LoopRefactoring
{
    using System;

    public class Startup
    {
        private const int MagicGivenNumber = 100;
        private const int ExpectedValue = 666;

        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            for (int i = 0; i < MagicGivenNumber; i++)
            {
                if (i % 10 == 0 && array[i] == ExpectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
