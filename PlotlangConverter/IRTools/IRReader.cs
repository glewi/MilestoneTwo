using System.IO;

namespace PlotlangConverter.IRTools
{
    public static class IRReader
    {
        static string filepath = @"test.txt";

        public static string Read()
        {
            StreamReader reader = new StreamReader(filepath);

            var prog = reader.ReadToEnd();
            reader.Close();
            return prog;
        }
    }
}
