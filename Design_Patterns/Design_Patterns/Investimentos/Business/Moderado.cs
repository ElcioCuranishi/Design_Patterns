using Design_Patterns.Investimentos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Investimentos.Business
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
