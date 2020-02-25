using System.IO;

namespace PlotlangConverter.IRTools
{
    public static class IRWriter
    {
        public static void Write(string prog, string @path)
        {
            if (!File.Exists(@path))
            {
                File.WriteAllText(path, prog);
            }
            else
            {
                File.AppendAllText(path, prog);
            }
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
