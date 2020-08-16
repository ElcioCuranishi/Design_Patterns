using Design_Patterns.Entidades.Orcamento;
using Design_Patterns.Business.Impostos.Interface;
using System;

namespace Design_Patterns.Business
{
    public class CalculadorDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(imposto.Nome + ": " + valor);
        }
    }
}
