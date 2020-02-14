﻿using PlotlangConverter.TokenDefinitions;
using System;
using System.Linq;
using System.Xml.Linq;

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
                int[] vs = new int[attributes.Length];

                for (int i = 0; i < attributes.Length; i++)
                {
                    vs[i] = int.Parse(attributes[i].Value);
                }


                var obj = factory.CreateToken(element.Name.LocalName, vs);
                TinySvgParser.Parse(obj);
            }

            // TESTING PURPOSES, REMOVE LATER
            //var rectobj = new RectangleToken(new object[] { 0,0,0,0,0,0 });
            //rectobj.setParams(new object[] { 5,10,15,20,25,30 });
            //object[] a = rectobj.getParams();

            //var circleobj = new CircleToken(new object[] { 0, 0, 0 });
            //circleobj.setParams(new object[] { 10, 20, 30 });
            //object[] b = circleobj.getParams();

            throw new NotImplementedException();
        }
    }
}
