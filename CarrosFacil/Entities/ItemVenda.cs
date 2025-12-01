using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class ItemVenda
    {
        public int id { get; set; }
        public int id_veiculo { get; set; }
        public int id_venda { get; set; }
        public int quantidade { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal valor_total { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public ItemVenda()
        {
            this.id = 0;
            this.id_veiculo = 0;
            this.id_venda = 0;
            this.quantidade = 0;
            this.valor_unitario = 0;
            this.valor_total = 0;
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO item_venda VALUES (0, {0}, {1}, {2}, {3}, {4}, NOW(), 1);",
                id_veiculo,
                id_veiculo,
                quantidade,
                valor_unitario,
                valor_total
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }
    }
}
