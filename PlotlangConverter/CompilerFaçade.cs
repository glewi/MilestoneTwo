using PlotlangConverter.FrontendSubsystems.SvgFrontend;
using PlotlangConverter.BackendSubsystem.HpglBackend;
using PlotlangConverter.IRTools;
namespace PlotlangConverter
{
    static class CompilerFaçade
    {
        public static void Compile(string @input, string @output)
        {
            var prog = TinySvgReader.ReadFile(input);
            var lexemes = TinySvgLexer.Lex(prog);
            TinySvgParser.Parse(lexemes);

            JsonRoot s = IRReader.Read();
        }
    }
}
