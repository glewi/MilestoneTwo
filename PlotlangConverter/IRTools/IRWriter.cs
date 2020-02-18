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
