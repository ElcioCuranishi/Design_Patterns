using Design_Patterns.Business.Investimentos.Interface;
using Design_Patterns.Entidades.Banco;
using System;

namespace Design_Patterns.Business.Investimentos.Business
{
    public class Moderado : IInvestimento
    {
        //50% de chances de retornar 2.5%
        //e 50% de chances de retornar 0.7%;
        public double Calcular(ContaBancaria contaBancaria)
        {
            int chance = new Random().Next(1, 2);
            switch (chance)
            {
                case 1:
                    return contaBancaria.Saldo * 0.025;
                default: 
                    return contaBancaria.Saldo * 0.007;
            }
        }
    }
}
