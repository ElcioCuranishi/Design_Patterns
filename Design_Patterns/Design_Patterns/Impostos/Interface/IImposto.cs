using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Impostos.Interface
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
