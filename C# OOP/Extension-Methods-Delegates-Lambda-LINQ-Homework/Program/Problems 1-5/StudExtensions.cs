namespace Program
{
    using System.Collections.Generic;
    using System.Linq;

    public static class StudExtensions
    {
        public static List<Student> ExtractAndOrder(this List<Student> collection)
        {
            var group = from student in collection
                        where student.GroupNumber == "1"
                        select student;

            return new List<Student>(group);
        }

        public static bool Contains(this List<byte> collection, int element, int times)
        {
            bool contain = false;
            int counter = 0;

            foreach (var item in collection)
            {
                if (item == element)
                {
                    counter++;
                }

                if (counter == times)
                {
                    contain = true;
                    break;
                }
            }

            return contain;
        }
    }
}
