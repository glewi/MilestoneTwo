using PlotlangConverter.TokenDefinitions;
using System;

namespace PlotlangConverter
{
    public class TokenFactory
    {
        private enum TokenTypes
        {
            Circle = 1,
            Rectangle = 2
        }

        public IToken CreateToken(string identifier, params int[] vs)
        {
            switch (identifier)
            {
                case "circle":
                    return new CircleToken(vs);
                case "rect":
                    return new RectangleToken(vs);
                default:
                    throw new NotImplementedException();
            }
        }

        public IToken CreateToken(uint identifier, params int[] vs)
        {
            switch (identifier)
            {
                case (uint)TokenTypes.Circle:
                    return new CircleToken(vs);
                case (uint)TokenTypes.Rectangle:
                    return new RectangleToken(vs);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
