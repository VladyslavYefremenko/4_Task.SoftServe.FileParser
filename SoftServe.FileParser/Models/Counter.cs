using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class Counter
    {
        public static int CountNumOf(string filePath, string inputArg)
        {
            const int MAX_SIZE = 1000;

            int count = 0;
            int numOfLinesToSkip = 0;
            int fileLines = 1;
            int counter = 0;
            List<string> lines = new List<string>();

            do
            {
                lines = FileReader.ReadFile(filePath, numOfLinesToSkip, MAX_SIZE);

                foreach (var line in lines)
                {
                    var lineArr = line.Split(' ');

                    foreach (var lineInArr in lineArr)
                    {
                        if (lineInArr.Contains(inputArg))
                        {
                            count += 1;
                        }
                    }
                }
                fileLines += lines.Count;

                lines.Clear();

                counter += MAX_SIZE;
                numOfLinesToSkip += MAX_SIZE;

            } while (counter < fileLines);

            return count;
        }
    }
}
