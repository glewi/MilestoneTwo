using PlotlangConverter.HpglBackend.TokenDefinitions;
using System;

namespace PlotlangConverter.HpglBackend
{
    public class HpglTokenFactory
    {
        private enum TokenTypes
        {
            Circle = 1,
            Rectangle = 2
        }

        public IHpglToken CreateToken(string identifier, params int[] vs)
        {
            switch (identifier)
            {
                case "circle":
                    return new HpglCircle();
                case "rectangle":
                    return new HpglRectangle();
                default:
                    throw new NotImplementedException();
            }
        }

        public IHpglToken CreateToken(uint identifier, params int[] vs)
        {
            switch (identifier)
            {
                case (uint)TokenTypes.Circle:
                    return new HpglCircle(vs);
                case (uint)TokenTypes.Rectangle:
                    return new HpglRectangle(vs);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
