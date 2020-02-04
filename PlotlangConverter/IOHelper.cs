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
