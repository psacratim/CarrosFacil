using System;
using System.Data;
using System.Threading.Tasks;

namespace CarrosFacil
{
    class Veiculo
    {
        public int id { get; set; }
        public int id_vendedor { get; set; }
        public int id_modelo { get; set; }
        public string categoria { get; set; }
        public string estado_do_veiculo { get; set; }
        public int tempo_de_uso { get; set; }
        public decimal preco { get; set; }
        public int kms_rodado { get; set; }
        public string final_placa { get; set; }
        public string cor { get; set; }
        public string descricao { get; set; }
        public int ano { get; set; }
        public string tipo_cambio { get; set; }
        public string tipo_combustivel { get; set; }
        public int estoque { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }


        public Veiculo()
        {
            this.id = 0;
            this.id_vendedor = 0;
            this.id_modelo = 0;
            this.categoria = null;
            this.estado_do_veiculo = null;
            this.tempo_de_uso = 0;
            this.preco = 0;
            this.kms_rodado = 0;
            this.final_placa = null;
            this.cor = null;
            this.descricao = null;
            this.ano = 0;
            this.tipo_cambio = null;
            this.tipo_combustivel = null;
            this.estoque = 0;
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        // METHODS
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO veiculo VALUES (0, {0}, '{1}', '{2}', {3}, {4}, {5}, '{6}', '{7}', '{8}', {9}, '{10}', '{11}', {12}, NOW(), 1);",
                id_modelo,
                categoria,
                estado_do_veiculo,
                tempo_de_uso,
                preco,
                kms_rodado,
                final_placa,
                cor,
                descricao,
                ano,
                tipo_cambio,
                tipo_combustivel,
                estoque
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarVeiculos()
        {
            string query = "SELECT id, nome FROM veiculo WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
    }
}
