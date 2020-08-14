using Design_Patterns.Investimentos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Investimentos.Business
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
