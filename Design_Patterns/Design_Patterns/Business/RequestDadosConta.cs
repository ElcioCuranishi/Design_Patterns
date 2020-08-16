using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Business
{
    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }
    public class RequestDadosConta
    {
        public Formato Formato { get; private set; }

        public RequestDadosConta(Formato formato)
        {
            this.Formato = formato;
        }
    }
}
