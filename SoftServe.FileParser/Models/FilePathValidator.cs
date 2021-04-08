using System.IO;

namespace SoftServe.FileParser
{
    public class FilePathValidator : IFilePathValidator
    {
        public bool ValidateArgs(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
