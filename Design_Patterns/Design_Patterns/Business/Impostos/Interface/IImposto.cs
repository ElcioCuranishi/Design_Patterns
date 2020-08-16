using Design_Patterns.Entidades.Orcamento;
using System;

namespace Design_Patterns.Business.Impostos.Interface
{
    public interface IImposto
    {
        String Nome { get; }
        double Calcula(Orcamento orcamento);
    }
}
