using PlotlangConverter.TokenDefinitions;
using System;
using System.Text.Json;

namespace PlotlangConverter.SvgFrontend
{
    static class TinySvgParser
    {   
        public class SerialisationObject
        {
            public UInt16 TokenID { get; set; }
            object[] args { get; set; }

            public SerialisationObject(uint TokenID, params object[] vs)
            {
                this.TokenID = (UInt16)TokenID;
                args = new object[vs.Length];
                args = vs;
            }
        }

        public static void Parse(IToken token)
        {
            SerialisationObject serialisation = new SerialisationObject(token.GetTokenID(), token.GetParams());
            string json = JsonSerializer.Serialize(serialisation);
        }
    }
}
