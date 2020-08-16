using Design_Patterns.Business.Response.Interface;
using Design_Patterns.Entidades.Banco;

namespace Design_Patterns.Business.Response
{
    public class ResponseCsv : IResponse
    {
        public IResponse Proximo { get; set; }

        public string Retorno(ContaBancaria conta, RequestDadosConta request)
        {
            if (Formato.CSV.Equals(request.Formato))
            {
                string retorno = "Titular;Saldo";
                retorno += "\n" + conta.Titular + ";" + conta.Saldo;
                return retorno;
            }
            else
                return Proximo.Retorno(conta, request);
        }
    }
}
