using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.IRTools
{
    public class JsonRoot
    {
        public SerialiseObject[] tokenarray { get; set; }
    }

    /// <summary>
    /// A workaround wrapper class for serialising JSON.
    /// </summary>
    public class SerialiseObject
    {
        public byte tokenID { get; set; }
        public Dictionary<string, int> attributes { get; set; }
        public Dictionary<string, int> optionalAttributes { get; set; }
        public Dictionary<string, string> styleAttributes { get; set; }

        //public SerialiseObject(byte tokenID, Dictionary<string, int> attributes)
        //{
        //    this.tokenID = tokenID;
        //    this.attributes = attributes;
        //}
    }
}
