using PlotlangConverter.IRTools;
using PlotlangConverter.SvgFrontend.TokenDefinitions;
using System.Collections.Generic;
using System.Text.Json;
using System;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {
        private const string path = @"IR.json";

        public class JsonRoot
        {
            public SerialiseObject[] tokenarray { get; set; }
        }

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
            JsonRoot jsonWrapper;
            SerialiseObject serialiseWrapper;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            jsonWrapper = new JsonRoot();
            jsonWrapper.tokenarray = new SerialiseObject[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                IToken token = tokens[i];
                serialiseWrapper = new SerialiseObject(token.GetID(), token.GetNamedParams());
                jsonWrapper.tokenarray[i] = serialiseWrapper; //JsonSerializer.Serialize(serialiseWrapper, options) + "\n";
            }

            var Json = JsonSerializer.Serialize(jsonWrapper, options);
            IRWriter.Write(Json, @path);
        }

        public static void Parse(IToken token)
        {
            SerialiseObject wrapper = new SerialiseObject(token.GetID(), token.GetNamedParams());

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var Json = JsonSerializer.Serialize(wrapper, options) + "\n";

            IRWriter.Write(Json, @path);
        }
    }
}
