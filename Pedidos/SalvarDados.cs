using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pedidos
{
    public class SalvarDados
    {
        Item item = new Item();
        Client client = new Client();
        Pedidos pedidos = new Pedidos();

        public SalvarDados()
        {
        }

        public void SalvariItens()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore // Ignora referências circulares
            };

            File.WriteAllText("Itens.json", JsonConvert.SerializeObject(item.Ditens, Formatting.Indented, settings));
        }
        public void LerItens()
        {
            if (File.Exists("Itens.json"))
            {
                string json = File.ReadAllText("Itens.json");

                Dictionary<string, Item> itens = JsonConvert.DeserializeObject<Dictionary<string, Item>>(json);

                foreach (var kvp in itens)
                {
                    item.Ditens.Add(Convert.ToInt32(kvp.Key), kvp.Value);
                }
            }
        }
        public void SalvariClient()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore 
            };

            File.WriteAllText("Clientes.json", JsonConvert.SerializeObject(client.Dclient, Formatting.Indented, settings));
        }
        public void LerClient()
        {
            if (File.Exists("Clientes.json"))
            {
             
                string json = File.ReadAllText("Clientes.json");

               
                Dictionary<string, Client> clients = JsonConvert.DeserializeObject<Dictionary<string, Client>>(json);

             
                foreach (var kvp in clients)
                {
                    client.Dclient.Add(Convert.ToInt32(kvp.Key), kvp.Value);
                }
            }
        }
        public void SalvarPedidos()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            File.WriteAllText("Pedidos.json", JsonConvert.SerializeObject(pedidos.Dpedido, Formatting.Indented, settings));
        }
        public void LerPedido()
        {
            if (File.Exists("Pedidos.json"))
            {

                string json = File.ReadAllText("Pedidos.json");


                Dictionary<string, Pedidos> ped = JsonConvert.DeserializeObject<Dictionary<string, Pedidos>>(json);


                foreach (var kvp in ped)
                {
                    pedidos.Dpedido.Add(Convert.ToInt32(kvp.Key), kvp.Value);
                }
            }
        }
    }
}
