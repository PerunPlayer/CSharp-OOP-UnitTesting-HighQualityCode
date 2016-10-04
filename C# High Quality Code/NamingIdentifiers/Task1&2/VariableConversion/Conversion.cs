namespace VariableConversion
{
    using System;

    public class Conversion
    {
        private const int Max_ExecutionCount = 6;

        public void ConvertedToString(bool isString)
        {
            string convertedToString = isString.ToString();
            Console.WriteLine(convertedToString);
        }
    }
}
