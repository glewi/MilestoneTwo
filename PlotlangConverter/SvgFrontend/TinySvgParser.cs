using PlotlangConverter.TokenDefinitions;
using System;
using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {   
        public static void Parse(IToken token)
        {
            Tuple<uint, object[]> tuple = new Tuple<uint, object[]>(token.GetTokenID(), token.GetParams());
            Console.WriteLine(tuple.ToString());
            Console.WriteLine(JsonSerializer.Serialize(tuple));
        }
    }
}
