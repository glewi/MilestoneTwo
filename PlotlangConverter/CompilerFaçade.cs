using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using PlotlangConverter.SvgFrontend;
using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter
{
    static class CompilerFaçade
    {
        private static TinySvgFrontendFaçade svg = new TinySvgFrontendFaçade();
        
        public static void Compile(string @input, string @output)
        {
            var prog = TinySvgReader.ReadFile(input);            
            TinySvgLexer.Lex(prog);
            
        }
    }
}
