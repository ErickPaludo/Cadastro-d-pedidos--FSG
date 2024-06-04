using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public interface Ipedido
    {
        void SetController(ControllerPedido controller);

        Label ClietSelect { get; set; }
        DataGridView TabelaClient { get; set; }
        DataGridView ItensSelecionados { get; set; }
        DataGridView Itens { get; set; }
        DataGridView TabelaPedidos { get; set; }
        DataGridView TabelaPitens { get; set; }
        TextBox Pesquisa { get; set; } 
    }
}
