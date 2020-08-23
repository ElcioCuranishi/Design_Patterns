using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Business.Impostos.Business    
{
    public class Icpp : AbstractImpostoCondicional
    {
        protected override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double ImpostoMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double ImpostoMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
