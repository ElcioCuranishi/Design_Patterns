using Design_Patterns.Entidades.Orcamento;
using Design_Patterns.Business.Descontos.Business;
using Design_Patterns.Business.Descontos.Interface;

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
