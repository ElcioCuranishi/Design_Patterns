using Design_Patterns.Impostos.Business;
using Design_Patterns.Impostos.Interface;
using Design_Patterns.Investimentos.Business;
using Design_Patterns.Investimentos.Interface;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestesInvestimento();
        }

        #region TestesInvestimento
        static void TestesInvestimento()
        {
            TesteInvestimento(new Conservador());
            TesteInvestimento(new Moderado());
            TesteInvestimento(new Arrojado());
        }

        static void TesteInvestimento(IInvestimento investimento)
        {
            ContaBancaria contaBancaria = new ContaBancaria(5000.00);
            RealizadorDeInvestimentos investidor = new RealizadorDeInvestimentos();

            investidor.RealizaInvestimento(contaBancaria, investimento);        
        }
        #endregion

        #region TesteICCC
        static void TestesIcc()
        {
            TesteIcc(999.99);
            TesteIcc(1000.00);
            TesteIcc(9000.00);
            TesteIcc(9000.91);
        }

        static void TesteIcc(double valor)
        {
            IImposto iccc = new Iccc();

            Orcamento orcamento = new Orcamento(valor);
           
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizarCalculo(orcamento, iccc);
        }
        #endregion

        #region TesteImpostos
        static void TesteIcmsIss()
        {
            IImposto icms = new Icms();
            IImposto iss = new Iss();

            Orcamento orcamento = new Orcamento(500.00);
            
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizarCalculo(orcamento, icms);
            calculador.RealizarCalculo(orcamento, iss);

        }
        #endregion
    }
}
