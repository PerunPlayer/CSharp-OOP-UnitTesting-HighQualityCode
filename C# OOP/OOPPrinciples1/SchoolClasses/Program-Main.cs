using SchoolClasses.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Program_Main
    {
        public static void Main()
        {
            Student Rumyana = new Student("Rumyana", "Grigorova", 16);
            Rumyana.Comment = "good student";
            Console.WriteLine("Students:");
            Console.WriteLine("{0} {2} is {1}.", Rumyana, Rumyana.Comment, Rumyana.FirstName);

            Teacher Anelia = new Teacher("Anelia", "Dimentieva");
            Anelia.Comment = "just a teacher";
            Console.WriteLine("\nTeachers:");
            Console.WriteLine("{0} {1} is {2}", Anelia, Anelia.LastName, Anelia.Comment);

            Teacher Viktor = new Teacher("Viktor", "Krum");
            Viktor.Comment = "just a teacher";
            Console.WriteLine("\nTeachers:");
            Console.WriteLine("{0} {1} is {2}", Viktor, Viktor.LastName, Viktor.Comment);
        }
    }
}
