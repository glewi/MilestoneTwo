using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter
{
    public class TokenFactory
    {
        private enum TokenTypes
        {
            Circle,
            Rectangle
        }

        public IToken CreateRectangle()
        {
            return new RectangleToken();
        }

        public IToken CreateToken(uint identifier)
        {
            switch(identifier)
            {
                case (uint)TokenTypes.Circle:
                    return new CircleToken();
                case (uint)TokenTypes.Rectangle:
                    return new RectangleToken();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
