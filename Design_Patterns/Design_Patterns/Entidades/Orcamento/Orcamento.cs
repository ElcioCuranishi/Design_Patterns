using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Entidades.Orcamento
{
    public class Orcamento
    {
        public double Valor { get; private set;}
        public IList<Item> Itens { get; set; }
        
        public Orcamento()
        {
            this.Valor = 0;
            this.Itens = new List<Item>();
        }

        public Orcamento(double valor)
        {
            this.Valor = valor;
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
            this.Valor += item.Valor;
        }

        public void RemoverItem(Item item)
        {
            if (this.Itens.Contains(item))
            {
                this.Itens.Remove(item);
                this.Valor -= item.Valor;
            }
        }
    }
}
