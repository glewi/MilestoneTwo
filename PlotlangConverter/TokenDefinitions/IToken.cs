using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.TokenDefinitions
{

    public interface IToken
    {

    }

    internal class RectangleToken : IToken
    {
        // XY coords for the bottom left corner of the rectangle.
        Tuple<int, int> xy { get; } = new Tuple<int, int>(0,0);

        // XY values for rounded rectangles. 
        Tuple<uint, uint> rxy { get; } = new Tuple<uint, uint>(0, 0);

        // Rectangle width and height dimensions
        Tuple<uint, uint> widthheight { get; } = new Tuple<uint, uint>(0,0);
    }

    internal class CircleToken : IToken
    {
        // XY coords for the center of the circle.
        public Tuple<int, int> xy { get; } = new Tuple<int, int>(0,0);

        // Circle radius.
        public uint r { get; } = 0;
    }
}