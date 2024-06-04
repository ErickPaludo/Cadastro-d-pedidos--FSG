using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Client
    {
        private string cnpj, nome_f, nome, tel, cep, municipio, bairro, logradouro, uf, numero;
        public string Cnpj { get { return cnpj; } set { cnpj = value; } }
        public string Nome_f { get { return nome_f; } set { nome_f = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Tel { get { return tel; } set { tel = value; } }
        public string Cep { get { return cep; } set { cep = value; } }
        public string Municipio { get { return municipio; } set { municipio = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }
        public string Uf { get { return uf; } set { uf = value; } }
        public string Numero { get { return numero; } set { numero = value; } }

        static Dictionary<int, Client> dClient = new Dictionary<int, Client>();
        public Dictionary<int, Client> Dclient { get { return dClient; } }

        public Client()
        {
        }

        public Client(string cnpj, string nome_f, string nome, string tel, string cep, string municipio, string bairro, string logradouro, string uf, string numero)
        {
            this.cnpj = cnpj;
            this.nome_f = nome_f;
            this.nome = nome;
            this.tel = tel;
            this.cep = cep;
            this.municipio = municipio;
            this.bairro = bairro;
            this.logradouro = logradouro;
            this.uf = uf;
            this.numero = numero;
        }

        public Client( string nome, string tel,string cep, string municipio, string bairro, string logradouro, string uf, string numero)
        {
            this.nome = nome;
            this.tel = tel;
            this.cep = cep;
            this.municipio = municipio;
            this.bairro = bairro;
            this.logradouro = logradouro;
            this.uf = uf;
            this.numero = numero;
        }
    }
}
