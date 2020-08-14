using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Investimentos.Interface
{
    public interface IInvestimento
    {
        double Calcular(ContaBancaria contaBancaria);
    }
}
