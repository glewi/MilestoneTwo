using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlotlangConverter.SvgFrontend
{
    class SvgReader
    {
        public static void ReadFile(string @path)
        {
            string statement = null;
            
            XDocument document = XDocument.Load(@path);
            IEnumerable<XElement> xml =
                from element in document.Root.Descendants()
                select element;

            foreach (XElement element in xml)
            {
                statement = element.ToString();
                IToken token = SvgLexer.Lex(statement);
                SvgParser.Parse(token);
            }
        }
    }
}
