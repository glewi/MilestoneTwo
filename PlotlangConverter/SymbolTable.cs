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
        public enum TokenTypes
        {
            Circle,
            Rectangle
        }

        private static Dictionary<uint, Type> symbolMap = new Dictionary<uint, Type>();

        public static IToken GetToken(TokenTypes identifier)
        {
            return (IToken)Activator.CreateInstance(symbolMap[(uint)identifier]);
        }

        public static void AddToken(uint identifier, IToken token)
        {
            symbolMap.Add(identifier, typeof(IToken));
        }

        public static void RemoveToken(uint identifier)
        {
            symbolMap.Remove(identifier);
        }
    }
}