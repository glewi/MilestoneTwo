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

        // Rectangle dimensions.
        uint width { get; set; } = 0;
        uint height { get; set; } = 0;

        // Only used for rounded rectangles.
        uint rx { get; set; } = 0;
        uint ry { get; set; } = 0;
    }

    internal class CircleToken : IToken
    {

    }
}