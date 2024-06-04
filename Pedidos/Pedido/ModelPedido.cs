using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ModelPedido
    {
        Pedidos pedidos = new Pedidos();
        SalvarDados save = new SalvarDados();
        public void AddPedido(Pedidos dados)
        {
            int id_pedido = pedidos.Dpedido.Count > 0 ? pedidos.Dpedido.Keys.Max() + 1 : 1;
           pedidos.Dpedido.Add(id_pedido, new Pedidos(dados.Id_client,dados.Slot_1,dados.Slot_2,dados.Slot_3,dados.Slot_4,dados.Slot_5,dados.Quantidade_1, dados.Quantidade_2,dados.Quantidade_3,dados.Quantidade_4,dados.Quantidade_5));
            save.SalvarPedidos();
            MessageBox.Show($"Pedido {id_pedido} cadastrado com sucesso!");
        }
    }
}
