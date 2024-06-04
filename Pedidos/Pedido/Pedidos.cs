using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topics.Radical.Conversions;

namespace Pedidos
{
    public class Pedidos
    {
        private int id_client;
        private int slot_1, slot_2, slot_3, slot_4, slot_5;
        private int quantidade, quantidade_2, quantidade_3, quantidade_4, quantidade_5;

        public int Slot_1
        {
            get
            {
                return slot_1;
            }
            set
            {
                slot_1 = value;
            }
        }
        public int Slot_2
        {
            get
            {
                return slot_2;
            }
            set
            {
                slot_2 = value;
            }
        }
        public int Slot_3
        {
            get
            {
                return slot_3;
            }
            set
            {
                slot_3 = value;
            }
        }
        public int Slot_4
        {
            get
            {
                return slot_4;
            }
            set
            {
                slot_4 = value;
            }
        }
        public int Slot_5
        {
            get
            {
                return slot_5;
            }
            set
            {
                slot_5 = value;
            }
        }
   
        public int Quantidade_1
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
            }
        }
        public int Quantidade_2
        {
            get
            {
                return quantidade_2;
            }
            set
            {
                quantidade_2 = value;
            }
        }
        public int Quantidade_3
        {
            get
            {
                return quantidade_3;
            }
            set
            {
                quantidade_3 = value;
            }
        }
        public int Quantidade_4
        {
            get
            {
                return quantidade_4;
            }
            set
            {
                quantidade_4 = value;
            }
        }
        public int Quantidade_5
        {
            get
            {
                return quantidade_5;
            }
            set
            {
                quantidade_5 = value;
            }
        }

        public int Id_client
        {
            get
            {
                return id_client;
            }
            set
            {
                id_client = value;
            }
        }

        static Dictionary<int, Pedidos> dpedido = new Dictionary<int, Pedidos>();
        public Dictionary<int, Pedidos> Dpedido
        {
            get
            {
                return dpedido;
            }
        }

        public Pedidos()
        {
        }

        public Pedidos(int id_client, int slot_1, int slot_2, int slot_3, int slot_4, int slot_5, int quantidade, int quantidade_2, int quantidade_3, int quantidade_4, int quantidade_5) : this(id_client, slot_1)
        {
            this.id_client = id_client;
            this.slot_2 = slot_2;
            this.slot_3 = slot_3;
            this.slot_4 = slot_4;
            this.slot_5 = slot_5;
            this.quantidade = quantidade;
            this.quantidade_2 = quantidade_2;
            this.quantidade_3 = quantidade_3;
            this.quantidade_4 = quantidade_4;
            this.quantidade_5 = quantidade_5;
        }

        public Pedidos(int id_item, int quantidade)
        {
            slot_1 = id_item;
            this.quantidade = quantidade;
        }
    }
}
