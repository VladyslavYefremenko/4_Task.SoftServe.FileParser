using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class ReplacerController
    {
        public static void Replace(string filePath, string stringForReplace, string replacingString)
        {
            int fileLenght = FileLenght.getLenght(filePath);

            string tempFilePath = "..\\..\\..\\tempTest.txt";

            for (int i = 0; i < fileLenght; i++)
            {
                string line = FileReader.ReadFile(filePath, i);

                line = Replacer.Replace(line, stringForReplace, replacingString);

                File.AppendAllText(tempFilePath, line + "\n");
            }

            FileSaver.SaveFile();

            Console.WriteLine("File saved!"); // ToDo: add DLL printer
            Console.ReadKey();

        }
    }
}
