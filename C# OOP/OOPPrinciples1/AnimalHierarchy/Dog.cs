namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("bau");
        }
    }
}