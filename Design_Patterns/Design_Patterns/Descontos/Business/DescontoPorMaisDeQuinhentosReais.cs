using Design_Patterns.Descontos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Descontos.Business
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.00)
                return orcamento.Valor * 0.07;
            else
                return Proximo.Desconta(orcamento);
        }
    }
}
