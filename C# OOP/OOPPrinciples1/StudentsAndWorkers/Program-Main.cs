namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program_Main
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 5.20),
                new Student("Pesho", "Peshev", 4.25),
                new Student("Mara", "Krumova", 6.00),
                new Student("Kolyo", "Kolev", 5.50),
                new Student("Sasho", "Alexandrov", 2.99),
            };

            students = students
                .OrderBy(x => x.Grade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Yoan", "Petrov", 150, 8),
                new Worker("Stancho", "Stoilov", 165, 8),
                new Worker("Milen", "Milkov", 180, 8),
                new Worker("Koceto", "Kocev", 140, 8),
            };

            workers = workers
                .OrderByDescending(x => x.MoneyPerHour())
                .ToList();

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            var studentsAndWorkers = new List<Human>();

            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            studentsAndWorkers = studentsAndWorkers
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            foreach (var human in studentsAndWorkers)
            {
                Console.WriteLine(human);
            }
        }
    }
}