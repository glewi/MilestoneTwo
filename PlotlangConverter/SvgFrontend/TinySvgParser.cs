using PlotlangConverter.TokenDefinitions;
using System;
using System.Collections.Generic;
using System.Collections;
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

            IList<int> vs = new List<int>(  new int[] { 1,2,3,4,5} );
            Console.WriteLine(JsonSerializer.Serialize(vs));

            

            Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
            dic.Add(token.GetTokenID().ToString(),new int[3] { 123,456,789});
            Console.WriteLine(JsonSerializer.Serialize(dic));

        }
    }
}
