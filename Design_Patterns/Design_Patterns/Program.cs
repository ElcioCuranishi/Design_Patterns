using Design_Patterns.Impostos.Business;
using Design_Patterns.Impostos.Interface;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new Iss();
            IImposto icms = new Icms();

            Orcamento orcamento = new Orcamento(500.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizarCalculo(orcamento, icms);
            calculador.RealizarCalculo(orcamento, iss);
        }
    }
}
