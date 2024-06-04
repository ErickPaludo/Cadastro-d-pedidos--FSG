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
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
          SalvarDados salvar = new SalvarDados();
            salvar.LerItens();
            salvar.LerClient();
            salvar.LerPedido();
        }

        private void AddItem(object sender, EventArgs e)
        {
            CadItem item = new CadItem();
            item.Visible = false;
            ModelItem model_ = new ModelItem();
            ControllerItem controller = new ControllerItem(item, model_);
            item.MdiParent = this;
            item.Show();
        }

        private void AddClient(object sender, EventArgs e)
        {
            CadClient item = new CadClient();
            item.Visible = false;
            ModelClient model_ = new ModelClient();
            ControllerClient controller = new ControllerClient(item, model_);
            item.MdiParent = this;
            item.Show();
        }

        private void AddPedido(object sender, EventArgs e)
        {
            CadPedidos item = new CadPedidos();
            item.Visible = false;
            ModelPedido model_ = new ModelPedido();
            ControllerPedido controller = new ControllerPedido(item, model_);
            item.MdiParent = this;
            item.Show();
        }
    }
}
