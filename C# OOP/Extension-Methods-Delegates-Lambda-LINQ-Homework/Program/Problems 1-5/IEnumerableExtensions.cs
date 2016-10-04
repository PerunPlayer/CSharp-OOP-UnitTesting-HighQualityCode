namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static decimal MySum<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            var decCollection = collection
                .Select(x => Convert.ToDecimal(x));

            decimal result = 0;

            foreach (var number in decCollection)
            {
                result += number;
            }

            return result;
        }

        public static decimal MyProduct<T>(this IEnumerable<T> collection)
            where T : IConvertible
        {
            var decCollection = collection
                .Select(x => Convert.ToDecimal(x));

            decimal result = 1;

            foreach (var number in decCollection)
            {
                result *= number;
            }
            return result;
        }

        public static decimal MyMin<T>(this IEnumerable<T> collection)
            where T : IConvertible
        {
            var decCollection = collection
                .Select(x => Convert.ToDecimal(x));

            decimal result = decimal.MaxValue;

            foreach (var number in decCollection)
            {
                if (number < result)
                {
                    result = number;
                }
            }

            return result;
        }

        public static decimal MyMax<T>(this IEnumerable<T> collection)
            where T : IConvertible
        {
            var decCollection = collection
                .Select(x => Convert.ToDecimal(x));

            decimal result = decimal.MinValue;

            foreach (var number in decCollection)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }

        public static decimal MyAverage<T>(this IEnumerable<T> collection)
            where T : IConvertible
        {
            var decCollection = collection
                .Select(x => Convert.ToDecimal(x));

            decimal sum = 0;

            foreach (decimal number in decCollection)
            {
                sum += number;
            }

            return sum / decCollection.Count();
        }
    }
}

