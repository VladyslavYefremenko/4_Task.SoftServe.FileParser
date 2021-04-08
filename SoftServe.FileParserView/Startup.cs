using SoftServe.FileParser;

namespace SoftServe.FileParserView
{
    class Startup
    {
        public static void Start(string[] args)
        {
            FilePathValidator validator = new FilePathValidator();

            if (args.Length > 0 && validator.ValidateArgs(args[0]))
            {
                if (args.Length == 2)
                {
                    CounterController.Count(args[0], args[1]);
                }
                else
                {
                    ReplacerController.Replace(args[0], args[1], args[2]);
                }
            }
            else
            {
                Printer printer = new Printer();

                printer.Instraction(DefaultSettings.INSTRACTION_PATH);
            }
        }
    }
}
