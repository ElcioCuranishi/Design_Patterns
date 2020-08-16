using Design_Patterns.Business.Investimentos.Interface;
using Design_Patterns.Entidades.Banco;

namespace Design_Patterns.Business.Investimentos.Business
{
    public class Conservador : IInvestimento
    {
        //Fixo em 8%
        public double Calcular(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.008;
        }
    }
}
