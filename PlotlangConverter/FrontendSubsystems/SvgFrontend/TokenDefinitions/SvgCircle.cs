using System;
using System.Collections.Generic;

namespace PlotlangConverter.SvgFrontend.TokenDefinitions
{
    public class SvgCircle : IToken
    {
        readonly byte tokenID = 1;

        // XY coords for the center of the circle.
        private int x, y = 0;

        // Circle radius.
        private uint r { get; set; } = 0;

        public SvgCircle(params int[] vs)
        {
            (x, y) = (vs[0], vs[1]);
            r = Convert.ToUInt32(vs[2]);
        }

        public Dictionary<string,int> GetNamedParams()
        {
            Dictionary<string, int> tokenInformation = new Dictionary<string, int>();

            tokenInformation.Add("x", x);
            tokenInformation.Add("y", y);

            tokenInformation.Add("r", Convert.ToInt32(r));

            return tokenInformation;
        }

        public void SetParams(params int[] vs)
        {
            (int x, int y) = (vs[0], vs[1]);
            uint r = Convert.ToUInt32(vs[2]);
        }

        public byte GetID()
        {
            return tokenID;
        }

        public int[] GetParams()
        {
            return new int[] { x, y, 
                checked(Convert.ToInt32(r)) 
            };
        }
    }
}