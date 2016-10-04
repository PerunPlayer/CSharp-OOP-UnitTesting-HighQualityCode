using System;
using System.Collections.Generic;

namespace MethodStartup.Utils
{
    public class Calculations
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
            }
            else if (a + b > c && a + c > b && c + b > a)
            {
                double halfPerimeter = (a + b + c) / 2;
                double triangleArea = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

                return triangleArea;
            }
            else
            {
                throw new ArgumentException("This triangle does not exist!");
            }
            
        }

        internal static string ConvertDigitToString(int digit)
        {
            var arabicDigits = new Dictionary<int, string>()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" }
            };

            if (arabicDigits[digit] is string)
            {
                string parsedNumber = arabicDigits[digit];
                return parsedNumber;
            }
            else
            {
                throw new ArgumentException("There is no such digit");
            }
        }

        internal static int GetMaxValue(params int[] elementsArray)
        {
            if (elementsArray == null || elementsArray.Length == 0)
            {
                throw new ArgumentException("There is no elements in the array!");
            }

            var currentBiggest = elementsArray[0];

            for (int i = 1; i < elementsArray.Length; i++)
            {
                if (elementsArray[i] > currentBiggest)
                {
                    currentBiggest = elementsArray[i];
                }
            }

            return currentBiggest;
        }

        internal static double CalculateDistance(double pointX1, double pointY1, double pointX2, double pointY2)
        {
            double productX = (pointX2 - pointX1) * (pointX2 - pointX1);
            double productY = (pointY2 - pointY1) * (pointY2 - pointY1);

            double distanceBetweenPoints = Math.Sqrt(productX + productY);

            return distanceBetweenPoints;
        }
    }
}
