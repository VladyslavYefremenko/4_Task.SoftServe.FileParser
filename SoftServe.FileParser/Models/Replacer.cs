namespace SoftServe.FileParser
{
    public class Replacer : IReplacer
    {
        public string Replace(string line, string stringForReplace, string replacingString)
        {
            string result = line;

            if (result.Contains(stringForReplace))
            {
                result = result.Replace(stringForReplace, replacingString);
            }

            return result;
        }
    }
}
