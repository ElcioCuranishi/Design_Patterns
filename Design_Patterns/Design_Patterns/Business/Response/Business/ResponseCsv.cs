using Design_Patterns.Entidades.Banco;

namespace Design_Patterns.Business.Response.Business
{
    public class ResponseCsv : AbstractResponse
    {
        public override string Retorno(ContaBancaria conta, RequestDadosConta request)
        {
            if (Formato.CSV.Equals(request.Formato))
            {
                string retorno = "Titular;Saldo";
                retorno += "\n" + conta.Titular + ";" + conta.Saldo;
                return retorno;
            }
            else
                return base.Retorno(conta, request);
        }
    }
}
