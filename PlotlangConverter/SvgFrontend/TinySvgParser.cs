using PlotlangConverter.TokenDefinitions;
using System;
using System.Collections.Generic;

using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {
        public class Wrapper
        {
            public UInt16 id { get; set; }
            public Dictionary<string, int> keys { get; set; }

            public Wrapper(UInt16 id, Dictionary<string, int> keys)
            {
                this.id = id;
                this.keys = keys;
            }
        }

        public static void Parse(IToken token)
        {
            Wrapper wrapper = new Wrapper(token.GetID(), token.GetNamedParams());

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var Json = JsonSerializer.Serialize(wrapper, options);

            IRTools.IRWriter.Write(Json, @"test.txt");

            throw new NotImplementedException();
        }
    }
}
