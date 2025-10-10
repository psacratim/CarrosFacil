using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil
{
    class Cliente
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string nome_completo { get; set; }
        public DateTime data_nascimento { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string cep { get; set; }
        public string foto { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string email { get; set; }
        public string estado_civil { get; set; }
        public string sexo { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
            
        public Cliente()
        {
            id = 0;
            cpf = null;
            rg = null;
            nome_completo = null;
            data_nascimento = DateTime.Now;
            senha = null;
            sexo = null;
            usuario = null;
            estado_civil = null;
            telefone1 = null;
            telefone2 = null;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            email = null;
            cep = null;
            foto = null;
            data_cadastro = DateTime.Now;
            status = 0;
        }

        /*
         * CAMPOS DATE: propriedade.toString("yyyy-MM-dd");
         * CAMPOS DECIMAL: propriedade.replaceAll(",", ".");
         * SEM ASPAS SIMPLES EM CAMPO BIT!
        */
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO cliente VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', {20});",
                0,
                cpf,
                rg,
                nome_completo,
                data_nascimento.ToString("yyyy-MM-dd"),
                usuario,
                senha,
                endereco,
                cep,
                numero,
                complemento,
                bairro,
                cidade,
                estado,
                telefone1,
                telefone2,
                email,
                estado_civil,
                sexo,
                "NOW()",
                1
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarClientes()
        {
            string query = "SELECT id, nome FROM cliente WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
    }
}
