using Design_Patterns.Business.Descontos.Interface;
using Design_Patterns.Business.Response.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;
using System.Net;

namespace Design_Patterns.Business.Descontos.Business    
{
    public abstract class AbstractDesconto : IDesconto
    {
        private IDesconto _proximo;

        public IDesconto ProximoDesconto(IDesconto proximo)
        {
            this._proximo = proximo;
            return proximo;
        }

        public virtual double Desconto(Orcamento orcamento)
        {
            if (this._proximo != null)
                return this._proximo.Desconto(orcamento);
            else
                return 0;
        }
    }
}
