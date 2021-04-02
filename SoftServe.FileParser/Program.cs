using System;
using System.Collections.Generic;
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
            if (args.Length == 0)
            {
                Console.WriteLine("Instracton");
                Console.ReadKey();
                return;
            }

            ProgrammController.StartApp(args);
        }
    }
}
