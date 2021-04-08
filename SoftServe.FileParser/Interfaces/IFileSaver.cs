namespace SoftServe.FileParser
{
    interface IFileSaver
    {
        void SaveFile(string tempFilePath, string filePath);
    }
}
