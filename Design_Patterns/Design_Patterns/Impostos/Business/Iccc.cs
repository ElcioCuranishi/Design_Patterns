using Design_Patterns.Impostos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Impostos.Business
{
    public class Iccc : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double retorno = 0;
            if (orcamento.Valor < 1000)
                retorno = orcamento.Valor * 0.05;
            else if (orcamento.Valor <= 3000)
                retorno = orcamento.Valor * 0.07;
            else
                retorno = (orcamento.Valor * 0.08) + 30.00;

            return retorno;
        }
    }
}
