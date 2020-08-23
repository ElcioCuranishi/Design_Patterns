using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Business.Impostos.Business
{
    public abstract class AbstractImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxaMaxima(orcamento))
                return ImpostoMaximo(orcamento);
            return ImpostoMinimo(orcamento);
        }        
        protected abstract bool DeveUsarTaxaMaxima(Orcamento orcamento);
        protected abstract double ImpostoMaximo(Orcamento orcamento);
        protected abstract double ImpostoMinimo(Orcamento orcamento);
    }
}
