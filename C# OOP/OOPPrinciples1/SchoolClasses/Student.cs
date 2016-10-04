namespace SchoolClasses.People
{
    using System;

    public class Student : Person, ICommentable
    {
        private byte classNumber;

        public Student(string firstName, string lastName, byte classNumber) : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public byte ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (classNumber <= 0)
                {
                    throw new ArgumentOutOfRangeException("Class number could be positive number!");
                }
                else
                {
                    this.classNumber = value;
                }
            }
        }
    }
}
