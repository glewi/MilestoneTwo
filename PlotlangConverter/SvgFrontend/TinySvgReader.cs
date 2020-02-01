using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter.SvgFrontend
{
    public static class TinySvgReader
    {
        public static XElement[] ReadFile(string @path)
        {
            XDocument document = XDocument.Load(@path);
            IEnumerable<XElement> xml =
                from element in document.Root.Descendants()
                select element;

            XElement[] elements = xml.ToArray();
            return elements;
        }
    }
}
