using Design_Patterns.Entidades.Banco;

namespace Design_Patterns.Business.Investimentos.Interface
{
    public interface IInvestimento
    {
        double Calcular(ContaBancaria contaBancaria);
    }
}
