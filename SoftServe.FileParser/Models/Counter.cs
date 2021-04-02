using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class Counter
    {
        public static int CountNumOf(string filePath, string inputArg)
        {
            int fileLenght = FileLenght.getLenght(filePath);
            int count = 0;

            for (int i = 0; i < fileLenght; i++)
            {
                string line = FileReader.ReadFile(filePath, i);

                var lineArr = line.Split(' ');

                foreach (var lineInArr in lineArr)
                {
                    if (inputArg == lineInArr)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
