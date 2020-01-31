﻿using System;
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
        private static SvgFrontendFaçade svg = new SvgFrontendFaçade();
        
        public static void Compile(string @input, string @output)
        {
            List<XElement> prog = SvgReader.ReadFileLINQ(input);            
            SvgLexer.Lex(prog);
        }
    }
}
