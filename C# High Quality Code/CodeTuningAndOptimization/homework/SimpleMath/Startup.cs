using System;
using System.Numerics;
using System.Diagnostics;

namespace SimpleMath
{
    class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Operations with Integer");
            int resultInt = 0;
            ExecuteMathTests(resultInt);
            Console.WriteLine();

            Console.WriteLine("Operations with Long");
            long resultLong = 0;
            ExecuteMathTests(resultLong);
            Console.WriteLine();

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
            Console.WriteLine();

            Console.WriteLine("Bonus: Operations with BigInteger");
            BigInteger resultBigInt = 0;
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

            Console.Write("Addition: ");
            DisplayExecutionTime(() =>
            {
                a = a + 0;
                for (var i = 0; i < LoopCount; i++)
                {
                    a = a + 1;
                }
            });

            Console.Write("Subtraction: ");
            DisplayExecutionTime(() =>
            {
                a = a + 10000000;
                for (var i = 0; i < LoopCount; i++)
                {
                    a = a - 1;
                }
            });

            Console.Write("Increment: ");
            DisplayExecutionTime(() =>
            {
                a = a + 0;
                for (var i = 0; i < LoopCount; i++)
                {
                    a++;
                }
            });

            Console.Write("Multiplication: ");
            DisplayExecutionTime(() =>
            {
                a = a + 1;
                for (var i = 0; i < LoopCount; i++)
                {
                    a = a * 1;
                }
            });

            Console.Write("Divide: ");
            DisplayExecutionTime(() =>
            {
                a = a + 1;
                for (var i = 0; i < LoopCount; i++)
                {
                    a = a / 1;
                }
            });
        }
    }
}
