using System;
using System.Collections.Generic;
using System.IO;

using SoftServe.FileParser;

namespace SoftServe.FileParserView
{
    class ReplacerController
    {
        public static void Replace(string filePath, string stringForReplace, string replacingString)
        {
            string tempFilePath = $"..\\..\\..\\temp{Path.GetFileName(filePath)}";
            
            FileManager fileManager = new FileManager();

            foreach (var line in fileManager.ReadFile(filePath))
            {
                if (line.Contains(stringForReplace))
                {
                    File.AppendAllText(tempFilePath, line.Replace(stringForReplace, replacingString) + "\n");
                }
                else
                {
                    File.AppendAllText(tempFilePath, line + "\n");
                }
            }
            
            fileManager.SaveFile(tempFilePath, filePath);
            
            Printer printer = new Printer();
            
            printer.Message("File saved!");
            
            Console.ReadKey();
        }
    }
}
