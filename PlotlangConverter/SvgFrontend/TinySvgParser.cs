using PlotlangConverter.TokenDefinitions;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {
        public static void Parse(IToken token)
        {
            Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
            dic.Add(token.GetTokenID().ToString(),new int[3] { 123,456,789});
            Console.WriteLine(JsonSerializer.Serialize(dic));

            foreach (object arg in token.GetParams())
            {
                Console.WriteLine(arg.ToString());
            }

        }
    }
}
