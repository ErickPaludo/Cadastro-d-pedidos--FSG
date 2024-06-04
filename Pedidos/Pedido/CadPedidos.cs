using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class CadPedidos : Form, Ipedido
    {
        ControllerPedido controller;
        public CadPedidos()
        {
            InitializeComponent();
        }
        public void SetController(ControllerPedido controller)
        {
            this.controller = controller;
        }
        public Label ClietSelect { get { return labelClient; } set { labelClient = value; } }
        public DataGridView TabelaClient { get { return dataGridClient; } set { dataGridClient = value; } }

        public DataGridView Itens { get { return dataGridItem; } set { dataGridItem = value; } }
        public DataGridView ItensSelecionados { get { return dataGriditemSelecionado; } set { dataGriditemSelecionado = value; } }
        public DataGridView TabelaPedidos { get { return dataGridPedidos; } set { dataGridPedidos = value; } }
        public DataGridView TabelaPitens { get { return dataGridViewPItens; } set { dataGridViewPItens = value; } }
        public TextBox Pesquisa { get { return textBoxPesq; } set { textBoxPesq = value; } }

        private void SelecionaCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                controller.SelecionaClienteId(Convert.ToInt32(dataGridClient.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void SelecionaItem(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                controller.SelecionaItem(Convert.ToInt32(dataGridItem.Rows[e.RowIndex].Cells[0].Value), e.RowIndex);
            }
        }

        private void SelecionaItemPedido(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                controller.RetornaItemLista(Convert.ToInt32(dataGriditemSelecionado.Rows[e.RowIndex].Cells[0].Value), e.RowIndex);
            }
        }

        private void CadastraPedido(object sender, EventArgs e)
        {
            controller.Cadastrar();
        }

        private void SelecionaPedido(object sender, DataGridViewCellEventArgs e)
        {
            controller.ItensDoPedido(Convert.ToInt32(dataGridPedidos.Rows[e.RowIndex].Cells[0].Value));
        }

        private void PesquisarPedido(object sender, EventArgs e)
        {
            controller.Pesquisar();
        }
    }
}
