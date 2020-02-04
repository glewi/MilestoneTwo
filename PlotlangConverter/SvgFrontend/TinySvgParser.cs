using PlotlangConverter.TokenDefinitions;
using System;
using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {
        public static void Parse(IToken token)
        {
            Console.WriteLine(token.GetTokenID());
        }
    }
}
