using System;
using System.IO;

namespace SoftServe.FileParserView
{
    class Printer : IPrinter
    {
        public void Instraction(string instractionFilePath)
        {
            StreamReader sr = new StreamReader(instractionFilePath);
            string line = sr.ReadLine();

            Console.Clear();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();

            Console.ReadKey();
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
