namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("murrr");
        }
    }
}