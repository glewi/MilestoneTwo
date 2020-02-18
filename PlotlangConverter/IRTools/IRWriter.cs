using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlotlangConverter.IRTools
{
    public static class IRWriter
    {
        public static void Write(string prog, string @path)
        {
            StreamWriter writer = new StreamWriter(@path);
            writer.Write(prog);
            writer.Close();
        }

    }
}
