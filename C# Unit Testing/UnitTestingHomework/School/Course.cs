namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
            private IList<Student> students;

            public Course()
            {
                this.students = new List<Student>();
            }

            public void StudentJoins(Student student)
            {
                if (this.students.Count == 30)
                {
                    throw new ArgumentException("Students in a course should be less than 30.");
                }
                this.students.Add(student);
            }

            public bool StudentLeaves(Student student)
            {
                if (this.students.Count == 0)
                {
                    throw new ArgumentException("There are no students in this course.");
                }
                return this.students.Remove(student);
            }

            public int Count
            {
                get
                {
                    return this.students.Count;
                }
            }
        }
}
