using System.Collections.Generic;
namespace PlotlangConverter.SvgFrontend.TokenDefinitions
{
    public class SvgLine : IToken
    {
        readonly byte tokenID = 3;

        private int x1, y1 ,x2,y2 = 0;

        public SvgLine(params int[] vs)
        {
            (x1, y1) = (vs[0], vs[1]);
            (x2, y2) = (vs[2], vs[3]);
        }

        public Dictionary<string,int> GetNamedParams()
        {
            Dictionary<string, int> tokenInformation = new Dictionary<string, int>
            {
                { "x1", x1 },
                { "y1", y1 },
                { "x2", x2 },
                { "y2", y2 }
            };

            return tokenInformation;
        }

        public byte GetID()
        {
            return tokenID;
        }

        public int[] GetParams()
        {
            return new int[] { x1, y1 ,x2,y2 };
        }

        public void SetParams(params int[] vs)
        {
            (x1, y1) = (vs[0], vs[1]);
            (x2, y2) = (vs[2], vs[3]);
        }
    }
}
