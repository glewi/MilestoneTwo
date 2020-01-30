using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter
{   
    class Rect : IToken
    {

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rect token = new Rect();
            
            SymbolTable.AddToken(0, token);
            var obj = SymbolTable.GetToken(0);
            Console.WriteLine(obj.ToString());
            
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
                    throw new ArgumentException("Argument exception");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
