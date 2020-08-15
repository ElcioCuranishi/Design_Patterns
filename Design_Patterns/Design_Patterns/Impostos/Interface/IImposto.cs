using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Impostos.Interface
{
    public interface IImposto
    {
        String Nome { get; }
        double Calcula(Orcamento orcamento);
    }
}
