using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Caracteristica
    {
        // Atalho pra criar propriedade: escreva "prop" e aperta duas vezes a tecla tab.
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string iconePath { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Caracteristica()
        {
            this.id = 0;
            this.nome = null;
            this.descricao = null;
            this.iconePath = null;
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        // METHODS
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO caracteristica VALUES (0, '{0}', '{1}', '{2}', NOW(), 1);", nome, descricao, iconePath);
            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarCaracteristicas()
        {
            string query = "SELECT id, nome FROM caracteristica WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
    }
}
