using Design_Patterns.Impostos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Impostos.Business
{
    class ImpostoSobreInvestimento : IImposto
    {
        public String Nome { get { return "Imposto sobre Investimento"; } }
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.25;
        }
    }
}
