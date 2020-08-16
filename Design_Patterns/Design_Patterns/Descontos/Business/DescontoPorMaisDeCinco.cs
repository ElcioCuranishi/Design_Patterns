using Design_Patterns.Descontos.Interface;

namespace Design_Patterns.Descontos.Business
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
