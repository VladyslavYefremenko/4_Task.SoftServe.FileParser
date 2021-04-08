using System.IO;

namespace SoftServe.FileParser
{
    public class FileSaver : IFileSaver
    {
        public void SaveFile(string tempFilePath, string filePath)
        {
            string pathBackup = Path.GetFullPath(filePath);
            pathBackup = pathBackup.Insert(pathBackup.Length - 4, "_backup");
            File.Replace(tempFilePath, filePath, pathBackup);
        }
    }
}
