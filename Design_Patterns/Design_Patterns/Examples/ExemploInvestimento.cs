using Design_Patterns.Business;
using Design_Patterns.Investimentos.Business;
using Design_Patterns.Investimentos.Interface;
using System;

namespace Design_Patterns.Examples
{
    public class ExemploInvestimento
    {
        public ExemploInvestimento()
        {
            Console.WriteLine("Exemplo de Investimentos.");

            CalculoDeInvestimento(new Conservador());
            CalculoDeInvestimento(new Moderado());
            CalculoDeInvestimento(new Arrojado());
        }

        static void CalculoDeInvestimento(IInvestimento investimento)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Deposita(5000.00);
            RealizadorDeInvestimentos investidor = new RealizadorDeInvestimentos();

            investidor.RealizaInvestimento(contaBancaria, investimento);
        }
    }
}
