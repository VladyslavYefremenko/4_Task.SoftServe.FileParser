namespace SoftServe.FileParser
{
    interface IReplacer
    {
        string Replace(string line, string stringForReplace, string replacingString);
    }
}
