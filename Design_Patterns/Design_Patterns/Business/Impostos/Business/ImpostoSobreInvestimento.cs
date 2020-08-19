using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;

namespace Design_Patterns.Business.Impostos.Business
{
    class ImpostoSobreInvestimento : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.25;
        }
    }
}
