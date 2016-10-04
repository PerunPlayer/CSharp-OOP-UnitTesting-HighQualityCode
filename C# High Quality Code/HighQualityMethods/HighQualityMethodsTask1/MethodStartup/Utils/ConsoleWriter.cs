using System;

namespace MethodStartup.Utils
{
    public class ConsoleWriter
    {
        public static string FormatNumber(double number, string format)
        {
            string formattedNumber = string.Empty;

            switch (format)
            {
                case "f":
                    formattedNumber = string.Format("{0:F2}", number);
                    break;
                case "%":
                    formattedNumber = string.Format("{0:P0}", number);
                    break;
                case "r":
                    formattedNumber = string.Format("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid command!");
            }

            return formattedNumber;
        }
    }
}
