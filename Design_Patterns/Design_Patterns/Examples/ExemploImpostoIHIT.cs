using Design_Patterns.Business;
using Design_Patterns.Business.Impostos.Business;
using Design_Patterns.Business.Impostos.Interface;
using Design_Patterns.Entidades.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Examples
{
    public class ExemploImpostoIHIT
    {
        public ExemploImpostoIHIT()
        {
            IImposto ihit = new Ihit();
            var orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Caneta Azul", 2));
            orcamento.AdicionarItem(new Item("Borracha", 1));
            orcamento.AdicionarItem(new Item("Caneta", 2));
            var calculador = new CalculadorDeImpostos();
            calculador.RealizarCalculo(orcamento, ihit);
            orcamento.AdicionarItem(new Item("Caneta Azul", 2));
            calculador.RealizarCalculo(orcamento, ihit);

        }
    }
}
