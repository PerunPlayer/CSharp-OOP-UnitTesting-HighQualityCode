using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Homework
{
    class Operations
    {
        public static bool IsPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static T[] GetSubsequence<T>(T[] array, int startIndex, int count)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array cannot be null!");
            }

            if (count < 0 || count > array.Length)
            {
                throw new ArgumentException("Count cannot be negative or greater than the array length number!");
            }

            if (startIndex < 0 || startIndex >= array.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex");
            }

            var endIndex = startIndex + count;
            if (endIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException("endIndex");
            }

            List<T> resultSequence = new List<T>();
            for (int i = startIndex; i < endIndex; i++)
            {
                resultSequence.Add(array[i]);
            }

            return resultSequence.ToArray();
        }

        public static string ExtractEnding(string initialString, int count)
        {
            if (count > initialString.Length)
            {
                throw new ArgumentException("Count cannot be greater than the string length!");
            }

            StringBuilder result = new StringBuilder();
            var startIndex = initialString.Length - count;

            for (int i = startIndex; i < initialString.Length; i++)
            {
                result.Append(initialString[i]);
            }

            return result.ToString();
        }
    }
}
