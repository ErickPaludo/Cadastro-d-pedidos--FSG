﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Topics.Radical.Model;

namespace Pedidos
{
    public class ControllerPedido
    {
        Ipedido viewpedido;
        ModelPedido model;
        Client client = new Client();
        Item item = new Item();
        Pedidos pedidos = new Pedidos();
        static int id_select,id_pedido;
        bool edit = false;
        public ControllerPedido()
        {
        }

        public ControllerPedido(Ipedido viewpedido, ModelPedido model)
        {
            this.viewpedido = viewpedido;
            this.model = model;
            viewpedido.SetController(this);
            Atualiza();
        }

        public void Atualiza()
        {
            viewpedido.TabelaClient.Rows.Clear();
            viewpedido.ItensSelecionados.Rows.Clear();
            viewpedido.Itens.Rows.Clear();
            viewpedido.TabelaPedidos.Rows.Clear();
            foreach (var obj in client.Dclient)
            {
                viewpedido.TabelaClient.Rows.Add(obj.Key, obj.Value.Nome_f, obj.Value.Cnpj, obj.Value.Municipio, obj.Value.Uf);
            }
            foreach (var obj in item.Ditens)
            {
                viewpedido.Itens.Rows.Add(obj.Key, obj.Value.Nome_item, $"R$ {obj.Value.Preco_item.ToString("f2")}");
            }
            foreach (var obj in pedidos.Dpedido)
            {
                foreach (var client in client.Dclient)
                {
                    if (obj.Value.Id_client == client.Key)
                    {
                        viewpedido.TabelaPedidos.Rows.Add(obj.Key, client.Value.Nome_f);
                    }
                }
            }
        }
        public void SelecionaClienteId(int index)
        {
            foreach (var obj in client.Dclient)
            {
                if (obj.Key == index)
                {
                    viewpedido.ClietSelect.Text = obj.Value.Nome_f;
                    id_select = obj.Key;
                    break;
                }
            }
        }
        public void SelecionaItem(int id, int index)
        {
            foreach (var obj in item.Ditens)
            {
                if (viewpedido.ItensSelecionados.Rows.Count <= 5)
                {
                    if (obj.Key == id)
                    {
                        viewpedido.ItensSelecionados.Rows.Add(obj.Key, obj.Value.Nome_item, $"R$ {obj.Value.Preco_item.ToString("f2")}", 1);
                        viewpedido.Itens.Rows.RemoveAt(index);
                        break;
                    }
                }
            }
        }
        public void RetornaItemLista(int id, int index)
        {
            foreach (var obj in item.Ditens)
            {
                if (obj.Key == id)
                {
                    viewpedido.Itens.Rows.Add(obj.Key, obj.Value.Nome_item, $"R$ {obj.Value.Preco_item.ToString("f2")}");
                    viewpedido.ItensSelecionados.Rows.RemoveAt(index);
                    break;
                }
            }
        }
        public void Cadastrar()
        {
            if (id_select != 0)
            {
                List<Pedidos> temp = new List<Pedidos>();
                int qtn_linhas = viewpedido.ItensSelecionados.Rows.Count - 1;
                if (qtn_linhas > 0)
                {

                    for (int i = 0; i <= qtn_linhas; i++)
                    {
                        temp.Add(new Pedidos(Convert.ToInt32(viewpedido.ItensSelecionados.Rows[i].Cells[0].Value), Convert.ToInt32(viewpedido.ItensSelecionados.Rows[i].Cells[3].Value)));
                    }
                    if (qtn_linhas < 4)
                    {
                        for (int i = 1; i <= 5 - qtn_linhas; i++)
                        {
                            temp.Add(new Pedidos(0, 0));
                        }
                    }
                    if (edit == false)
                    {
                        model.AddPedido(new Pedidos(id_select, temp[0].Slot_1, temp[1].Slot_1, temp[2].Slot_1, temp[3].Slot_1, temp[4].Slot_1, temp[0].Quantidade_1, temp[1].Quantidade_1, temp[2].Quantidade_1, temp[3].Quantidade_1, temp[4].Quantidade_1));
                        Atualiza();
                        viewpedido.ClietSelect.Text = "Cliente selecionado:";
                        id_select = 0;
                    }
                    else
                    {
                        model.Editor(id_pedido,new Pedidos(id_select, temp[0].Slot_1, temp[1].Slot_1, temp[2].Slot_1, temp[3].Slot_1, temp[4].Slot_1, temp[0].Quantidade_1, temp[1].Quantidade_1, temp[2].Quantidade_1, temp[3].Quantidade_1, temp[4].Quantidade_1));
                        Atualiza();
                        viewpedido.ClietSelect.Text = "Cliente selecionado:";
                        id_select = 0;
                        viewpedido.TabelaPedidos.Enabled = true;
                        viewpedido.TabelaPitens.Enabled = true;
                        viewpedido.Pesquisa.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o cliente para proceguir com o pedido");
            }
        }
        public void ItensDoPedido(int id_pedido)
        {
            viewpedido.TabelaPitens.Rows.Clear();
            foreach (var obj in pedidos.Dpedido)
            {
                if (obj.Key == id_pedido)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        string id = $"Slot_{i}";
                        string qtn = $"Quantidade_{i}";
                        PropertyInfo id_item = typeof(Pedidos).GetProperty(id);
                        PropertyInfo quantidade = typeof(Pedidos).GetProperty(qtn);
                        int slotValue = (int)id_item.GetValue(obj.Value);
                        int slotQuant = (int)quantidade.GetValue(obj.Value);

                        if (slotValue != 0)
                        {
                            Item dados = item.Ditens[slotValue];
                            viewpedido.TabelaPitens.Rows.Add(slotValue, dados.Nome_item, slotQuant, dados.Preco_item);
                        }
                    }
                }
            }
        }
        public void Pesquisar()
        {
            viewpedido.TabelaPedidos.Rows.Clear();
            viewpedido.TabelaPitens.Rows.Clear();
            if (!string.IsNullOrEmpty(viewpedido.Pesquisa.Text) && pedidos.Dpedido.ContainsKey(Convert.ToInt32(viewpedido.Pesquisa.Text)))
            {
                Pedidos dados = pedidos.Dpedido[Convert.ToInt32(viewpedido.Pesquisa.Text)];
                Client dados_cliente = client.Dclient[dados.Id_client];
                viewpedido.TabelaPedidos.Rows.Add(viewpedido.Pesquisa.Text, dados_cliente.Nome_f);
            }
            else
            {
                Atualiza();
            }
        }
        public void FunctionBts(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == viewpedido.TabelaPedidos.Columns[3].Index)
            {
                int id = Convert.ToInt32(viewpedido.TabelaPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult dialogo = MessageBox.Show("Deseja exluir o pedido?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    model.RemPedido(id);
                    Atualiza();
                    viewpedido.TabelaPitens.Rows.Clear();
                }
            }
            else if (e.ColumnIndex == viewpedido.TabelaPedidos.Columns[2].Index)
            {
                id_pedido = Convert.ToInt32(viewpedido.TabelaPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult dialogo = MessageBox.Show("Deseja editar o pedido?", "Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    edit = true;
                    MessageBox.Show($"Pedido {id_pedido} selecionado");
                    viewpedido.TabelaPedidos.Enabled = false;
                    viewpedido.TabelaPitens.Enabled = false;
                    viewpedido.Pesquisa.Enabled = false;
                    Atualiza();

                    List<int> itens_pedidos = new List<int>();
                    viewpedido.ItensSelecionados.Rows.Clear();
                    foreach (var obj in pedidos.Dpedido)
                    {
                       
                        if (obj.Key == id_pedido)
                        {
                            id_select = obj.Value.Id_client;
                            for (int i = 1; i <= 5; i++)
                            {
                                string id = $"Slot_{i}";
                                string qtn = $"Quantidade_{i}";
                                PropertyInfo id_item = typeof(Pedidos).GetProperty(id);
                                PropertyInfo quantidade = typeof(Pedidos).GetProperty(qtn);
                                int slotValue = (int)id_item.GetValue(obj.Value);
                                int slotQuant = (int)quantidade.GetValue(obj.Value);

                                if (slotValue != 0)
                                {
                                    itens_pedidos.Add(slotValue);
                                    Item dados = item.Ditens[slotValue];
                                    viewpedido.ItensSelecionados.Rows.Add(slotValue, dados.Nome_item, slotQuant, dados.Preco_item);
                                }
                            }
                        }
                    }
                    for (int i = viewpedido.Itens.Rows.Count - 1; i >= 0; i--)
                    {
                        if (int.TryParse(viewpedido.Itens.Rows[i].Cells[0].Value?.ToString(), out int id))
                        {
                           
                            if (itens_pedidos.Contains(id))
                            {
                                viewpedido.Itens.Rows.RemoveAt(i);
                            }
                        }
                    }
                  
                }
            }
        }
        public void DafaltId()
        {
            id_pedido = 0;
        }


    }
}
