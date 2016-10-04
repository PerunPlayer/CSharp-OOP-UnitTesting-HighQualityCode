namespace RangeExceptions
{
    using System;

    class Program
    {
        static void Main()
        {
            //int[] integers = new int[] { 2, 3, 5, 10, 1000, int.MaxValue };    with exception
            int[] integers = new int[] { 1, 2, 54, 32, 87, 45 };               //without exception

            foreach (var integer in integers)
            {
                Console.WriteLine(integer);
                if (integer < 1 || integer > 100)
                {
                    throw new InvalidRangeException<int>("Number is out of range!", 1, 100);
                }
            }
            Console.WriteLine("All integers are in range!\n");


            //DateTime dateTest = new DateTime(2014, 6, 30);                with exception
            DateTime dateTest = new DateTime(1998, 12, 4);                //without exception
            Console.WriteLine(dateTest);
            if (dateTest < new DateTime(1980, 1, 1) || dateTest > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("Date is out of range!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
            Console.WriteLine("Date is correct!");
        }
    }
}
