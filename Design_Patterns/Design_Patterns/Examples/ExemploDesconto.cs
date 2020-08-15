using Design_Patterns.Business;
using Design_Patterns;
using System;

namespace Design_Patterns.Examples
{
    public class ExemploDesconto
    {
        public ExemploDesconto()
        {
            Console.WriteLine("Exemplo de Desconto.");

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Item 1", 100.00));
            orcamento.AdicionarItem(new Item("Item 2", 100.00));
            orcamento.AdicionarItem(new Item("Item 3", 100.00));
            orcamento.AdicionarItem(new Item("Item 4", 100.00));
            orcamento.AdicionarItem(new Item("Item 5", 50.00));
            orcamento.AdicionarItem(new Item("Item 6", 50.00));

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Console.WriteLine("Total: " + orcamento.Valor);
            Console.WriteLine("Desconto: " + calculador.Calcula(orcamento));
        }

    }
}
