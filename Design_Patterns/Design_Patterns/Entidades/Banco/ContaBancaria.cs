using System;

namespace Design_Patterns.Entidades.Banco
{
    public class ContaBancaria
    {
        public String Titular { get; private set; }
        public double Saldo { get; private set;}
        
        public ContaBancaria(String nomeTitular, double Saldo = 0)
        {
            this.Titular = nomeTitular;
            this.Saldo = Saldo;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
