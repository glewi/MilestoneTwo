using System;

namespace PlotlangConverter
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    string @inputpath = args[0];
                    string @outputpath = args[1];

                    CompilerFaçade.Compile(inputpath, outputpath);
                }
                else
                {
                    throw new ArgumentException(
                        Properties.Resources.ArgumentExceptionString);
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return 1;
            }
            return 0;
        }
    }
}
