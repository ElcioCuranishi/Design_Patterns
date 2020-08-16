using Design_Patterns.Business.Impostos.Business;
using Design_Patterns.Business.Investimentos.Interface;
using Design_Patterns.Entidades.Banco;
using Design_Patterns.Entidades.Orcamento;
using System;

namespace Design_Patterns.Business
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
