using Design_Patterns.Business.Descontos.Interface;
using Design_Patterns.Entidades.Orcamento;

namespace Design_Patterns.Business.Descontos.Business
{
    public class DescontoPorMaisDeCinco : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;
            else
                return Proximo.Desconto(orcamento);
        }
    }
}
