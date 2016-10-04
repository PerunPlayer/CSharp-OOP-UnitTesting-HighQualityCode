using System;
using MethodStartup;
using MethodStartup.Utils;

namespace HighQualityMethods
{
    class MethodStartup
    {
        static void Main()
        {
            Console.WriteLine(Calculations.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Calculations.ConvertDigitToString(5));

            Console.WriteLine(Calculations.GetMaxValue(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(ConsoleWriter.FormatNumber(1.3, "f"));
            Console.WriteLine(ConsoleWriter.FormatNumber(0.75, "%"));
            Console.WriteLine(ConsoleWriter.FormatNumber(2.30, "r"));

            Console.WriteLine(Calculations.CalculateDistance(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");

            Student stella = new Student("Stella", "Markova", new DateTime(1993, 3, 11), "Vidin");

            Console.WriteLine("Is {0} older than {1}?\n{2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
