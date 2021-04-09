using System.Collections.Generic;
using System.IO;

namespace SoftServe.FileParser
{
    public class FileManager : IFileManager
    {
        public IEnumerable<string> ReadFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.Peek() != -1)
                {
                    yield return reader.ReadLine();
                }
            }
        }

        public void SaveFile(string tempFilePath, string filePath)
        {
            string pathBackup = Path.GetFullPath(filePath);
            
            pathBackup = pathBackup.Insert(pathBackup.Length - 4, "_backup");
            
            File.Replace(tempFilePath, filePath, pathBackup);
        }
    }
}