using Design_Patterns.Impostos.Business;
using Design_Patterns.Impostos.Interface;
using Design_Patterns.Investimentos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria contaBancaria, IInvestimento investimento)
        {
            double resultadoInvestimento = investimento.Calcular(contaBancaria);
            Console.WriteLine("Retorno do investimento: " + resultadoInvestimento);
            double imposto = new ImpostoSobreInvestimento().Calcula(new Orcamento(resultadoInvestimento));
            Console.WriteLine("Imposto sobre o investimento: " + imposto);
            contaBancaria.Deposita(resultadoInvestimento - imposto);
            Console.WriteLine("Novo Saldo: " + contaBancaria.Saldo);
        }
    }
}
