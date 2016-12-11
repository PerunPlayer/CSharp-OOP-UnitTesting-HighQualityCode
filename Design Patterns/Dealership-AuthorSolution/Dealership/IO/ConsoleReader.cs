using System;

using Dealership.Contracts.IO;

namespace Dealership.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            string line = Console.ReadLine();
            return line;
        }
    }
}