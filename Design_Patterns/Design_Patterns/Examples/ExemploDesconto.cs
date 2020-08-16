using Design_Patterns.Business;
using Design_Patterns.Entidades.Orcamento;
using System;

namespace Design_Patterns.Examples
{
    public class ExemploDesconto
    {
        public ExemploDesconto()
        {
            Console.WriteLine("Exemplo de Desconto.");

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Borracha", 5.00));
            orcamento.AdicionarItem(new Item("Caneta", 2.00));
            orcamento.AdicionarItem(new Item("Lapiseira", 2.00));
            orcamento.AdicionarItem(new Item("Lapis", 1.00));

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Console.WriteLine("Total: " + orcamento.Valor);
            Console.WriteLine("Desconto: " + calculador.Calcula(orcamento));
        }
    }
}
