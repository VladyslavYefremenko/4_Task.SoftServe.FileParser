using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoftServe.FileParser
{
    class FileLenght
    {
        public static int getLenght(string filePath)
        {
            int lenght = File.ReadAllLines(filePath).Length;

            return lenght;
        }
    }
}
