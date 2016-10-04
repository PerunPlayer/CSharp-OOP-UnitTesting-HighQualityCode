namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (grade < 1 || grade > 12)
                {
                    throw new ArgumentException("Grade must be between 1 and 12!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} is in grade {2}.", this.FirstName, this.LastName, this.grade);
        }
    }
}
