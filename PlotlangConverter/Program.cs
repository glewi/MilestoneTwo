using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    string @inputpath = args[0];
                    string @outputpath = args[1];

                    CompilerFaçade.Compile(inputpath, outputpath);
                }
                else;
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
