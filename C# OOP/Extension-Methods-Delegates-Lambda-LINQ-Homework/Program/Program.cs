namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------Problem 1.StringBuilder.Substring---------------\n");

            Console.WriteLine("Nqkakav tekst, deto ne mu znam spatiite.");
            StringBuilder sub = new StringBuilder();
            sub.Append("Nqkakav tekst, deto ne mu znam spatiite.");
            var substring = sub.Sub(15, 25);

            Console.WriteLine(substring);

            Console.WriteLine("\n----------------Problem 2.IEnumerable extensions----------------\n");


            decimal[] arr = new decimal[] { 1m, 3m, 5m, 8m, 69.69m, 88m };
            Console.WriteLine("The sum of the array is: " + arr.MySum());
            Console.WriteLine("The product of the array is: " + arr.MyProduct());
            Console.WriteLine("The min in the array is: " + arr.MyMin());
            Console.WriteLine("The max in the array is: " + arr.MyMax());
            Console.WriteLine("The average of the array is: " + arr.MyAverage());

            // Problem 3 --->

            List<byte> marks1 = new List<byte>() { 5, 4, 5 };
            List<byte> marks2 = new List<byte>() { 5, 3, 4 };
            List<byte> marks3 = new List<byte>() { 6, 6, 5 };

            List<Student> Students = new List<Student>()
            {
                new Student("Zlatan", "Ibrahimovic", 34, "0899433584", "IZlatanIbra@gmail.com", marks1, "107205", "1"),
                new Student("Bastian", "Schweinsteiger", 31, "0543954312", "IchLiebeAmMeistenFußball@gmail.com", marks2, "107205", "1"),
                new Student("Manuel", "Neuer", 30, "8765345312", "NeuerIstYashin@gmail.com", marks3, "107206", "2"),
                new Student("Julian", "Draxler", 23, "0234774545", "NieTorschützer@gmail.com", marks3, "107207", "3")
            };

            var sortedNames = Students.Where((f) => f.FirstName.CompareTo(f.LastName) == -1)
                                          .ToList();

            Console.WriteLine("\nFirst before last");

            foreach (var student in sortedNames)
            {
                Console.WriteLine("-> " + student.FullName);
            }

            Console.WriteLine();

            // Problem 4 --->

            var sortedAge = Students.Where(s => s.Age >= 18 && s.Age <= 24)
                                           .Select(s => s.FullName)
                                           .ToList();

            Console.WriteLine("Between 18 - 24");

            foreach (var student in sortedAge)
            {
                Console.WriteLine("-> " + student);
            }

            Console.WriteLine();

            // Problem 5

            var sortedByName = Students.OrderBy(s => s.FirstName)
                                           .ThenBy(s => s.LastName)
                                           .ToList();

            var orderedByName = from student in Students
                                orderby student.FirstName, student.LastName
                                select student;

            Console.WriteLine("--------------Sorted by first and last name--------------");

            foreach (var student in sortedByName)
            {
                Console.WriteLine("-> " + student.FullName);
            }

            Console.WriteLine();

            // Problem 6

            Console.WriteLine("-------------------Problem 6------------------");

            int[] arr6 = new int[] { 1, 3, 6, 7, 15, 21, 42, 126 };
            arr6.PrintDivisible();

            var array1 = arr
                .Where(x => x % 3 == 0 &&
                            x % 7 == 0)
                .ToList();

            foreach (var number in array1)
            {
                Console.WriteLine(number);
            }

            // Timer - Problem 7
            // The code is here  
            //       |
            //       |
            //       |
            //      \ /
            // Timer.SetInterval(new Action(() => Timer.CurrentDate()), 1);
            Console.WriteLine("You may be missed the timer? Search me in the code!");


        }
    }
}
