using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Modelo
    {
        public int id { get; set; }
        public int id_marca { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Modelo()
        {
            id = 0;
            id_marca = 0;
            nome = null;
            observacao = null;
            data_cadastro = DateTime.MinValue;
            status = 0;
        }

        // METHODS
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO modelo VALUES (0, '{0}', '{1}', '{2}', NOW(), 1);", id_marca, nome, observacao);
            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarModelos()
        {
            string query = "SELECT id, nome FROM modelo WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
    }
}
