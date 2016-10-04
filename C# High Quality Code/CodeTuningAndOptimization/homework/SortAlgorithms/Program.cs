using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithms;

namespace SortAlgorithms
{
    public class Program
    {
        public static void Main()
        {
            StringSorting();
            IntSorting();
            DoubleSorting();
        }
        private const long ExecutionTimes = 100000;

        public static void MeasureTime(string sortingType, Action sortingMethod)
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < ExecutionTimes; i++)
            {
                sortingMethod();
            }

            Console.WriteLine($"{sortingType} execution time -> {sw.Elapsed.ToString()}");
        }
        private static void StringSorting()
        {
            string[] arrayToSort = new string[] 
            { "hehe", "wow", "isurual", "whatIf", "isRael", "isnt", "rael", "huh", "whaddaboutdat", "tahtsIT", "noMoreStrings" };

            Console.WriteLine("String array sorting");

            MeasureTime("Insertion sort", () =>
            {
                InsertionSort(arrayToSort);
            });

            TimeTracker.MeasureTime("Selection sort", () =>
            {
                SortingAlgorithms.SelectionSort(arrayToSort);
            });

            TimeTracker.MeasureTime("Quick sort", () =>
            {
                SortingAlgorithms.QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
            });
        }

        private static void IntSorting()
        {
            GenerateArray(213, 8743267);

            Console.WriteLine("Int array sorting");

            TimeTracker.MeasureTime("Insertion sort", () =>
            {
                SortingAlgorithms.InsertionSort(arrayToSort);
            });

            TimeTracker.MeasureTime("Selection sort", () =>
            {
                SortingAlgorithms.SelectionSort(arrayToSort);
            });

            TimeTracker.MeasureTime("Quick sort", () =>
            {
                SortingAlgorithms.QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
            });
        }

        private static void DoubleSorting()
        {
            var array = GenerateArray(132, 783245238)
                .Select(x => (double)(x + 1.01))
                .ToArray();

            Console.WriteLine("Double array sorting");

            TimeTracker.MeasureTime("Insertion sort", () =>
            {
                SortingAlgorithms.InsertionSort(arrayToSort);
            });

            TimeTracker.MeasureTime("Selection sort", () =>
            {
                SortingAlgorithms.SelectionSort(arrayToSort);
            });

            TimeTracker.MeasureTime("Quick sort", () =>
            {
                SortingAlgorithms.QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
            });
        }

        public static int[] GenerateArray(int minValue, int maxValue)
        {
            Random randNum = new Random();
            int[] randomArray = Enumerable
                .Repeat(0, 100)
                .Select(i => randNum.Next(minValue, maxValue))
                .ToArray();

            return randomArray;
        }
    }
}
