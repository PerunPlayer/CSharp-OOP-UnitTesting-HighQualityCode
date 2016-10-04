using System;

using log4net;
using log4net.Config;

namespace Log4NetExample
{
    public static class Logger
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Logger));

        public static void Main()
        {
            XmlConfigurator.Configure();
            Log.Info("Info logging");
            try
            {
                throw new Exception("Exception!");
            }
            catch (Exception e)
            {
                Log.Error("This is my error", e);
            }

            Console.WriteLine("[any key to exit]");
            Console.ReadKey();
        }
    }
}