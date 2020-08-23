using Design_Patterns.Business;
using Design_Patterns.Business.Impostos.Business;
using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Examples
{
    public class ExemploIkcvIcpp
    {
        public ExemploIkcvIcpp()
        {
            IImposto ikcv = new Ikcv();
            IImposto icpp = new Icpp();

            var imposto = new CalculadorDeImpostos();

            var orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Celular", 499.99));

            Console.WriteLine("IKCV sobre " + orcamento.Valor);
            imposto.RealizarCalculo(orcamento, ikcv);
            Console.WriteLine("ICPP sobre " + orcamento.Valor);
            imposto.RealizarCalculo(orcamento, icpp);
            
            orcamento.AdicionarItem(new Item("Película", 0.01));

            Console.WriteLine("IKCV sobre " + orcamento.Valor);
            imposto.RealizarCalculo(orcamento, ikcv);
            Console.WriteLine("ICPP sobre " + orcamento.Valor);
            imposto.RealizarCalculo(orcamento, icpp);

            orcamento.AdicionarItem(new Item("Tablet", 1000.01));

            Console.WriteLine("IKCV sobre " + orcamento.Valor);
            imposto.RealizarCalculo(orcamento, ikcv);
            Console.WriteLine("ICPP sobre " + orcamento.Valor);
            imposto.RealizarCalculo(orcamento, icpp);

        }
    }
}
