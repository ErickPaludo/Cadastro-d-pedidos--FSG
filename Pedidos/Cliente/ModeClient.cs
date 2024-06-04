using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Pedidos
{
    public class ModelClient
    {
        Client client = new Client();
        SalvarDados salvar = new SalvarDados();
        public async Task<Client> BuscaDadosCnpj(string cnpj)
        {
            // URL do serviço ReceitaWS
            string apiUrl = $"https://www.receitaws.com.br/v1/cnpj/{cnpj}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Verifica se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Converte a resposta para uma string
                        string content = await response.Content.ReadAsStringAsync();

                        // Faz o parse do JSON
                        dynamic result = JsonConvert.DeserializeObject(content);

                        // Cria um objeto DadosCnpj com os dados obtidos
                        Client dadosCnpj = new Client
                        {
                            Nome = result.nome.ToString(),
                            Tel = result.telefone.ToString(),
                            Cep = result.cep.ToString(),
                            Municipio = result.municipio.ToString(),
                            Bairro = result.bairro.ToString(),
                            Logradouro = result.logradouro.ToString(),
                            Uf = result.uf.ToString(),
                            Numero = result.numero.ToString()
                        };

                        return dadosCnpj;
                    }
                    else
                    {
                        MessageBox.Show($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return null;
        }

        public void CadastroClient(Client info)
        {
            int novoId = client.Dclient.Count > 0 ? client.Dclient.Keys.Max() + 1 : 1;
            client.Dclient.Add(novoId, new Client(info.Cnpj,info.Nome_f,info.Nome,info.Tel,info.Cep,info.Municipio,info.Bairro,info.Logradouro,info.Uf,info.Numero));
            salvar.SalvariClient();
        }

    }
}
