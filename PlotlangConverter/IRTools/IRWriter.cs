using System.IO;
using System.Collections.Generic;

namespace PlotlangConverter.IRTools
{
    public static class IRWriter
    {
        private const string path = @"IR.json";

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

            public SerialiseObject(byte tokenID, Dictionary<string, int> attributes)
            {
                this.tokenID = tokenID;
                this.attributes = attributes;
            }
        }

        private static void ClearFile(string @path)
        {
            File.Delete(@path);
        }
        
        public static void Write(string prog, string @path)
        {
            ClearFile(@path);
            File.WriteAllText(path, prog);
        }

        public static void Write(string[] prog, string @path)
        {
            if (!File.Exists(@path))
            {
                File.WriteAllLines(path, prog);
            }
            File.AppendAllLines(path, prog);

        }
    }
}
