namespace SchoolClasses
{
    using System;

    public class Disciplines
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Disciplines(string name, int numberOfLectures, int numberOfExercises)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Discipline should have name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get
            { return this.numberOfLectures; }
            set
            {
                if (numberOfLectures < 0)
                {
                    throw new ArgumentOutOfRangeException("Discipline could have positive number of lectures!");
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (numberOfExercises < 0)
                {
                    throw new ArgumentOutOfRangeException("Discipline could have positive number of exercises!");
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
        }
    }
}
