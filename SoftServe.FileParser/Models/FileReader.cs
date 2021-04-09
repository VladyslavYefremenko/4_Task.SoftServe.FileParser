using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoftServe.FileParser.Models
{
    public class FileReader : IFileReader
    {
        public List<string> ReadFile(string filePath, int numOfLine, int maxSize) // ToDo: переделать
        {
            List<string> lines = new List<string>();

            foreach (var line in File.ReadLines(filePath).Skip(numOfLine))
            {
                lines.Add(line);

                if (lines.Count == maxSize)
                {
                    break;
                }
            }

            return lines;
        }
    }
}
