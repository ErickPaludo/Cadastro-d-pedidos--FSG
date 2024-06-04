using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public class ControllerClient
    {

        IClient viewclient;
        ModelClient model;
        Client cliente = new Client();
        public ControllerClient()
        {
        }

        public ControllerClient(IClient viewclient, ModelClient model)
        {
            this.viewclient = viewclient;
            this.model = model;
            viewclient.SetController(this);
            Atualiza();
        }
        public async Task Buscar() {
            Client dadosCnpj = await model.BuscaDadosCnpj(viewclient.Cnpj.Text);
            viewclient.Nome_f.Text = dadosCnpj.Nome;
            viewclient.Nome_r.Text = dadosCnpj.Nome;
            viewclient.Tel.Text = dadosCnpj.Tel;
            viewclient.Municipio.Text = dadosCnpj.Municipio;
            viewclient.Bairro.Text = dadosCnpj.Bairro;
            viewclient.Logradouro.Text = dadosCnpj.Logradouro;
            viewclient.Numero.Text = dadosCnpj.Numero;
            viewclient.Uf.Text = dadosCnpj.Uf;
            viewclient.Cep.Text = dadosCnpj.Cep;
        }


        public void CadastrarClient()
        {
            if(!string.IsNullOrEmpty(viewclient.Cnpj.Text) && !string.IsNullOrEmpty(viewclient.Nome_f.Text) && !string.IsNullOrEmpty(viewclient.Nome_r.Text) && !string.IsNullOrEmpty(viewclient.Tel.Text) && !string.IsNullOrEmpty(viewclient.Municipio.Text) && !string.IsNullOrEmpty(viewclient.Cep.Text) && !string.IsNullOrEmpty(viewclient.Bairro.Text) && !string.IsNullOrEmpty(viewclient.Uf.Text) && !string.IsNullOrEmpty(viewclient.Logradouro.Text) && !string.IsNullOrEmpty(viewclient.Numero.Text)) 
            {
                viewclient.Cnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                model.CadastroClient(new Client(viewclient.Cnpj.Text, viewclient.Nome_f.Text, viewclient.Nome_r.Text, viewclient.Tel.Text, viewclient.Cep.Text, viewclient.Municipio.Text, viewclient.Bairro.Text, viewclient.Logradouro.Text, viewclient.Uf.Text, viewclient.Numero.Text));

                viewclient.Cnpj.Clear();
                viewclient.Nome_f.Clear();
                viewclient.Nome_r.Clear();
                viewclient.Tel.Clear();
                viewclient.Municipio.Clear();
                viewclient.Cep.Clear();
                viewclient.Bairro.Clear();
                viewclient.Logradouro.Clear();
                viewclient.Numero.Clear();
                viewclient.Cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                Atualiza();
            }
        }
        private void Atualiza()
        {
            viewclient.Tabela.Rows.Clear();
            foreach(var obj in cliente.Dclient)
            {
                viewclient.Tabela.Rows.Add(obj.Key,obj.Value.Nome_f);
            }
        }
    }
}
