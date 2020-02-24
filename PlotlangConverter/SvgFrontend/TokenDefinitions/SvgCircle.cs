using System;
using System.Collections.Generic;

namespace PlotlangConverter.SvgFrontend.TokenDefinitions
{
    public class SvgCircle : IToken
    {
        UInt16 tokenID = 1;

        // XY coords for the center of the circle.
        Tuple<int, int> xy { get; set; }

        // Circle radius.
        uint r { get; set; } = 0;

        public SvgCircle(params int[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            uint r = Convert.ToUInt32(vs[0]);
        }

        public int[] GetParams()
        {
            xy.Deconstruct(out int x, out int y);
            uint r = this.r;

            return new int[] { x, y };
        }

        public void SetParams(params int[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            uint r = Convert.ToUInt32(vs[2]);

            xy = new Tuple<int, int>(x, y);
            this.r = r;
        }

        public Dictionary<string, int> GetNamedParams()
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            return keyValuePairs;
        }

        public UInt16 GetID()
        {
            return tokenID;
        }
    }
}