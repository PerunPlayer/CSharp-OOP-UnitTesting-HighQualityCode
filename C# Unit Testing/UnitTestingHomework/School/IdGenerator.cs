namespace School
{
    using System;
    using System.Threading;

    public static class IdGenerator
    {
        private static int idCounter;

        static IdGenerator()
        {
            idCounter = 10000;
        }

        public static int GenerateId()
        {
            return Interlocked.Increment(ref idCounter);
        }
    }
}
