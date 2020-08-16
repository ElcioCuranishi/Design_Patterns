using Design_Patterns.Business;
using Design_Patterns.Business.Impostos.Business;
using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;

namespace Design_Patterns.Examples
{
    class ExemploIccc
    {
        public ExemploIccc()
        {
            Console.WriteLine("Exemplo de imposto ICCC.");
            IImposto iccc = new Iccc();

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            Orcamento orcamento = new Orcamento();
            
            orcamento.AdicionarItem(new Item("Televisor", 999.99));
            calculador.RealizarCalculo(orcamento, iccc);

            orcamento.AdicionarItem(new Item("Plug", 0.01));
            calculador.RealizarCalculo(orcamento, iccc);

            orcamento.AdicionarItem(new Item("Xbox", 2000.00));
            calculador.RealizarCalculo(orcamento, iccc);

            orcamento.AdicionarItem(new Item("Plug", 0.01));
            calculador.RealizarCalculo(orcamento, iccc);
        }
    }
}
