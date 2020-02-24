﻿using System;
using System.Collections.Generic;

namespace PlotlangConverter.SvgFrontend.TokenDefinitions
{
    public interface IToken
    {
        UInt16 GetID();
        Dictionary<string, int> GetNamedParams();
        int[] GetParams();
        void SetParams(params int[] parameters);
    }
}