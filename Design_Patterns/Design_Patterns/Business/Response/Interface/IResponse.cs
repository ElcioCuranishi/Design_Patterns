using Design_Patterns.Entidades.Banco;
using System;

namespace Design_Patterns.Business.Response.Interface
{
    public interface IResponse
    {
        IResponse SetProximo(IResponse proximo);
        String Retorno(ContaBancaria conta, RequestDadosConta request);
    }
}
