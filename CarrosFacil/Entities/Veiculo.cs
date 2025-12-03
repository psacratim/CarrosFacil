using CarrosFacil.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil.Entities
{
    class Veiculo
    {
        public int id { get; set; }
        public int id_modelo { get; set; }
        public string categoria { get; set; }
        public string estado_do_veiculo { get; set; }
        public int tempo_de_uso { get; set; }
        public decimal preco_custo { get; set; }
        public decimal preco_venda { get; set; }
        public decimal preco_desconto { get; set; }
        public int desconto { get; set; }
        public bool tem_desconto { get; set; }
        public int lucro { get; set; }
        public int kms_rodado { get; set; }
        public string final_placa { get; set; }
        public string cor { get; set; }
        public string descricao { get; set; }
        public int ano { get; set; }
        public string tipo_cambio { get; set; }
        public string tipo_combustivel { get; set; }
        public string foto { get; set; }
        public int estoque { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
        public List<int> caracteristicas { get; set; }


        public Veiculo()
        {
            this.id = 0;
            this.id_modelo = 0;
            this.categoria = null;
            this.estado_do_veiculo = null;
            this.tempo_de_uso = 0;
            this.preco_custo = 0;
            this.preco_venda = 0;
            this.preco_desconto = 0;
            this.desconto = 0;
            this.tem_desconto = false;
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
            this.caracteristicas = new List<int>();
        }

        public int Cadastrar()
        {
            string query = string.Format(
                "INSERT INTO veiculo VALUES (0, {0}, '{1}', '{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, '{11}', '{12}', '{13}', {14}, '{15}', '{16}', '{17}', {18}, NOW(), {19});",
                id_modelo,
                categoria,
                estado_do_veiculo,
                tempo_de_uso,
                preco_custo.ToString().Replace(",", "."), // novo campo do banco
                preco_venda.ToString().Replace(",", "."),
                preco_desconto.ToString().Replace(",", "."),
                desconto,
                tem_desconto ? 1 : 0,
                lucro,
                kms_rodado,
                final_placa,
                cor,
                descricao ?? "",
                ano,
                tipo_cambio,
                tipo_combustivel,
                foto,
                estoque,
                status
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarModelos()
        {
            string query = "SELECT DISTINCT m.id, m.nome 'nome' FROM modelo AS m INNER JOIN veiculo AS v ON m.id = v.id_modelo ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable CarregarCategorias()
        {
            string query = "SELECT DISTINCT categoria FROM veiculo ORDER BY categoria;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public int InserirCaracteristicas(int idVeiculo)
        {
            if (caracteristicas == null || caracteristicas.Count == 0)
            {
                return 0;
            }

            List<string> valores = new List<string>();
            foreach (int idCaracteristica in caracteristicas)
            {
                valores.Add($"({idVeiculo}, {idCaracteristica})");
            }

            if (valores.Count > 0)
            {
                Conexao conexao = new Conexao();
                conexao.ExecutaQuery("DELETE FROM caracteristica_carro WHERE id_veiculo = " + idVeiculo + ";");


                string valoresString = string.Join(", ", valores);
                string query = string.Format(
                    "INSERT INTO caracteristica_carro (id_veiculo, id_caracteristica) VALUES {0};",
                    valoresString
                );

                return conexao.ExecutaQuery(query);
            }

            return 1;
        }

        public int AtualizarVeiculo()
        {
            string query = string.Format(
                "UPDATE veiculo SET id_modelo = {0}, categoria = '{1}', estado_do_veiculo = '{2}', tempo_de_uso = {3}, preco_custo = {4}, preco_venda = {5}, preco_desconto = {6}, desconto = {7}, tem_desconto = {8}, lucro = {9}, kms_rodado = {10}, final_placa = '{11}', cor = '{12}', descricao = '{13}', ano = {14}, tipo_cambio = '{15}', tipo_combustivel = '{16}', foto = '{17}', estoque = {18}, status = {19} WHERE id = {20};",
                id_modelo,
                categoria,
                estado_do_veiculo,
                tempo_de_uso,
                preco_custo.ToString().Replace(",", "."),
                preco_venda.ToString().Replace(",", "."),
                preco_desconto.ToString().Replace(",", "."),
                desconto,
                tem_desconto ? 1 : 0,
                lucro,
                kms_rodado,
                final_placa,
                cor,
                descricao ?? "",
                ano,
                tipo_cambio,
                tipo_combustivel,
                foto,
                estoque,
                status,
                id
            );

            Conexao conexao = new Conexao();
            int result = conexao.ExecutaQuery(query);
            if (result == 0) return result;

            return InserirCaracteristicas(id);
        }

        public bool ConsultaVeiculo(int id)
        {
            string queryVeiculo = "SELECT * FROM veiculo WHERE id = " + id;

            Conexao conexao = new Conexao();
            DataTable dtVeiculo = conexao.RetornaDados(queryVeiculo);

            string queryCaracteristicas = "SELECT id_caracteristica FROM caracteristica_carro WHERE id_veiculo = " + id;
            Conexao conexao2 = new Conexao();
            DataTable dtCaracteristicas = conexao2.RetornaDados(queryCaracteristicas);

            if (dtVeiculo.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(dtVeiculo.Rows[0]["id"]);
                id_modelo = Convert.ToInt32(dtVeiculo.Rows[0]["id_modelo"]);
                categoria = Convert.ToString(dtVeiculo.Rows[0]["categoria"]);
                estado_do_veiculo = Convert.ToString(dtVeiculo.Rows[0]["estado_do_veiculo"]);
                tempo_de_uso = Convert.ToInt32(dtVeiculo.Rows[0]["tempo_de_uso"]);
                preco_custo = Convert.ToDecimal(dtVeiculo.Rows[0]["preco_custo"]);
                preco_venda = Convert.ToDecimal(dtVeiculo.Rows[0]["preco_venda"]);
                preco_desconto = Convert.ToDecimal(dtVeiculo.Rows[0]["preco_desconto"]);
                desconto = Convert.ToInt32(dtVeiculo.Rows[0]["desconto"]);
                tem_desconto = Convert.ToBoolean(dtVeiculo.Rows[0]["tem_desconto"]);
                lucro = Convert.ToInt32(dtVeiculo.Rows[0]["lucro"]);
                kms_rodado = Convert.ToInt32(dtVeiculo.Rows[0]["kms_rodado"]);
                final_placa = Convert.ToString(dtVeiculo.Rows[0]["final_placa"]);
                cor = Convert.ToString(dtVeiculo.Rows[0]["cor"]);
                descricao = Convert.ToString(dtVeiculo.Rows[0]["descricao"]);
                ano = Convert.ToInt32(dtVeiculo.Rows[0]["ano"]);
                tipo_cambio = Convert.ToString(dtVeiculo.Rows[0]["tipo_cambio"]);
                tipo_combustivel = Convert.ToString(dtVeiculo.Rows[0]["tipo_combustivel"]);
                foto = Convert.ToString(dtVeiculo.Rows[0]["foto"]);
                estoque = Convert.ToInt32(dtVeiculo.Rows[0]["estoque"]);
                data_cadastro = Convert.ToDateTime(dtVeiculo.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dtVeiculo.Rows[0]["status"]);

                return true;
            }

            this.caracteristicas = dtCaracteristicas.AsEnumerable()
                .Select(row => row.Field<int>("id_caracteristica"))
                .ToList();

            return false;
        }


        public DataTable ConsultarPorDesconto(bool comDesconto)
        {
            int valor = comDesconto ? 1 : 0;
            string query = string.Format(
                "SELECT veiculo.id '#', modelo.nome 'Modelo', veiculo.categoria 'Categoria', veiculo.estado_do_veiculo 'Estado', " +
                "veiculo.preco_custo 'Preço Custo', veiculo.preco_venda 'Preço Venda', veiculo.preco_desconto 'Preço Desconto', " +
                "veiculo.desconto 'Desconto', veiculo.tem_desconto 'Tem Desconto', veiculo.estoque 'Estoque', " +
                "veiculo.data_cadastro 'Data Cadastro', veiculo.status 'Status' " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.tem_desconto = {0} ORDER BY veiculo.categoria;", valor);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorStatus(int status)
        {
            string query = string.Format(
                "SELECT veiculo.id '#', modelo.nome 'Modelo', veiculo.categoria 'Categoria', veiculo.estado_do_veiculo 'Estado', " +
                "veiculo.preco_custo 'Preço Custo', veiculo.preco_venda 'Preço Venda', veiculo.preco_desconto 'Preço Desconto', " +
                "veiculo.desconto 'Desconto', veiculo.tem_desconto 'Tem Desconto', veiculo.estoque 'Estoque', " +
                "veiculo.data_cadastro 'Data Cadastro', veiculo.status 'Status' " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.status = {0} ORDER BY veiculo.categoria;", status);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorModelo(int codigoModelo)
        {
            string query = string.Format(
                "SELECT veiculo.id '#', modelo.nome 'Modelo', veiculo.categoria 'Categoria', veiculo.estado_do_veiculo 'Estado', " +
                "veiculo.preco_custo 'Preço Custo', veiculo.preco_venda 'Preço Venda', veiculo.preco_desconto 'Preço Desconto', " +
                "veiculo.desconto 'Desconto', veiculo.tem_desconto 'Tem Desconto', veiculo.estoque 'Estoque', " +
                "veiculo.data_cadastro 'Data Cadastro', veiculo.status 'Status' " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.id_modelo = {0} ORDER BY veiculo.categoria;", codigoModelo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCategoria(string categoria)
        {
            string query = string.Format(
                "SELECT veiculo.id '#', modelo.nome 'Modelo', veiculo.categoria 'Categoria', veiculo.estado_do_veiculo 'Estado', " +
                "veiculo.preco_custo 'Preço Custo', veiculo.preco_venda 'Preço Venda', veiculo.preco_desconto 'Preço Desconto', " +
                "veiculo.desconto 'Desconto', veiculo.tem_desconto 'Tem Desconto', veiculo.estoque 'Estoque', " +
                "veiculo.data_cadastro 'Data Cadastro', veiculo.status 'Status' " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.categoria = '{0}' ORDER BY veiculo.preco_venda;", categoria);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorEstado(string estadoVeiculo)
        {
            string query = string.Format(
                "SELECT veiculo.id '#', modelo.nome 'Modelo', veiculo.categoria 'Categoria', veiculo.estado_do_veiculo 'Estado', " +
                "veiculo.preco_custo 'Preço Custo', veiculo.preco_venda 'Preço Venda', veiculo.preco_desconto 'Preço Desconto', " +
                "veiculo.desconto 'Desconto', veiculo.tem_desconto 'Tem Desconto', veiculo.estoque 'Estoque', " +
                "veiculo.data_cadastro 'Data Cadastro', veiculo.status 'Status' " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.estado_do_veiculo = '{0}' ORDER BY veiculo.preco_venda;", estadoVeiculo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorEstoque(int quantidade, bool maiorIgual)
        {
            string operador = maiorIgual ? ">=" : "<=";
            string query = string.Format(
                "SELECT veiculo.id '#', modelo.nome 'Modelo', veiculo.categoria 'Categoria', veiculo.estado_do_veiculo 'Estado', " +
                "veiculo.preco_custo 'Preço Custo', veiculo.preco_venda 'Preço Venda', veiculo.preco_desconto 'Preço Desconto', " +
                "veiculo.desconto 'Desconto', veiculo.tem_desconto 'Tem Desconto', veiculo.estoque 'Estoque', " +
                "veiculo.data_cadastro 'Data Cadastro', veiculo.status 'Status' " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.estoque {0} {1} ORDER BY veiculo.estoque DESC;", operador, quantidade);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable CarregarVeiculos()
        {
            string query = string.Format(
                "SELECT veiculo.id, modelo.nome 'Modelo', veiculo.categoria, veiculo.preco_venda, veiculo.estoque " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.status = 1;");

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        /*
         * 
         * MÉTODOS DE RELATORIO
         *
        */
        public DataTable RelatorioPorStatus(int status)
        {
            string query = "SELECT modelo.nome 'id_modelo', veiculo.categoria, veiculo.estado_do_veiculo, veiculo.tem_desconto, IF (veiculo.preco_desconto > 0, veiculo.preco_desconto, veiculo.preco_venda) 'preco_venda', veiculo.lucro, veiculo.status FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE veiculo.status = " + status + " ORDER BY modelo.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable RelatorioPorModelo(int idModelo)
        {
            string query = "SELECT modelo.nome 'id_modelo', veiculo.categoria, veiculo.estado_do_veiculo, veiculo.tem_desconto, IF (veiculo.preco_desconto > 0, veiculo.preco_desconto, veiculo.preco_venda) 'preco_venda', veiculo.lucro, veiculo.status FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE veiculo.id_modelo = " + idModelo + " ORDER BY modelo.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable RelatorioPorCategoria(string categoria)
        {
            string query = "SELECT modelo.nome 'id_modelo', veiculo.categoria, veiculo.estado_do_veiculo, veiculo.tem_desconto, IF (veiculo.preco_desconto > 0, veiculo.preco_desconto, veiculo.preco_venda) 'preco_venda', veiculo.lucro, veiculo.status FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE veiculo.categoria = '" + categoria + "' ORDER BY modelo.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable RelatorioPorEstado(string estado)
        {
            string query = "SELECT modelo.nome 'id_modelo', veiculo.categoria, veiculo.estado_do_veiculo, veiculo.tem_desconto, IF (veiculo.preco_desconto > 0, veiculo.preco_desconto, veiculo.preco_venda) 'preco_venda', veiculo.lucro, veiculo.status FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE veiculo.estado_do_veiculo = '" + estado + "' ORDER BY modelo.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable RelatorioPorTemDesconto(bool temDesconto)
        {
            // Converte o bool para o valor booleano (ou 0/1) esperado pelo banco de dados
            int valorDesconto = temDesconto ? 1 : 0;

            string query = "SELECT modelo.nome 'id_modelo', veiculo.categoria, veiculo.estado_do_veiculo, veiculo.tem_desconto, IF (veiculo.preco_desconto > 0, veiculo.preco_desconto, veiculo.preco_venda) 'preco_venda', veiculo.lucro, veiculo.status FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE veiculo.tem_desconto = " + valorDesconto + " ORDER BY modelo.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable RelatorioPorLucro(int minimo, int maximo)
        {
            string query = "SELECT modelo.nome 'id_modelo', veiculo.categoria, veiculo.estado_do_veiculo, veiculo.tem_desconto, IF (veiculo.preco_desconto > 0, veiculo.preco_desconto, veiculo.preco_venda) 'preco_venda', veiculo.lucro, veiculo.status FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE veiculo.lucro BETWEEN "+minimo+" AND "+maximo+" ORDER BY modelo.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        //VENDAS
        public DataTable CarregarGridVeiculo(string nomeModelo) // CarregarGridProduto
        {
            string query = string.Format(
                "SELECT veiculo.id '#', modelo.nome 'Modelo', veiculo.categoria 'Categoria', " +
                "veiculo.preco_venda 'Preço Venda', veiculo.preco_desconto 'Preço Desconto', " +
                "veiculo.tem_desconto 'Tem Desconto', veiculo.estoque 'Estoque' " +
                "FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo " +
                "WHERE veiculo.status = 1 AND modelo.nome LIKE '%{0}%' ORDER BY veiculo.categoria;", nomeModelo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public bool AtualizarEstoque(int id, int quantidade) // BuscarNomeProduto
        {
            string query = "UPDATE veiculo SET estoque = "+ quantidade + " WHERE id = "+ id;

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query) == 1;
        }


        private string[] IDS_CACHE = { };
        public string ObterNomeModelo(int id)
        {
            string query = "SELECT veiculo.id_modelo, modelo.nome FROM veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE veiculo.id = " + id;

            Conexao conexao = new Conexao();
            DataTable dt = conexao.RetornaDados(query);
            return dt.Rows[0]["nome"].ToString();
        }
    }
}
