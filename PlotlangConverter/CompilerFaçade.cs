
using PlotlangConverter.SvgFrontend;

namespace PlotlangConverter
{
    static class CompilerFaçade
    {
        public static void Compile(string @input, string @output)
        {
            var prog = TinySvgReader.ReadFile(input);
            var lexemes = TinySvgLexer.Lex(prog);
            TinySvgParser.Parse(lexemes);
        }
    }
}
