﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter.SvgFrontend
{
    public static class TinySvgLexer
    {
        private static TokenFactory factory = new TokenFactory();
        

        public static IToken Lex(XElement element)
        {
            throw new NotImplementedException();
        }
        
        public static IToken Lex(XElement[] prog)
        {
            foreach (XElement element in prog)
            {
                Console.WriteLine(element.Name.LocalName);
                XAttribute[] attributes = element.Attributes().ToArray();




                foreach(XAttribute attribute in attributes)
                {
                    Console.WriteLine(attribute.ToString());
                }
            }

            var obj = new RectangleToken(new object[] { 0,0,0,0,0,0 });
            obj.setParams(new object[] { 5,10,15,20,25,30 });
            object[] p = obj.getParams();
            Console.WriteLine(p.ToString());

            throw new NotImplementedException();
        }
    }
}
