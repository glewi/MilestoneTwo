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
    public static class SvgReader
    {
        // Adding this as an experiment.
        public static void ReadFileSerializer(string @path)
        {

        }
        
        public static List<XElement> ReadFileLINQ(string @path)
        {
            XDocument document = XDocument.Load(@path);
            IEnumerable<XElement> xml =
                from element in document.Root.Descendants()
                select element;

            List<XElement> list = new List<XElement>();

            foreach (XElement element in xml)
            {
                list.Add(element);
            }

            return list;
        }
    }
}
