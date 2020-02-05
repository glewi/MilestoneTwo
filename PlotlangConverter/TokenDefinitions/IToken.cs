using System;

namespace PlotlangConverter.TokenDefinitions
{
    public interface IToken
    {
        uint GetTokenID();
        object[] GetParams();
        void SetParams(params object[] vs);
    }

    public class RectangleToken : IToken
    {
        // Use this for JSON serialisation/deserialisation as a conesquence of
        // polymorphic support not being present in System.Text.Json.
        private const UInt16 TokenID = 0;

        // XY coords for the bottom left corner of the rectangle.
        Tuple<int, int> xy { get; set; }

        // XY values for rounded rectangles. 
        Tuple<uint, uint> rxy { get; set; }

        // Rectangle width and height dimensions
        Tuple<uint, uint> widthheight { get; set; }

        public RectangleToken(params object[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            (uint rx, uint ry) = (Convert.ToUInt32(vs[2]), Convert.ToUInt32(vs[3]));
            (uint width, uint height) = (Convert.ToUInt32(vs[4]), Convert.ToUInt32(vs[5]));

            xy = new Tuple<int, int>(x, y);
            rxy = new Tuple<uint, uint>(rx, ry);
            widthheight = new Tuple<uint, uint>(width, height);
        }

        public uint GetTokenID()
        {
            return TokenID;
        }

        public object[] GetParams()
        {
            xy.Deconstruct(out int x, out int y);
            rxy.Deconstruct(out uint rx, out uint ry);
            widthheight.Deconstruct(out uint width, out uint height);

            return new object[] { x, y, rx, ry, width, height };
        }

        public void SetParams(params object[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            (uint rx, uint ry) = (Convert.ToUInt32(vs[2]), Convert.ToUInt32(vs[3]));
            (uint width, uint height) = (Convert.ToUInt32(vs[4]), Convert.ToUInt32(vs[5]));

            xy = new Tuple<int, int>(x, y);
            rxy = new Tuple<uint, uint>(rx, ry);
            widthheight = new Tuple<uint, uint>(width, height);
        }
    }

    public class CircleToken : IToken
    {
        // Use this for JSON serialisation/deserialisation as a conesquence of
        // polymorphic support not being present in System.Text.Json.
        private const UInt16 TokenID = 1;

        // XY coords for the center of the circle.
        Tuple<int, int> xy { get; set; }

        // Circle radius.
        uint r { get; set; } = 0;

        public CircleToken(params object[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            uint r = Convert.ToUInt32(vs[0]);
        }

        public object[] GetParams()
        {
            xy.Deconstruct(out int x, out int y);
            uint r = this.r;

            return new object[] { x, y, r };
        }

        public void SetParams(params object[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            uint r = Convert.ToUInt32(vs[2]);

            xy = new Tuple<int, int>(x, y);
            this.r = r;
        }

        public uint GetTokenID()
        {
            return TokenID;
        }
    }
}