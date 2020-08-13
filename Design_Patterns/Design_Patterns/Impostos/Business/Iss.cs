﻿using Design_Patterns.Impostos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Impostos.Business
{
    public class Iss : IImposto
    {
        double IImposto.Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
