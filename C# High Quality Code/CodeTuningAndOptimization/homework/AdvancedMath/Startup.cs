using System;
using System.Diagnostics;

namespace AdvancedMath
{
    class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Operations with Float");
            float resultFloat = 0.0f;
            ExecuteMathTests(resultFloat);
            Console.WriteLine();

            Console.WriteLine("Operations with Double");
            double resultDouble = 0.0;
            ExecuteMathTests(resultDouble);
            Console.WriteLine();

            Console.WriteLine("Operations with Decimal");
            decimal resultDecimal = 0.0m;
            ExecuteMathTests(resultDecimal);
        }

        private static void DisplayExecutionTime(Action action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static void ExecuteMathTests(dynamic a)
        {
            const int LoopCount = 10000000;
            a = a + 1;

            Console.Write("Square Root: ");
            DisplayExecutionTime(() =>
            {
                for (var i = 0; i < LoopCount; i++)
                {
                    Math.Sqrt((double)a);
                }
            });

            Console.Write("Natural logarithm: ");
            DisplayExecutionTime(() =>
            {
                for (var i = 0; i < LoopCount; i++)
                {
                    Math.Log((double)a);
                }
            });

            Console.Write("Sinus: ");
            DisplayExecutionTime(() =>
            {
                for (var i = 0; i < LoopCount; i++)
                {
                    Math.Sin((double)a);
                }
            });
        }
    }
}
