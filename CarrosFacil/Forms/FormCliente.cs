using CarrosFacil.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil.Forms
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }


        private void FormCliente_Load(object sender, EventArgs e)
        {
            //ESTADOS
            cbEstado.Items.Add("AC"); // Acre
            cbEstado.Items.Add("AL"); // Alagoas
            cbEstado.Items.Add("AP"); // Amapá
            cbEstado.Items.Add("AM"); // Amazonas
            cbEstado.Items.Add("BA"); // Bahia
            cbEstado.Items.Add("CE"); // Ceará
            cbEstado.Items.Add("DF"); // Distrito Federal
            cbEstado.Items.Add("ES"); // Espírito Santo
            cbEstado.Items.Add("GO"); // Goiás
            cbEstado.Items.Add("MA"); // Maranhão
            cbEstado.Items.Add("MT"); // Mato Grosso
            cbEstado.Items.Add("MS"); // Mato Grosso do Sul
            cbEstado.Items.Add("MG"); // Minas Gerais
            cbEstado.Items.Add("PA"); // Pará
            cbEstado.Items.Add("PB"); // Paraíba
            cbEstado.Items.Add("PR"); // Paraná
            cbEstado.Items.Add("PE"); // Pernambuco
            cbEstado.Items.Add("PI"); // Piauí
            cbEstado.Items.Add("RJ"); // Rio de Janeiro
            cbEstado.Items.Add("RN"); // Rio Grande do Norte
            cbEstado.Items.Add("RS"); // Rio Grande do Sul
            cbEstado.Items.Add("RO"); // Rondônia
            cbEstado.Items.Add("RR"); // Roraima
            cbEstado.Items.Add("SC"); // Santa Catarina
            cbEstado.Items.Add("SP"); // São Paulo
            cbEstado.Items.Add("SE"); // Sergipe
            cbEstado.Items.Add("TO"); // Tocantins
            cbEstado.SelectedItem = "SP";

            // SEXO
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Indefinido");
            cbSexo.SelectedIndex = 0;

            //ESTADOS CIVIL
            cbEstadoCivil.Items.Add("Solteiro(a)");
            cbEstadoCivil.Items.Add("Casado(a)");
            cbEstadoCivil.Items.Add("Separado(a)");
            cbEstadoCivil.Items.Add("Divorciado(a)");
            cbEstadoCivil.Items.Add("Viúvo(a)");
            cbEstadoCivil.SelectedIndex = 0;

            //Tipo de acesso
            cbTipoAcesso.Items.Add("Comum");
            cbTipoAcesso.Items.Add("Administrador");
            cbTipoAcesso.SelectedIndex = 0;

            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso - Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DefinirCorCamposObrigatorios(Color.Red);
                tbNome.Focus();
                return;
            }

            if (dtpDataNascimento.Value.Year == DateTime.Now.Year)
            {
                MessageBox.Show("Por favor, insira uma data de nascimento verdadeira.", "Aviso - Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DefinirCorCamposObrigatorios(Color.Red);
                tbNome.Focus();
                return;
            }

            Cliente cliente = new Cliente();
            cliente.cpf = mtbCpf.Text;
            cliente.rg = mtbRg.MaskFull ? mtbRg.Text : "";
            cliente.nome_completo = tbNome.Text;
            cliente.data_nascimento = dtpDataNascimento.Value;

            cliente.usuario = tbUsuario.Text;
            cliente.senha = tbSenha.Text;

            cliente.endereco = tbEndereco.Text;
            cliente.cep = mtbCep.MaskFull ? mtbCep.Text : "";
            cliente.numero = Convert.ToInt32(tbNumero.Text);
            cliente.complemento = tbComplemento.Text;
            cliente.bairro = tbBairro.Text;
            cliente.cidade = tbCidade.Text;
            cliente.estado = cbEstado.SelectedItem.ToString();

            cliente.telefone1 = mtbTelefone1.Text;
            cliente.telefone2 = mtbTelefone2.MaskFull ? mtbTelefone2.Text : "";
            cliente.email = tbEmail.Text;
            cliente.estado_civil = cbEstadoCivil.SelectedItem.ToString();

            cliente.sexo = cbSexo.SelectedItem.ToString().First().ToString();

            int response = cliente.Cadastrar();
            if (response == 0)
            {
                MessageBox.Show("Não foi possível cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cliente: " + cliente.nome_completo + " cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();
            }
        }

        private bool ValidarCampos()
        {
            if (!mtbCpf.MaskFull ||
            tbNome.Text == "" ||
            tbUsuario.Text == "" ||
            tbSenha.Text == "" ||
            tbEndereco.Text == "" ||
            tbNumero.Text == "" ||
            tbBairro.Text == "" ||
            tbCidade.Text == "" ||
            cbEstado.SelectedIndex == -1 ||
            !mtbTelefone1.MaskFull ||
            cbEstadoCivil.SelectedIndex == -1 ||
            cbSexo.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            mtbCpf.BackColor = color;
            tbNome.BackColor = color;
            dtpDataNascimento.BackColor = color;
            tbUsuario.BackColor = color;
            tbSenha.BackColor = color;
            tbEndereco.BackColor = color;
            tbNumero.BackColor = color;
            tbBairro.BackColor = color;
            tbCidade.BackColor = color;
            cbEstado.BackColor = color;
            mtbTelefone1.BackColor = color;
            cbEstadoCivil.BackColor = color;
            cbSexo.BackColor = color;
        }

        private void Limpar()
        {
            mtbCpf.Clear();
            tbNome.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            tbUsuario.Clear();
            tbSenha.Clear();
            tbEndereco.Clear();
            tbNumero.Clear();
            tbComplemento.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            cbEstado.SelectedValue = "SP";
            mtbTelefone1.Clear();
            cbEstadoCivil.SelectedIndex = 0;
            cbEstadoCivil.SelectedIndex = 0;
        }

        private async void mtbCep_TextChanged(object sender, EventArgs e)
        {
            if (mtbCep.MaskFull)
            {
                string cep = mtbCep.Text.Replace("-", "");
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri("https://viacep.com.br/ws/" + cep + "/json/"));
                webRequest.Method = "GET";
                webRequest.ContentType = "application/json";

                string jsonString;
                WebResponse response = await webRequest.GetResponseAsync();
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonString = reader.ReadToEnd();
                }

                Cep data = JsonConvert.DeserializeObject<Cep>(jsonString);

                tbEndereco.Text = data.logradouro;
                tbBairro.Text = data.bairro;
                tbCidade.Text = data.localidade;
                cbEstado.SelectedItem = data.uf;
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
