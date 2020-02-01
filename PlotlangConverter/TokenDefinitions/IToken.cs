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
        Tuple<int, int> xy { get; set; } = new Tuple<int, int>(0,0);

        // XY values for rounded rectangles. 
        Tuple<uint, uint> rxy { get; set; } = new Tuple<uint, uint>(0, 0);

        // Rectangle width and height dimensions
        Tuple<uint, uint> widthheight { get; set; } = new Tuple<uint, uint>(0,0);
    }

    internal class CircleToken : IToken
    {

    }
}