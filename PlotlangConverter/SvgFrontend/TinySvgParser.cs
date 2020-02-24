using PlotlangConverter.IRTools;
using PlotlangConverter.SvgFrontend.TokenDefinitions;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {
        public class Wrapper
        {
            public byte id { get; set; }
            public Dictionary<string, int> keys { get; set; }

            public Wrapper(byte id, Dictionary<string, int> keys)
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

            IRWriter.Write(Json, @"test.txt");
        }
    }
}
