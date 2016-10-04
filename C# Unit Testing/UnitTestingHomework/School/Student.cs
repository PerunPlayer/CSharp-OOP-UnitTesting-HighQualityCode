namespace School
{
    using System;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.ID = IdGenerator.GenerateId();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.name = value;
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.id = value;
            }
        }
    }
}
