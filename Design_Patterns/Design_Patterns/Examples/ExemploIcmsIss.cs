using Design_Patterns.Business;
using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Business.Impostos.Business;
using Design_Patterns.Entidades.Orcamento;

using System;

namespace Design_Patterns.Examples
{
    public class ExemploIcmsIss
    {
        public ExemploIcmsIss()
        {
            Console.WriteLine("Exemplo de ICMS e ISS");

            IImposto icms = new Icms();
            IImposto iss = new Iss();

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Microondas", 500.00));

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizarCalculo(orcamento, icms);
            calculador.RealizarCalculo(orcamento, iss);
        }
    }
}
