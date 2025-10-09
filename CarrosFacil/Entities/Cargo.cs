using System;
using System.Data;
using System.Threading.Tasks;

namespace CarrosFacil
{
    class Cargo
    {
        // Atalho pra criar propriedade: escreva "prop" e aperta duas vezes a tecla tab.
        public int id { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Cargo()
        {
            this.id = 0;
            this.nome = null;
            this.observacao = null;
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        public Cargo(int id, String nome, String observacao, DateTime data_cadastro, int status)
        {
            this.id = id;
            this.nome = nome;
            this.observacao = observacao;
            this.data_cadastro = data_cadastro;
            this.status = status;
        }

        // METHODS
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO cargo VALUES (0, '{0}', '{1}', NOW(), 1);", nome, observacao);
            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarCargo()
        {
            string query = "SELECT id, nome FROM cargo WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
    }
}
