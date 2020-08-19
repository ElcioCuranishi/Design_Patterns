using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns.Business.Impostos.Business
{
    public class IKCV : AbstractImpostoCondicional
    {
        public override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            return ((orcamento.Valor > 500) 
                && PossuiItemAcimaDeMilReais(orcamento.Itens.ToList()));
        }

        public override double ImpostoMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double ImpostoMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool PossuiItemAcimaDeMilReais(List<Item> itens)
        {
            return itens.Exists(x => x.Valor >= 1000);
        }
    }
}
