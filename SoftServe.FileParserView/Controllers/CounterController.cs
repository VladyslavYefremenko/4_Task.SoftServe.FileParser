using SoftServe.FileParser;

namespace SoftServe.FileParserView
{
    class CounterController
    {
        public static void Count(string filePath, string inputArg)
        {
            int numOf = Counter.CountNumOf(filePath, inputArg);

            CounterView.ViewCount(numOf, inputArg);
        }
    }
}
