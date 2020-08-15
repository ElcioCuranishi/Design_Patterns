using Design_Patterns.Descontos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Descontos.Business
{
    public class DescontoPorMaisDeCinco : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;
            else
                return Proximo.Desconta(orcamento);
        }
    }
}
