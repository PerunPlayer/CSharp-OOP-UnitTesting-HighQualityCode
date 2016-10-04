namespace DefineClass
{
    using System;

    class GSM_Test
    {
        static void Main()
        {
            Test();
            CallHistoryTest();
        }
        public static void Test()
        {
            Console.WriteLine("Let we make a GSM test...\n");

            GSM[] phoneTest = new GSM[]
            {
                new GSM("Xperia Z5", "Sony", 1000, "Bastian Schweinsteiger",
                    new Battery("Zver", 120, 20, BatteryType.LiIon),
                    new Display((decimal)5.5, 16000000)),
                new GSM("G-Flex", "LG", (decimal)399.99, "Pavkata",
                    new Battery("G5", 90, 8 ,BatteryType.LithiumPolymer),
                    new Display((decimal)5.2, 16000000)),
                new GSM("T280i", "Sony Ericsson", 40, "Yanko",
                    new Battery("2005", 48, 3, BatteryType.NiCd),
                    new Display((decimal)1.7, 65000)),
                GSM.Iphone4S
            };

            foreach (var gsm in phoneTest)
            {
                Console.WriteLine(gsm.ToString());
            }
            Console.WriteLine();
        }

        static void CallHistoryTest()
        {
            decimal pricePerMinute = 0.37m;

            Console.WriteLine("Let we test th call history! Ready? ...................\n");

            GSM GFlex = new GSM("G-Flex", "LG", (decimal)399.99, "Pavkata",
                    new Battery("G5", 90, 8, BatteryType.LithiumPolymer),
                    new Display((decimal)5.2, 16000000));

            GFlex.AddCall(new Calls("01/01/2001", "00:01", "0883654675", 567));
            GFlex.AddCall(new Calls("20/07/2013", "22:40", "0894223760", 120));
            GFlex.AddCall(new Calls("29/02/2016", "05:10", "0899132465", 221));
            GFlex.AddCall(new Calls("16/06/2016", "11:59", "0895386583", 21));
            GFlex.AddCall(new Calls("31/06/2016", "06:09", "0877975201", 243));

            for (int i = 0; i < GFlex.History.Count; i++)
            {
                Console.WriteLine(GFlex.History[i]);
            }

            Console.WriteLine("Calls Price: {0:F2}", GFlex.totalPrice(pricePerMinute));

            Calls longest = GFlex.History[0];
            foreach (var call in GFlex.History)
            {
                if (call.CallDuration > longest.CallDuration)
                {
                    longest = call;
                }
            }
            GFlex.DeleteCall(longest);
            Console.WriteLine("Calls Price without longest: {0:F2}", GFlex.totalPrice(pricePerMinute));

            GFlex.ClearCallHistory();
            Console.WriteLine("Call history cleared!");
        }
    }
}
