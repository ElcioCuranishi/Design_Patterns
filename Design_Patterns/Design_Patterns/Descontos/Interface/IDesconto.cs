
namespace Design_Patterns.Descontos.Interface
{
    public interface IDesconto
    {
        double Desconto(Orcamento orcamento);
        IDesconto Proximo { get; set; }

    }
}
