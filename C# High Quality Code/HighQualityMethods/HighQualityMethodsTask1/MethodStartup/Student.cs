using System;

namespace MethodStartup
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string town;

        public Student(string firstName, string lastName, DateTime birthDate, string town)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Town = town;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Town name cannot be empty!");
                }
                else
                {
                    this.town = value;
                }
            }
        }

        public DateTime BirthDate { get; private set; }

        public bool IsOlderThan(Student otherStudent)
        {
            return this.BirthDate > otherStudent.BirthDate;
        }
    }
}
