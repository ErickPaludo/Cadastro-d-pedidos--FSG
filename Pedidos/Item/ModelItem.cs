using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ModelItem
    {
        Item item = new Item();
        SalvarDados salvar = new SalvarDados();
        public void CadastroDeItens(Item produto)
        {
            int novoId = item.Ditens.Count > 0 ? item.Ditens.Keys.Max() + 1 : 1;
            item.Ditens.Add(novoId, new Item(produto.Nome_item, produto.Preco_item));
            salvar.SalvariItens();
        }
    }
}
