
using PlotlangConverter.SvgFrontend;

namespace PlotlangConverter
{
    static class CompilerFaçade
    {
        private static TinySvgFrontendFaçade svg = new TinySvgFrontendFaçade();

        public static void Compile(string @input, string @output)
        {
            var prog = TinySvgReader.ReadFile(input);
            TinySvgLexer.Lex(prog);
            TokenFactory factory = new TokenFactory();
            var obj = factory.CreateToken("rect", new object[] { 10, 20, 30, 40, 50, 60 });
            TinySvgParser.Parse(obj);
        }
    }
}
