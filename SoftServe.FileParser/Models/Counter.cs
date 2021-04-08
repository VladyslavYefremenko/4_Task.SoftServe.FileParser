using System.Collections.Generic;

namespace SoftServe.FileParser
{
    public class Counter
    {
        public static int CountNumOf(string filePath, string inputArg)
        {
            int maxSize = DefaultSettings.MAX_SIZE_ARRAY;

            int count = 0;
            int numOfLinesToSkip = 0;
            int fileLines = 1;
            int counter = 0;
            List<string> lines = new List<string>();

            FileReader reader = new FileReader();
            do
            {
                lines = reader.ReadFile(filePath, numOfLinesToSkip, maxSize);

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

                counter += maxSize;
                numOfLinesToSkip += maxSize;

            } while (counter < fileLines);

            return count;
        }
    }
}
