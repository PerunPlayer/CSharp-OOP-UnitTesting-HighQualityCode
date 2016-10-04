namespace Program
{
    using System;
    using System.Linq;

    static class Extension
    {
        public static void PrintDivisible(this int[] arr)
        {
            var toPrint = arr
                .Where(x => x % 3 == 0 &&
                            x % 7 == 0)
                .ToArray();

            foreach (var number in toPrint)
            {
                Console.WriteLine(number);
            }
        }
    }
}