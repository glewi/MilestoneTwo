using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlotlangConverter
{
    static class IOHelper
    {
        public static void WriteFile(string @path)
        {
            StreamWriter writer = new StreamWriter(@path);

            

            writer.Close();
        }
    }
}
