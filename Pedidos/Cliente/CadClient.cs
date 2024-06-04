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
    public partial class CadClient : Form, IClient
    {
        public CadClient()
        {
            InitializeComponent();
        }

        private ControllerClient controller;

        public void SetController(ControllerClient controller)
        {
            this.controller = controller;
        }

        public MaskedTextBox Cnpj { get { return textcnpj; } set { textcnpj = value; } }
        public TextBox Nome_f { get { return nomefantasia; } set { nomefantasia = value; } }
        public TextBox Nome_r { get { return textname; } set { textname = value; } }
        public MaskedTextBox Tel { get { return textel; } set { textel = value; } }
        public MaskedTextBox Cep { get { return textcep; } set { textcep = value; } }
        public TextBox Municipio { get { return textmuni; } set { textmuni = value; } }
        public TextBox Bairro { get { return textbairro; } set { textbairro = value; } }
        public TextBox Logradouro { get { return textlogradouro; } set { textlogradouro = value; } }
        public ComboBox Uf { get { return combouf; } set { combouf = value; } }
        public TextBox Numero { get { return textnumber; } set { textnumber = value; } }
        public DataGridView Tabela { get { return dataGridClient; } set { dataGridClient = value; } }

        private void BuscaCnpj(object sender, EventArgs e)
        {
            controller.Buscar();
        }

        private void Gravar(object sender, EventArgs e)
        {
            controller.CadastrarClient();
        }

        private void CadClient_Load(object sender, EventArgs e)
        {

        }
    }
}
