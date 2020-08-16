using Design_Patterns.Descontos;
using Design_Patterns.Descontos.Business;
using Design_Patterns.Descontos.Interface;

namespace Design_Patterns.Business
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto descontoPorMaisDeCincoUnidades = new DescontoPorMaisDeCinco();
            IDesconto descontoPorMaisDeQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
            IDesconto descontoPorVendaCasada = new DescontoPorVendaCasada();
            
            descontoPorMaisDeCincoUnidades.Proximo = descontoPorMaisDeQuinhentosReais;
            descontoPorMaisDeQuinhentosReais.Proximo = descontoPorVendaCasada;
            descontoPorVendaCasada.Proximo = new SemDesconto();

            return descontoPorMaisDeCincoUnidades.Desconto(orcamento);
        }

    }
}
