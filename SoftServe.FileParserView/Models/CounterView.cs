using System;

namespace SoftServe.FileParserView
{
    class CounterView
    {
        public static void ViewCount(int count, string inputArg)
        {
            Printer printer = new Printer();

            printer.Message($"Count of [{inputArg}] - {count}");

            Console.ReadKey();
        }
    }
}
