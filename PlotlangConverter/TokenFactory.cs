﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlotlangConverter.TokenDefinitions;

namespace PlotlangConverter
{
    public class TokenFactory
    {
        public IToken CreateToken(string identifier)
        {
            switch(identifier)
            {
                default:
                    throw new NotImplementedException();
            }
        }
    }
}