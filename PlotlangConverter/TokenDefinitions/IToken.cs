using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.TokenDefinitions
{

    public interface IToken
    {
        void SetParams(params object[] parameterarray);
    }

    internal class RectangleToken : IToken
    {
        // XY coords for the bottom left corner of the rectangle.
        public Tuple<int, int> xy { get; set; } = new Tuple<int, int>(0,0);

        // XY values for rounded rectangles. 
        public Tuple<uint, uint> rxy { get; set; } = new Tuple<uint, uint>(0, 0);

        // Rectangle width and height dimensions
        public Tuple<uint, uint> widthheight { get; set; } = new Tuple<uint, uint>(0,0);

        public void SetParams(params object[] array)
        {
            array
        }
    }

    internal class CircleToken : IToken
    {
        // XY coords for the center of the circle.
        public Tuple<int, int> xy { get; set; } = new Tuple<int, int>(0,0);

        // Circle radius.
        public uint r { get; set; } = 0;

        public void SetParams(params object[] array)
        {
            array
        }
    }
}