namespace Program
{
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; }

        public string LastName { get; }

        public byte Age { get; }

        public string Phone { get; }

        public string Email { get; }

        public List<byte> Marks { get; }

        public string FN { get; }

        public string GroupNumber { get; }

        public Student(string firstName, string lastName, byte age, string phoneNumber,
                        string mail, List<byte> marks, string FN, string groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Phone = phoneNumber;
            this.Email = mail;
            this.Marks = marks;
            this.FN = FN;
            this.GroupNumber = groupNumber;
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            private set
            {
                FullName = FirstName + " " + LastName;
            }
        }
    }
}
