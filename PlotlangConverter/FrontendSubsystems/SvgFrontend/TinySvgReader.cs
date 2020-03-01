using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PlotlangConverter.FrontendSubsystems.SvgFrontend
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
