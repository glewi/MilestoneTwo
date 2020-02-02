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
        Tuple<int, int> xy { get; }

        // XY values for rounded rectangles. 
        Tuple<uint, uint> rxy { get; }

        // Rectangle width and height dimensions
        Tuple<uint, uint> widthheight { get; }

        public RectangleToken(int x, int y, uint rx, uint ry, uint width, uint height)
        {
            xy = new Tuple<int, int>(x, y);
            rxy = new Tuple<uint, uint>(rx, ry);
            widthheight = new Tuple<uint, uint>(width, height);
        }

        object[] getParams()
        {
            return null;
        }
        
        void setParams(params object[] vs)
        {

        }
    }

    public class CircleToken : IToken
    {
        // XY coords for the center of the circle.
        public Tuple<int, int> xy { get; } = new Tuple<int, int>(0,0);

        // Circle radius.
        public uint r { get; } = 0;

        object[] getParams()
        {
            return null;
        }

        void setParams(params object[] vs)
        {

        }
    }
}