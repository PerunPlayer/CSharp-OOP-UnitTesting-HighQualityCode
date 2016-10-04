namespace SchoolClasses.People
{
    using System;

    public class Person : ICommentable
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (firstName.Length <= 1)
                {
                    throw new ArgumentException("There is not names smallest than 2 letters!");
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
            set
            {
                if (lastName.Length <= 1)
                {
                    throw new ArgumentException("There is not names smallest than 2 letters!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }

        public string Comment { get; set; }
    }
}
