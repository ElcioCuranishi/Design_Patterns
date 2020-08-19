using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Business.Impostos.Business    
{
    public class ICPP : AbstractImpostoCondicional
    {
        public override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double ImpostoMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double ImpostoMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
