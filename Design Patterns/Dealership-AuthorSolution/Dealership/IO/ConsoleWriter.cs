using System;

using Dealership.Contracts.IO;

namespace Dealership.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(object obj)
        {
            Console.Write(obj);
        }
    }
}