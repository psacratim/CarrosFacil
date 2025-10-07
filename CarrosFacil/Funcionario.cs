using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil
{
    class Funcionario
    {
        public int id { get; set; }
        public int id_cargo { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string nome { get; set; }
        public string nome_social { get; set; }
        public string senha { get; set; }
        public double salario { get; set; }
        public string sexo { get; set; }
        public string usuario { get; set; }
        public string estado_civil { get; set; }
        public DateTime data_nascimento { get; set; }
        public int tipo_acesso { get; set; }
        public string telefone_celular { get; set; }
        public string telefone_recado { get; set; }
        public string telefone_residencial { get; set; }
        public string cep { get; set; }
        public string foto { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Funcionario()
        {
            id = 0;
            id_cargo = 0;
            cpf = null;
            rg = null;
            nome = null;
            nome_social = null;
            senha = null;
            salario = 0;
            sexo = null;
            usuario = null;
            estado_civil = null;
            data_nascimento = DateTime.Now;
            tipo_acesso = 0;
            telefone_celular = null;
            telefone_recado = null;
            telefone_residencial = null;
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
            string query = string.Format("INSERT INTO funcionario VALUES ({0}, {1}, '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}', '{9}', '{10}', '{11}', {12}, '{13}', '{14}', '{15}', '{16}', {17}, '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', {26});",
                0,
                id_cargo,
                cpf,
                rg,
                nome,
                nome_social,
                senha,
                salario.ToString().Replace(",", "."),
                sexo,
                usuario,
                estado_civil,
                data_nascimento.ToString("yyyy-MM-dd"),
                tipo_acesso,
                telefone_celular,
                telefone_recado,
                telefone_residencial,
                endereco,
                numero,
                complemento,
                bairro,
                cidade,
                estado,
                email,
                cep,
                foto,
                "NOW()",
                1
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }
    }
}
