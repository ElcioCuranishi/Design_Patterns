using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns.Business.Impostos.Business
{
    public class Ikcv : AbstractImpostoCondicional
    {
        protected override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            return ((orcamento.Valor > 500) 
                && PossuiItemAcimaDeCemReais(orcamento.Itens.ToList()));
        }

        protected override double ImpostoMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double ImpostoMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool PossuiItemAcimaDeCemReais(List<Item> itens)
        {
            return itens.Exists(x => x.Valor >= 100.00);
        }
    }
}
