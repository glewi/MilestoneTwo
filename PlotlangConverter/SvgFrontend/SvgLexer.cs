using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.SvgFrontend
{
    static class SvgLexer
    {
        public static IToken Lex(string line)
       {
            IToken token = new RectangleToken();
            
            return token;

       }
    }
}
