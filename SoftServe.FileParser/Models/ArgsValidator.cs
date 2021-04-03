using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.FileParser
{
    class ArgsValidator
    {
        public static bool ValidateArgs(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
