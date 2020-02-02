using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.TokenDefinitions
{

    public interface IToken
    {
        object[] getParams();
        void setParams(params object[] vs);
    }

    public class RectangleToken : IToken
    {
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

        public object[] getParams()
        {
            xy.Deconstruct(out int x, out int y);
            rxy.Deconstruct(out uint rx, out uint ry);
            widthheight.Deconstruct(out uint width, out uint height);

            return new object[] {x,y,rx,ry,width,height};
        }
        
        public void setParams(params object[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            (uint rx, uint ry) = (Convert.ToUInt32(vs[2]), Convert.ToUInt32(vs[3]));
            (uint width, uint height) = (Convert.ToUInt32(vs[4]), Convert.ToUInt32(vs[5]));

            xy = new Tuple<int, int>(x,y);
            rxy = new Tuple<uint, uint>(rx,ry);
            widthheight = new Tuple<uint, uint>(width,height);
        }
    }

    public class CircleToken : IToken
    {
        // XY coords for the center of the circle.
        Tuple<int, int> xy { get; set; }

        // Circle radius.
        uint r { get; set; } = 0;

        public CircleToken(params object[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            uint r = Convert.ToUInt32(vs[0]);
        }

        public object[] getParams()
        {
            xy.Deconstruct(out int x, out int y);
            uint r = this.r;

            return new object[] { x, y, r};
        }

        public void setParams(params object[] vs)
        {
            (int x, int y) = ((int)vs[0], (int)vs[1]);
            uint r = Convert.ToUInt32(vs[2]);

            xy = new Tuple<int, int>(x, y);
            this.r = r;
        }
    }
}