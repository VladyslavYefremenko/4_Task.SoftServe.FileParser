using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class ProgrammController
    {
        public static void StartApp(string[] args)
        {
            if (args.Length == 2)
            {
                CounterController.StartCount(args[0], args[1]);
            }
            else
            {
                ReplacerController.Replace(args[0], args[1], args[2]);
            }
        }
    }
}
