using System.Collections.Generic;

namespace SoftServe.FileParser
{
    public interface IFileManager
    {
        IEnumerable<string> ReadFile(string filePath);

        void SaveFile(string tempFilePath, string filePath);
    }
}