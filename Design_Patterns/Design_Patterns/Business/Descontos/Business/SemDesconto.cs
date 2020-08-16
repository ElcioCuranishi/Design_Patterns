using Design_Patterns.Business.Descontos.Interface;
using Design_Patterns.Entidades.Orcamento;

namespace Design_Patterns.Business.Descontos.Business    
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
