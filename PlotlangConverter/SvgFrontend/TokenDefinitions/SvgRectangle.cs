using System;
using System.Collections.Generic;

namespace PlotlangConverter.SvgFrontend.TokenDefinitions
{
    public class SvgRectangle : IToken
    {
        UInt16 tokenID = 2;

        // XY coords for the bottom left corner of the rectangle.
        private int x, y;

        // XY values for rounded rectangles. 
        private uint rx, ry;

        // Rectangle width and height dimensions
        private uint width, height;

        public SvgRectangle(params int[] vs)
        {
            (x, y) = (vs[0], vs[1]);
            (rx, ry) = (Convert.ToUInt32(vs[2]), Convert.ToUInt32(vs[3]));
            (width, height) = (Convert.ToUInt32(vs[4]), Convert.ToUInt32(vs[5]));
        }

        public Dictionary<string, int> GetNamedParams()
        {
            Dictionary<string, int> tokenInformation = new Dictionary<string, int>();

            tokenInformation.Add("x", x);
            tokenInformation.Add("y", y);

            tokenInformation.Add("rx", Convert.ToInt32(rx));
            tokenInformation.Add("yx", Convert.ToInt32(ry));

            tokenInformation.Add("width", Convert.ToInt32(width));
            tokenInformation.Add("height", Convert.ToInt32(height));

            return tokenInformation;
        }

        public UInt16 GetID()
        {
            return tokenID;
        }

        public int[] GetParams()
        {
            return new int[] { x, y,
                checked(Convert.ToInt32(rx)),
                checked(Convert.ToInt32(ry)),
                checked(Convert.ToInt32(width)),
                checked(Convert.ToInt32(height))
            };
        }

        public void SetParams(params int[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            (uint rx, uint ry) = (Convert.ToUInt32(vs[2]), Convert.ToUInt32(vs[3]));
            (uint width, uint height) = (Convert.ToUInt32(vs[4]), Convert.ToUInt32(vs[5]));
        }
    }
}