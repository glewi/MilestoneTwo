using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter.SvgFrontend
{
    static class SymbolTable
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
}