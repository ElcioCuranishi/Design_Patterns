using Design_Patterns.Business.Response.Interface;
using Design_Patterns.Entidades.Banco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Business.Response.Business
{
    public class ResponseSemFormato : IResponse
    {
        public IResponse Proximo { get; set; }

        public string Retorno(ContaBancaria conta, RequestDadosConta request)
        {
            return "Sem formato definido.";
        }
    }
}
