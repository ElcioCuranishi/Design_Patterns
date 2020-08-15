
namespace Design_Patterns.Descontos.Interface
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }

    }
}
