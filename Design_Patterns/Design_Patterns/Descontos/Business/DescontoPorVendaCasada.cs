using Design_Patterns.Descontos.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Design_Patterns.Descontos.Business
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            List<Item> listaItens = (List<Item>)orcamento.Itens;

            if (listaItens.Exists(x => x.Nome.ToUpper() == "LAPIS")
                && listaItens.Exists(x => x.Nome.ToUpper() == "CANETA"))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Desconto(orcamento);
        }
    }
}
