using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class CounterController
    {
        public static void StartCount(string filePath, string inputArg)
        {
            int numOf = Counter.CountNumOf(filePath, inputArg);

            CounterView.ViewCount(numOf, inputArg);
        }
    }
}
