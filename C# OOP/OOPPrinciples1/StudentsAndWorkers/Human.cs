namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
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
                if (firstName.Length < 2)
                {
                    throw new ArgumentException("There is no names under 2 letters!");
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
                if (lastName.Length < 2)
                {
                    throw new ArgumentException("There is no names under 2 letters!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}
