using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class FileReader
    {
        public static string ReadFile(string filePath, int numOfLine)
        {
            string line = File.ReadLines(filePath).Skip(numOfLine).First();

            return line;
        }
    }
}
