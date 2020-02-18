using System.IO;

namespace PlotlangConverter.IRTools
{
    public static class IRReader
    {
        public static string Read()
        {
            StreamReader reader = new StreamReader(@"test.txt");
            var prog = reader.ReadToEnd();
            reader.Close();
            return prog;
        }
    }
}
