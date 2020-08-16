using Design_Patterns.Descontos.Interface;

namespace Design_Patterns.Descontos.Business
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.00)
                return orcamento.Valor * 0.07;
            else
                return Proximo.Desconto(orcamento);
        }
    }
}
