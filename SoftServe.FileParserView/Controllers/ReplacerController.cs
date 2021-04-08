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
            const int MAX_SIZE = DefaultSettings.MAX_SIZE_ARRAY;

            List<string> outputLines = new List<string>();
            List<string> inputLines = new List<string>();

            string tempFilePath = $"..\\..\\..\\temp{Path.GetFileName(filePath)}";
            int counter = 0;
            int numOfLinesToSkip = 0;
            int fileLines = 0;
            int countOfReplace = 0;

            FileReader reader = new FileReader();
            do
            {
                inputLines = reader.ReadFile(filePath, numOfLinesToSkip, MAX_SIZE);

                foreach (var line in inputLines)
                {
                    string resultLine = string.Empty;

                    if (line.Contains(stringForReplace))
                    {
                        resultLine = line.Replace(stringForReplace, replacingString);
                        countOfReplace++;
                    }
                    else
                    {
                        resultLine = line;
                    }

                    outputLines.Add(resultLine);
                }

                File.AppendAllLines(tempFilePath, outputLines);

                fileLines += inputLines.Count;
                counter += MAX_SIZE;
                numOfLinesToSkip += MAX_SIZE;

                outputLines.Clear();
                inputLines.Clear();

            } while (counter <= fileLines);

            FileSaver saver = new FileSaver();

            saver.SaveFile(tempFilePath, filePath);

            Printer printer = new Printer();

            printer.Message("File saved!");

            Console.ReadKey();
        }
    }
}
