using Design_Patterns.Descontos;
using Design_Patterns.Descontos.Business;
using Design_Patterns.Descontos.Interface;

namespace Design_Patterns.Business
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorMaisDeCinco();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();

            d1.Proximo = d2;
            d2.Proximo = new SemDesconto();

            return d1.Desconta(orcamento);
        }

    }
}
