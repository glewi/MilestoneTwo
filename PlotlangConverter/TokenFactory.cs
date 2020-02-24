using PlotlangConverter.SvgFrontend.TokenDefinitions;
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
                    return new SvgCircle(vs);
                case "rect":
                    return new SvgRectangle(vs);
                default:
                    throw new NotImplementedException();
            }
        }

        public IToken CreateToken(uint identifier, params int[] vs)
        {
            switch (identifier)
            {
                case (uint)TokenTypes.Circle:
                    return new SvgCircle(vs);
                case (uint)TokenTypes.Rectangle:
                    return new SvgRectangle(vs);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
