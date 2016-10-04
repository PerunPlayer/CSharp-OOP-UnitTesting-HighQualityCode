using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class Program
{
    public static string[] numeralSystem = {"cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan"};

    public static BigInteger ToDecimal(string[] numeralSystem, string joroNumber)
    {
        List<string> result = new List<string>();
        List<string> joroParts = new List<string>();

        for (int i = 0; i < joroNumber.Length; i += numeralSystem[0].Length)
        {
            joroParts.Add(joroNumber.Substring(i, 3));
        }

        for (int i = 0; i < joroParts.Count; i++)
        {
            result.Add(Array.IndexOf(numeralSystem, joroParts[i]).ToString());
        }

        try
        {
            return BigInteger.Parse(string.Join("", result));
        }
        catch (Exception)
        {
            return 0;
        }
    }

    public static StringBuilder TurnToJoroNumeralSystem(string decimalCalcResult, string[] numeralSystem)
    {
        StringBuilder resultBuilder = new StringBuilder();

        for (int i = 0; i < decimalCalcResult.Length; i++)
        {
            resultBuilder.Append(numeralSystem[(int)char.GetNumericValue(decimalCalcResult[i])]);
        }

        return resultBuilder;
    }

    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string operation = Console.ReadLine();
        string secondNumber = Console.ReadLine();

        BigInteger firstNumberToDecimal = ToDecimal(numeralSystem, firstNumber);
        BigInteger secondNumberToDecimal = ToDecimal(numeralSystem, secondNumber);

        BigInteger decimalCalculation = 0;
        switch (operation)
        {
            case "+":
                decimalCalculation = firstNumberToDecimal + secondNumberToDecimal;
                break;
            case "-":
                if (firstNumberToDecimal > secondNumberToDecimal)
                {
                    decimalCalculation = firstNumberToDecimal - secondNumberToDecimal;
                }
                else
                {
                    decimalCalculation = secondNumberToDecimal - firstNumberToDecimal;
                }
                break;
            default:
                throw new ArgumentException("Operation can only be subtraction or addition.");
                break;
        }
        
        string decimalCalculationToString = decimalCalculation.ToString();
        Console.WriteLine(string.Join("", TurnToJoroNumeralSystem(decimalCalculationToString, numeralSystem)));
    }
}
