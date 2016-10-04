namespace SixtyfourBitArray
{
    using System;

    class Program
    {
        static void Main()
        {
            BitArray first = new BitArray(24655426);
            BitArray second = new BitArray(245624566);
            BitArray third = new BitArray(8767);

            Console.WriteLine(string.Format("Hash code: {0}", first.GetHashCode()));
            Console.WriteLine("--------------");

            Console.WriteLine(string.Format("\nAre first and second arrays equals? {0}", first.Equals(second)));
            Console.WriteLine("--------------");

            Console.WriteLine(string.Format("\nSecond index of array: ", first[2]));
            Console.WriteLine("--------------");

            Console.WriteLine("\nAre first and second array different?");
            Console.WriteLine(first != second);
            Console.WriteLine("--------------");

            Console.WriteLine("\nAre first and second array equals?");
            Console.WriteLine(first == third);
        }
    }
}
