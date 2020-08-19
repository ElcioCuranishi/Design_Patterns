using Design_Patterns.Entidades.Banco;
using Design_Patterns.Business.Response.Interface;

namespace Design_Patterns.Business.Response.Business
{
    public class ResponseXml : AbstractResponse
    {
        public override string Retorno(ContaBancaria conta, RequestDadosConta request)
        {
            if (Formato.XML.Equals(request.Formato))
            {
                string retornoXml = "<Titular>" + conta.Titular + @"</Titular>";
                retornoXml += "\n<Saldo>" + conta.Saldo + "</Saldo>";
                return retornoXml;
            }
            else
                return base.Retorno(conta, request);
        }
    }
}
