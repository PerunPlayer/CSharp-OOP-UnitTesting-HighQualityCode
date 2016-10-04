namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("cwakakakak");
        }
    }
}