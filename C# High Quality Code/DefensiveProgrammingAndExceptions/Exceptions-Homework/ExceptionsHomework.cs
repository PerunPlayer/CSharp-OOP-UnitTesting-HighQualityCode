using Exceptions_Homework;
using System;
using System.Collections.Generic;

class ExceptionsHomework
{
    public static void Main()
    {
        Strings();

        Maths();

        Exams();
    }

    private static void Strings()
    {
        var subString = Operations.GetSubsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(subString);

        var numbersArray = new int[] { -1, 3, 2, 1 };

        var subArray = Operations.GetSubsequence(numbersArray, 0, 2);
        Console.WriteLine(string.Join(" ", subArray));

        var subArrayWithInitialArrayLength = Operations.GetSubsequence(numbersArray, 0, numbersArray.Length);
        Console.WriteLine(string.Join(" ", subArrayWithInitialArrayLength));

        var emptyArray = Operations.GetSubsequence(numbersArray, 0, 0);
        Console.WriteLine(string.Join(" ", emptyArray));

        Console.WriteLine(GetExtractedStringEndings());
    }

    private static string GetExtractedStringEndings()
    {
        var result = new List<string>();
        var extractStrings = new Dictionary<string, int>()
        {
            { "I love C#", 2 },
            { "Nakov", 4 },
            { "beer", 4 },
            { "Hi", 100 }
        };

        foreach (var someString in extractStrings)
        {
            try
            {
                result.Add(Operations.ExtractEnding(someString.Key, someString.Value));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Cannot extract ending with length {0} from '{1}'!", someString.Value, someString.Key);
            }
        }

        var returnString = string.Join(" ", result);

        return returnString;
    }

    private static void Maths()
    {
        var numbers = new List<int>();

        foreach (var number in numbers)
        {
            var isPrime = Operations.IsPrime(number);

            if (isPrime)
            {
                Console.WriteLine("{0} is prime!", number);
            }
            else
            {
                Console.WriteLine("{0} is not prime!", number);
            }
        }
    }

    private static void Exams()
    {
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalculateAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
