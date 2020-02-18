using System;
using System.Collections.Generic;

namespace PlotlangConverter.TokenDefinitions
{
    public interface IToken
    {
        UInt16 GetID();
        Dictionary<string, int> GetNamedParams();
        int[] GetParams();
        void SetParams(params int[] parameters);
    }

    public class RectangleToken : IToken
    {
        UInt16 tokenID = 0;

        // XY coords for the bottom left corner of the rectangle.
        private int x, y;

        // XY values for rounded rectangles. 
        private uint rx, ry;

        // Rectangle width and height dimensions
        private uint width, height;

        public RectangleToken(params int[] vs)
        {
            (x, y) = (vs[0], vs[1]);
            (rx, ry) = (Convert.ToUInt32(vs[2]), Convert.ToUInt32(vs[3]));
            (width, height) = (Convert.ToUInt32(vs[4]), Convert.ToUInt32(vs[5]));
        }

        public Dictionary<string, int> GetNamedParams()
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            keyValuePairs.Add("x", x);
            keyValuePairs.Add("y", y);

            keyValuePairs.Add("rx", Convert.ToInt32(rx));
            keyValuePairs.Add("yx", Convert.ToInt32(ry));

            keyValuePairs.Add("width", Convert.ToInt32(width));
            keyValuePairs.Add("height", Convert.ToInt32(height));

            return keyValuePairs;
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

    public class CircleToken : IToken
    {
        UInt16 tokenID = 1;

        // XY coords for the center of the circle.
        Tuple<int, int> xy { get; set; }

        // Circle radius.
        uint r { get; set; } = 0;

        public CircleToken(params int[] vs)
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