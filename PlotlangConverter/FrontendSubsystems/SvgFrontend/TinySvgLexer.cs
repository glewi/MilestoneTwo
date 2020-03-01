using PlotlangConverter.SvgFrontend.TokenDefinitions;
using System;
using System.Linq;
using System.Xml.Linq;

namespace PlotlangConverter.FrontendSubsystems.SvgFrontend
{
    public static class TinySvgLexer
    {
        private static TokenFactory factory = new TokenFactory();

        /// <summary>
        /// Lex an individual <c>XElement</c>.
        /// </summary>
        /// <param name="element">
        /// An XElement retreived from LINQ.
        /// </param>
        /// <returns>
        /// An IToken implementation of the passed element.
        /// </returns>
        public static IToken Lex(XElement element)
        {
            XAttribute[] attributes = element.Attributes().ToArray();
            int[] vs = new int[attributes.Length];


            for (int i = 0; i < attributes.Length; i++)
            {
                vs[i] = int.Parse(attributes[i].Value);
            }

            IToken token = factory.CreateToken(element.Name.LocalName, vs);
            return token;
        }

        /// <summary>
        /// Lex an array of XElements.
        /// </summary>
        /// <param name="elements">
        /// An array of XElement retreived from LINQ.
        /// </param>
        /// <returns>
        /// An IToken array of the passed XElement array.
        /// </returns>
        public static IToken[] Lex(XElement[] elements)
        {
            IToken[] tokens = new IToken[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                XElement element = elements[i];
                Console.WriteLine(element.Name.LocalName);
                XAttribute[] attributes = element.Attributes().ToArray();
                int[] vs = new int[attributes.Length];

                for (int j = 0; j < attributes.Length; j++)
                {
                    vs[j] = int.Parse(attributes[j].Value);
                }

                tokens[i] = factory.CreateToken(element.Name.LocalName, vs);
            }

            return tokens;
        }
    }
}
