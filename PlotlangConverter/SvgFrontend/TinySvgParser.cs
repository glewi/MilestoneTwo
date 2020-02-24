using PlotlangConverter.IRTools;
using PlotlangConverter.SvgFrontend.TokenDefinitions;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {
        /// <summary>
        /// A workaround wrapper class for serialising JSON.
        /// <remarks>
        /// JSON cannot support polymorphic serialisation by default without creating large custom converters.  
        /// This class is a workaround for serialising the IToken interface without having to specify the IToken type.
        /// </remarks>
        /// </summary>
        public class Wrapper
        {
            public byte tokenID { get; set; }
            public Dictionary<string, int> attributes { get; set; }
            public Dictionary<string, int> optionalAttributes { get; set; }
            public Dictionary<string, string> styleAttributes { get; set; }

            public Wrapper(byte tokenID, Dictionary<string, int> attributes)
            {
                this.tokenID = tokenID;
                this.attributes = attributes;
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
