using Design_Patterns.Entidades.Orcamento;

namespace Design_Patterns.Business.Descontos.Interface
{
    public interface IDesconto
    {
        double Desconto(Orcamento orcamento);
        IDesconto Proximo { get; set; }

    }
}
