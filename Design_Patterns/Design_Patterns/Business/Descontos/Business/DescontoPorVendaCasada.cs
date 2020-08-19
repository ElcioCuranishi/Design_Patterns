using Design_Patterns.Business.Descontos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System.Collections.Generic;

namespace Design_Patterns.Business.Descontos.Business
{
    public class DescontoPorVendaCasada : AbstractDesconto
    {
        public override double Desconto(Orcamento orcamento)
        {
            List<Item> listaItens = (List<Item>)orcamento.Itens;

            if (listaItens.Exists(x => x.Nome.ToUpper() == "LAPIS")
                && listaItens.Exists(x => x.Nome.ToUpper() == "CANETA"))
                return orcamento.Valor * 0.05;
            else
                return base.Desconto(orcamento);
        }
    }
}
