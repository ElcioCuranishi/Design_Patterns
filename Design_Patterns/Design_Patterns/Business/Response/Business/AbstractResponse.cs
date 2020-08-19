using Design_Patterns.Business.Response.Interface;
using Design_Patterns.Entidades.Banco;

namespace Design_Patterns.Business.Response.Business
{
    public abstract class AbstractResponse : IResponse
    {
        private IResponse _proximo;

        public IResponse SetProximo(IResponse proximo)
        {
            this._proximo = proximo;
            return proximo;
        }
        public virtual string Retorno(ContaBancaria conta, RequestDadosConta request)
        {
            if (this._proximo != null)
                return this._proximo.Retorno(conta, request);
            else
                return "Formato desconhecido.";
        }

    }
}
