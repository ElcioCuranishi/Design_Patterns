
using Design_Patterns.Business.Response;
using Design_Patterns.Business.Response.Business;
using Design_Patterns.Business.Response.Interface;
using Design_Patterns.Entidades.Banco;
using System;

namespace Design_Patterns.Business
{
    public class ResponseChain
    {
        public String DadosConta(ContaBancaria conta, RequestDadosConta request)
        {
            IResponse responseXml = new ResponseXml();
            IResponse responseCsv = new ResponseCsv();
            IResponse responsePorcento = new ResponsePorcento();

            responseXml.Proximo = responseCsv;
            responseCsv.Proximo = responsePorcento;
            responsePorcento.Proximo = new ResponseSemFormato();

            return responseXml.Retorno(conta, request);            
        }
    }
}
