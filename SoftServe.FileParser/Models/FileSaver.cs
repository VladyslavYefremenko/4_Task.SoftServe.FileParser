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
        public static void SaveFile(string tempFilePath, string filePath)
        {
            string pathBackup = Path.GetFullPath(filePath);
            pathBackup = pathBackup.Insert(pathBackup.Length - 4, "_backup");
            //File.Replace("..\\..\\..\\tempTest.txt", "..\\..\\..\\test.txt", "..\\..\\..\\backup.txt");
            File.Replace(tempFilePath, filePath, pathBackup);
        }
    }
}
