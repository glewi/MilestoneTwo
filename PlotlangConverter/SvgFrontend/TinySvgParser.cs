using PlotlangConverter.IRTools;
using PlotlangConverter.SvgFrontend.TokenDefinitions;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {
        private const string path = @"IR.json";
        
        /// <summary>
        /// A workaround wrapper class for serialising JSON.
        /// </summary>
        public class SerialiseObject
        {
            public byte tokenID { get; set; }
            public Dictionary<string, int> attributes { get; set; }
            public Dictionary<string, int> optionalAttributes { get; set; }
            public Dictionary<string, string> styleAttributes { get; set; }

            public SerialiseObject(byte tokenID, Dictionary<string, int> attributes)
            {
                this.tokenID = tokenID;
                this.attributes = attributes;
            }
        }

        public static void Parse(IToken[] tokens)
        {
            SerialiseObject wrapper;
            string Json;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            foreach (IToken token in tokens)
            {
                wrapper = new SerialiseObject(token.GetID(), token.GetNamedParams());
                Json = JsonSerializer.Serialize(wrapper, options) + "\n";
                IRWriter.Write(Json, path);
            }
        }
        
        public static void Parse(IToken token)
        {
            SerialiseObject wrapper = new SerialiseObject(token.GetID(), token.GetNamedParams());

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var Json = JsonSerializer.Serialize(wrapper, options) + "\n";

            IRWriter.Write(Json, path);
        }
    }
}
