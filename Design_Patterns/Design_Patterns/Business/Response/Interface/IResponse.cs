using Design_Patterns.Entidades.Banco;
using System;

namespace Design_Patterns.Business.Response.Interface
{
    public interface IResponse
    {
        IResponse Proximo { get; set; }
        String Retorno(ContaBancaria conta, RequestDadosConta request);
    }
}
