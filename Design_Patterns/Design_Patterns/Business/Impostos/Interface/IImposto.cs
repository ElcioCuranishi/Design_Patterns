using Design_Patterns.Entidades.Orcamento;
using System;

namespace Design_Patterns.Business.Impostos.Interface
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
