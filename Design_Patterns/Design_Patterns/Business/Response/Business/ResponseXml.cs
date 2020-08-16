using Design_Patterns.Entidades.Banco;
using Design_Patterns.Business.Response.Interface;

namespace Design_Patterns.Business.Response.Business
{
    public class ResponseXml : IResponse
    {
        public IResponse Proximo { get; set; }

        public string Retorno(ContaBancaria conta, RequestDadosConta request)
        {
            if (Formato.XML.Equals(request.Formato))
            {
                string retornoXml = "<Titular>" + conta.Titular + @"</Titular>";
                retornoXml += "\n<Saldo>" + conta.Saldo + "</Saldo>";
                return retornoXml;
            }
            else
                return Proximo.Retorno(conta, request);
        }
    }
}
