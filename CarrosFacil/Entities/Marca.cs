using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil
{
    class Marca
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Marca()
        {
            this.id = 0;
            this.nome = "";
            this.observacao = "";
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO marca VALUES({0}, '{1}', '{2}', {3}, {4});",
                0,
                nome,
                observacao,
                "NOW()",
                1
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarMarcas()
        {
            string query = "SELECT id, nome FROM marca WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
    }
}
