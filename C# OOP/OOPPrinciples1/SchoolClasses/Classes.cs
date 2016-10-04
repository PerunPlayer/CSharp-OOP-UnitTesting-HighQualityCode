namespace SchoolClasses
{
    using System.Collections.Generic;
    using People;
    using System;

    public class Classes : ICommentable
    {
        private string identifier;
        private List<Teacher> teachers;
        private List<Student> students;

        public Classes(Teacher[] teachers, params Student[] students)
        {
            this.Identifier = identifier;
            this.teachers = new List<Teacher>();
            this.teachers.AddRange(teachers);
            this.students = new List<Student>();
            this.students.AddRange(students);
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                if (string.IsNullOrEmpty(identifier))
                {
                    throw new ArgumentNullException("Class identifier must contain something!");
                }
                else
                {
                    this.identifier = value;
                }
            }
        }

        public string Comment { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public override string ToString()
        {
            return string.Format("Class {0}\nTeachers:\n{1}\nStudents:\n{2}", this.identifier, string.Join("\n", this.Teachers), string.Join("\n", this.students));
        }
    }
}