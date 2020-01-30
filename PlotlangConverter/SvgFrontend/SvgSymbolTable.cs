using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.SvgFrontend
{
    static class SvgSymbolTable
    {
        private static Dictionary<string, IToken> symbolMap = new Dictionary<string, IToken>();

        public static IToken GetToken(string identifier)
        {
            throw new NotImplementedException();
        }

        public static void AddToken(string identifier, IToken token)
        {
            throw new NotImplementedException();
        }

        public static void RemoveToken(string identifier)
        {
            throw new NotImplementedException();
        }
    }

    interface IToken
    {

    }

    internal class RectangleToken : IToken
    {

    }
}
