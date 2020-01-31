using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter.SvgFrontend
{
    public static class SvgLexer
    {
        private static TokenFactory factory = new TokenFactory();

        

        public static IToken Lex(List<XElement> prog)
        {
            foreach (XElement element in prog)
            {
                Console.WriteLine(element.ToString());
            }
            
            return factory.CreateToken(0);
            //throw new NotImplementedException();
        }
    }
}
