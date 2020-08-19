using Design_Patterns.Business.Descontos.Interface;
using Design_Patterns.Entidades.Orcamento;

namespace Design_Patterns.Business.Descontos.Business
{
    public class DescontoPorMaisDeQuinhentosReais : AbstractDesconto
    {
        public override double Desconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.00)
                return orcamento.Valor * 0.07;
            else
                return base.Desconto(orcamento);
        }
    }
}
