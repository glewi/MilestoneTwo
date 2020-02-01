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
        public static List<XElement> ReadFile(string @path)
        {
            XDocument document = XDocument.Load(@path);
            IEnumerable<XElement> xml =
                from element in document.Root.Descendants()
                select element;

            List<XElement> list = new List<XElement>(xml);

            foreach(XElement e in list)
            {
                Console.WriteLine(e.Name.LocalName);
            }

            var a = xml.Attributes();
            var array = a.ToArray();

            foreach (XAttribute attribute in array)
            {
                Console.WriteLine(attribute);
                Console.WriteLine(attribute.Value);
                Console.WriteLine(attribute.Name);
            }

            foreach (XElement element in xml)
            {
                list.Add(element);
            }

            return list;
        }
    }
}
