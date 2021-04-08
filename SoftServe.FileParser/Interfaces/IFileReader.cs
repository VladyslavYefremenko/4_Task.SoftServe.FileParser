using System.Collections.Generic;

namespace SoftServe.FileParser
{
    interface IFileReader
    {
        List<string> ReadFile(string filePath, int numOfLine, int maxSize);
    }
}
