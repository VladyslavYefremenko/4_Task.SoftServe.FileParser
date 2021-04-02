using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class FileSaver
    {
        public static void SaveFile()
        {
            File.Replace("..\\..\\..\\tempTest.txt", "..\\..\\..\\test.txt", "..\\..\\..\\backupTest.txt");
        }
    }
}
