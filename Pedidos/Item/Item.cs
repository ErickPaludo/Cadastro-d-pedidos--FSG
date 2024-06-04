using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Item
    {
        private string nome_item;
        private double preco_item;
        public string Nome_item { get { return nome_item; } set { nome_item = value; } }
        public double Preco_item { get { return preco_item; } set { preco_item = value; } }

        static Dictionary<int, Item> dItens = new Dictionary<int, Item>();
        public Dictionary<int, Item> Ditens { get { return dItens; } }
        public Item()
        {
        }
        public Item(string nome_item, double preco_item)
        {
            this.nome_item = nome_item;
            this.preco_item = preco_item;
        }
    }
}
