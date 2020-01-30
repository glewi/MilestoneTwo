using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.SvgFrontend
{
    class SvgSymbolTable
    {
        private Dictionary<string, IToken> symbolMap = new Dictionary<string, IToken>();

        public IToken GetToken(string identifier)
        {
            throw new NotImplementedException();
        }

        public void AddToken(string identifier, IToken token)
        {
            throw new NotImplementedException();
        }

        public void RemoveToken(string identifier)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IToken
    {

    }

    internal class RectangleToken : IToken
    {

    }
}
