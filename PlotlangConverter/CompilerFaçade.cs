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
            List<XElement> prog = TinySvgReader.ReadFileLINQ(input);            
            TinySvgLexer.Lex(prog);
        }
    }
}
