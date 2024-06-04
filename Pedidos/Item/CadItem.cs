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
    public partial class CadItem : Form, Iitem
    {
        private ControllerItem controller;
        public CadItem()
        {
            InitializeComponent();
        }
        public void SetController(ControllerItem controller)
        {
            this.controller = controller;
        }

        public TextBox NomeItem { get { return tNome; } set { tNome = value; } }
        public TextBox PrecoItem { get { return tPreco; } set { tPreco = value; } }
        public DataGridView TabelaItens { get { return dataGridItem; } set { dataGridItem = value; } }

        private void Cadastrar(object sender, EventArgs e)
        {
            controller.CadastrarItem();
        }
    }
}
