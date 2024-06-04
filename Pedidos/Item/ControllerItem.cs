using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ControllerItem
    {
        Iitem viewitem;
        ModelItem modelitem;
        Item item = new Item();
        public ControllerItem()
        {
        }

        public ControllerItem(Iitem viewitem, ModelItem modelitem)
        {
            this.viewitem = viewitem;
            this.modelitem = modelitem;
            viewitem.SetController(this);
            Atualiza();
        }

        public void CadastrarItem()
        {
            if (!string.IsNullOrEmpty(viewitem.NomeItem.Text) && !string.IsNullOrEmpty(viewitem.PrecoItem.Text))
            {
                modelitem.CadastroDeItens(new Item(viewitem.NomeItem.Text, Convert.ToDouble(viewitem.PrecoItem.Text)));
                viewitem.NomeItem.Clear();
                viewitem.PrecoItem.Clear();
                Atualiza();
            }
        }
        private void Atualiza()
        {
           viewitem.TabelaItens.Rows.Clear();
            foreach(var obj in item.Ditens)
            {
                viewitem.TabelaItens.Rows.Add(obj.Key, obj.Value.Nome_item, obj.Value.Preco_item);
            }
        }
    }
}
