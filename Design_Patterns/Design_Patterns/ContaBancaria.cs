using Design_Patterns.Investimentos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    public class ContaBancaria
    {
        public double Saldo { get; private set;}
        
        public ContaBancaria(double Saldo)
        {
            this.Saldo = Saldo;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
