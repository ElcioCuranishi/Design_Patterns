using Design_Patterns.Business.Response.Business;
using Design_Patterns.Business.Response.Interface;
using Design_Patterns.Entidades.Banco;

namespace Design_Patterns.Business.Response
{
    public class ResponsePorcento :AbstractResponse
    {
        public override string Retorno(ContaBancaria conta, RequestDadosConta request)
        {
            if (Formato.PORCENTO.Equals(request.Formato))
            {
                string retorno = "Titular%Saldo";
                retorno += "\n" + conta.Titular + "%" + conta.Saldo;
                return retorno;
            }
            else
                return base.Retorno(conta, request);
        }
    }
}
