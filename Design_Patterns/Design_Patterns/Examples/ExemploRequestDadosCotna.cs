using Design_Patterns.Business;
using Design_Patterns.Business.Response.Interface;
using Design_Patterns.Entidades.Banco;
using System;

namespace Design_Patterns.Examples
{
    public class ExemploRequestDadosCotna
    {
        public ExemploRequestDadosCotna()
        {
            Console.WriteLine("Exemplo de requisição de dados.");
            ContaBancaria conta = new ContaBancaria("Elcio", 15000.00);
            ResponseChain requestDadosConta = new ResponseChain();
            Console.WriteLine("\n XML \n" + requestDadosConta.DadosConta(conta, new RequestDadosConta(Formato.XML)));
            Console.WriteLine("\n CSV \n" + requestDadosConta.DadosConta(conta, new RequestDadosConta(Formato.CSV)));
            Console.WriteLine("\n Por cento \n" + requestDadosConta.DadosConta(conta, new RequestDadosConta(Formato.PORCENTO)));
        }
    }
}
