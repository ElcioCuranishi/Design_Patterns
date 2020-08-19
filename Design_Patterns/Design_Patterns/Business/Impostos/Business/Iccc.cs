using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;

namespace Design_Patterns.Business.Impostos.Business
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
