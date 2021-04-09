using System.Collections.Generic;

namespace SoftServe.FileParser
{
    public class Counter
    {
        public static int CountNumOf(string filePath, string inputArg)
        {
            int count = 0;

            List<string> lines = new List<string>();

            FileManager fileManager = new FileManager();
            
            foreach (var line in fileManager.ReadFile(filePath))
            {
                var lineArr = line.Split(' ');

                foreach (var word in lineArr)
                {
                    if (word.Contains(inputArg))
                    {
                        count += 1;
                    }
                }
            }
            
            return count;
        }
    }
}
