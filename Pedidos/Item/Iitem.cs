using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public interface Iitem
    {
        void SetController(ControllerItem controller);
        TextBox NomeItem { get; set; }
        TextBox PrecoItem { get; set; }
        DataGridView TabelaItens {  get; set; }
    }
}
