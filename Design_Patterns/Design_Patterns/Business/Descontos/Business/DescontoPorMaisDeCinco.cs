using Design_Patterns.Business.Descontos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System.Collections.Generic;

namespace Design_Patterns.Business.Descontos.Business
{
    public class DescontoPorMaisDeCinco : AbstractDesconto
    {
        public override double Desconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;
            else
                return base.Desconto(orcamento);
        }
    }
}
