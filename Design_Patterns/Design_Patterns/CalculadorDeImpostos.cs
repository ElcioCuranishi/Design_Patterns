using Design_Patterns.Impostos;
using Design_Patterns.Impostos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    public class CalculadorDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
