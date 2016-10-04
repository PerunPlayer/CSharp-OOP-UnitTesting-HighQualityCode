using StudentClass.Enums;
using System;

namespace StudentClass
{

    class Program
    {
        static void Main()
        {
            Student first = new Student("Petar", "Rashov", "Todorov", 0011, "bul. Alexander Malinov 32", "0898674523", "peshkata@abv.bg", "IT", Specialities.ElektronicSystems, Universities.Cambridge, Faculties.Engeneering);
            Student second = new Student("Mitraki", "Desov", "Asenov", 0001, "bul. Vitosha 15", "0887462430", "donMitone@gmail.com", "Robotics", Specialities.RoboSoftware, Universities.MIT, Faculties.Robotics);

            var equalStudents = first == second;
            var hashCode = first.GetHashCode();

            Console.WriteLine("\nFirst and second student are equal? -> {0}", equalStudents);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Hash code of first student -> " + hashCode);
            Console.WriteLine("------------------------------");

            Console.WriteLine(first);
            Console.WriteLine("------------------------------");

            var firstStudentCloning = first.Clone() as Student;
            firstStudentCloning.Faculty = Faculties.Sports;
            Console.WriteLine(firstStudentCloning);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Comparisson -> " + first.CompareTo(second) + Environment.NewLine);
            Console.WriteLine("------------------------------");

            // Person

            Console.WriteLine("---------------Person----------------");

            var Basti = new Person("Bastian Schweinsteiger", 33);
            Console.WriteLine(Basti);

            var Mani = new Person("Manuel Neuer", 32);
            Console.WriteLine(Mani);

            var JLo = new Person("Jeniffer Lopez");
            Console.WriteLine(JLo);
        }
    }
}
