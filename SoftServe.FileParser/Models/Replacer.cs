using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class Replacer
    {
        public static string Replace(string line, string stringForReplace, string replacingString)
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
