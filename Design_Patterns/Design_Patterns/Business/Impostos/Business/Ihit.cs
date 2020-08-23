using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Design_Patterns.Business.Impostos.Business
{
    public class Ihit : AbstractImpostoCondicional
    {
        protected override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            List<Item> listaItens = (List<Item>)orcamento.Itens;
            var itensRepetidos = listaItens.GroupBy(item => item.Nome.ToUpper(),
                item => item.Nome,
                (agrupador, item) => new { nome = agrupador,
                    count = item.Count() }).Where(x => x.count > 1);
            if (itensRepetidos.Count() > 0)
                return true;
            return false;
        }

        protected override double ImpostoMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100.00;
        }

        protected override double ImpostoMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
    }
}
