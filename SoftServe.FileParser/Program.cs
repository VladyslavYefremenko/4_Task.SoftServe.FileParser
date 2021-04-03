using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class Program
    {
        // ToDo: add instraction
        // ToDo: add XML

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            if (args.Length == 0 || !ArgsValidator.ValidateArgs(args[0]))
            {
                Console.WriteLine("Instracton");
                Console.ReadKey();
                return;
            }

            stopWatch.Start();
            ProgrammController.StartApp(args);
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            Console.WriteLine(timeSpan);
            Console.ReadKey();
        }
    }
}
