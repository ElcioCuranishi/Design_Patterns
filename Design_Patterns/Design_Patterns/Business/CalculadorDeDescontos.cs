using Design_Patterns.Entidades.Orcamento;
using Design_Patterns.Business.Descontos.Business;
using Design_Patterns.Business.Descontos.Interface;

namespace Design_Patterns.Business
{
    public class CalculadorDeDescontos : AbstractDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            var descontoPorMaisDeCincoUnidades = new DescontoPorMaisDeCinco();
            var descontoPorMaisDeQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
            var descontoPorVendaCasada = new DescontoPorVendaCasada();
            
            descontoPorMaisDeCincoUnidades.
                ProximoDesconto(descontoPorMaisDeQuinhentosReais).
                ProximoDesconto(descontoPorVendaCasada);

            return descontoPorMaisDeCincoUnidades.Desconto(orcamento);
        }

    }
}
