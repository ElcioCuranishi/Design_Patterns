using Design_Patterns.Entidades.Orcamento;

namespace Design_Patterns.Business.Descontos.Interface
{
    public interface IDesconto
    {
        IDesconto ProximoDesconto(IDesconto proximo);
        double Desconto(Orcamento orcamento);

    }
}
