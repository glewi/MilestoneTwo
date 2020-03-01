using PlotlangConverter.IRTools;
using PlotlangConverter.SvgFrontend.TokenDefinitions;
using System.Collections.Generic;
using System.Text.Json;
using System;

namespace PlotlangConverter.FrontendSubsystems.SvgFrontend
{
    static class TinySvgParser
    {
        private const string path = @"IR.json";

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
                serialiseWrapper = new SerialiseObject();
                serialiseWrapper.tokenID = token.GetID();
                serialiseWrapper.attributes = token.GetNamedParams();
                jsonWrapper.tokenarray[i] = serialiseWrapper; //JsonSerializer.Serialize(serialiseWrapper, options) + "\n";
            }

            var Json = JsonSerializer.Serialize<JsonRoot>(jsonWrapper, options);
            IRWriter.Write(Json, @path);
        }

        public static void Parse(IToken token)
        {
            SerialiseObject wrapper = new SerialiseObject();

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var Json = JsonSerializer.Serialize(wrapper, options) + "\n";

            IRWriter.Write(Json, @path);
        }
    }
}
