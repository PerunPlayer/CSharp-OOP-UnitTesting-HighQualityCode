namespace People
{
    public class Human
    {
        public GenderType Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static Human HumanFactory(int id)
        {
            var human = new Human();

            human.Age = id;

            if (human.Age % 2 == 0)
            {
                human.Name = "Nice Guy";
                human.Gender = GenderType.Male;
            }
            else
            {
                human.Name = "Party Girl";
                human.Gender = GenderType.Female;
            }

            return human;
        }
    }
}
