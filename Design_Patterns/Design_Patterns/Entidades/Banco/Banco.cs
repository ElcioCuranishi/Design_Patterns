using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Entidades.Banco
{
    public class Banco
    {
        public String Nome { get; private set; }

        public List<ContaBancaria> Contas { get; private set; }

        public Banco(String nome)
        {
            this.Nome = nome;
            this.Contas = new List<ContaBancaria>();
        }

        public void AdicionarConta(ContaBancaria conta)
        {
            this.Contas.Add(conta);
        }       
    }
}
