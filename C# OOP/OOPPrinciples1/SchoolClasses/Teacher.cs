namespace SchoolClasses.People
{
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private List<Disciplines> disciplines;

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            this.disciplines = new List<Disciplines>();
        }

        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
