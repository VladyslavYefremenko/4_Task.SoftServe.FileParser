using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class CounterView
    {
        public static void ViewCount(int count, string inputArg)
        {
            Console.WriteLine($"Count of [{inputArg}] - {count}");
            //Console.ReadKey();
        }
    }
}
