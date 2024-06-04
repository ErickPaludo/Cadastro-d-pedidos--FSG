using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public interface IClient
    {
        void SetController(ControllerClient controller);
        MaskedTextBox Cnpj { get; set; }
        TextBox Nome_f { get; set; }
        TextBox Nome_r { get; set; }
        MaskedTextBox Tel { get; set; }
        MaskedTextBox Cep { get; set; }
        TextBox Municipio { get; set; }
        TextBox Bairro { get; set; }
        TextBox Logradouro { get; set; }
        ComboBox Uf { get; set; }
        TextBox Numero { get; set; }
        DataGridView Tabela { get; set; }

    }
}
