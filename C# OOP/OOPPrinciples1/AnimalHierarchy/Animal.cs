namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : IMeowable
    {
        private int age;
        private string name;

        public Animal(int age, string name, Gender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public Gender gender { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age could be positive number!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("There is not names under 2 letters!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
        public abstract void MakeSound();

        public override string ToString()
        {
            return string.Format("{0} is {1} and is {2} years old.", this.Name, this.gender, this.Age);
        }
    }
}
