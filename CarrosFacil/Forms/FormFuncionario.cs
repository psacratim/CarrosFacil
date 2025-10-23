﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using CarrosFacil.Entities;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace CarrosFacil
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        public string tipo, estado, estado_civil, sexo;
        public int cargo, tipo_acesso;
        public DateTime data_cadastro;

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormFuncionario_Load(object sender, EventArgs e)
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

            // CARGO - ALIMENTADA PELO DB
            _ = Task.Run(() =>
            {
                // Obtem os cargos.
                Cargo cargo = new Cargo();
                DataTable cargos = cargo.CarregarCargo();

                this.Invoke((Action)(() =>
                {
                    cbCargo.DataSource = cargos;
                    cbCargo.DisplayMember = "nome";
                    cbCargo.ValueMember = "id";
                    cbCargo.SelectedIndex = -1;

                    // VERIFICAR O MODO DE ABERTURA
                    if (tipo == "Atualização")
                    {
                        cbStatus.Enabled = true;
                        btnCadastrar.Enabled = false;
                        btnAtualizar.Enabled = true;
                        btnDeletar.Enabled = true;

                        cbEstado.SelectedItem = estado;
                        cbEstadoCivil.SelectedItem = estado_civil;
                        cbCargo.SelectedValue = this.cargo;
                        cbTipoAcesso.SelectedIndex = tipo_acesso;
                        dtpDataCadastro.Value = data_cadastro;

                        switch (sexo)
                        {
                            case "M":
                                cbSexo.SelectedIndex = 0;
                                break;
                            case "F":
                                cbSexo.SelectedIndex = 1;
                                break;
                            default:
                                cbSexo.SelectedItem = 2;
                                break;
                        }
                    }
                    else
                    {
                        cbStatus.Enabled = false;
                        btnCadastrar.Enabled = true;
                        btnAtualizar.Enabled = false;
                        btnDeletar.Enabled = false;
                    }
                }));
            });
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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

            Funcionario funcionario = new Funcionario();
            funcionario.id_cargo = Convert.ToInt32(cbCargo.SelectedValue.ToString());
            funcionario.cpf = mtbCpf.Text;
            funcionario.rg = mtbRg.MaskFull ? mtbRg.Text : "";
            funcionario.nome = tbNome.Text;
            funcionario.nome_social = tbNomeSocial.Text;
            funcionario.senha = tbSenha.Text;

            funcionario.salario = tbSalario.Text != "" ? Convert.ToDouble(tbSalario.Text) : 0;

            funcionario.cep = mtbCep.MaskFull ? mtbCep.Text : "";
            funcionario.endereco = tbEndereco.Text;
            funcionario.numero = Convert.ToInt32(tbNumero.Text);
            funcionario.complemento = tbComplemento.Text;
            funcionario.bairro = tbBairro.Text;
            funcionario.cidade = tbCidade.Text;
            funcionario.estado = cbEstado.SelectedItem.ToString();

            funcionario.sexo = cbSexo.SelectedItem.ToString().First().ToString();
            funcionario.usuario = tbUsuario.Text;
            funcionario.estado_civil = cbEstadoCivil.SelectedItem.ToString();
            funcionario.data_nascimento = dtpDataNascimento.Value;
            funcionario.tipo_acesso = cbTipoAcesso.SelectedIndex;
            funcionario.telefone_recado = mtbTelefoneRecado.Text;
            funcionario.telefone_celular = mtbTelefoneCelular.MaskFull ? mtbTelefoneCelular.Text : "";
            funcionario.telefone_residencial =  mtbTelefoneResidencial.MaskFull ? mtbTelefoneResidencial.Text : "";
            funcionario.email = tbEmail.Text;

            // SALVANDO A FOTO NO BANCO DE DADOS!
            string fotoPerfil = Uploader.EnviarImagem(lbFoto.Text).Result;
            if (fotoPerfil.Contains("error"))
            {
                MessageBox.Show("Erro ao salvar a foto, funcionário será salvo sem foto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                funcionario.foto = fotoPerfil;
            }

            int response = funcionario.Cadastrar();
            if (response == 0)
            {
                MessageBox.Show("Não foi possível cadastrar o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string nome = funcionario.nome_social == "" ? funcionario.nome : funcionario.nome_social;
                MessageBox.Show("Funcionário: "+ nome +" cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos() || tbCodigo.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso - Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DefinirCorCamposObrigatorios(Color.Red);
                tbNome.Focus();
                return;
            }

            Funcionario funcionario = new Funcionario();
            funcionario.id = Convert.ToInt32(tbCodigo.Text);
            funcionario.id_cargo = Convert.ToInt32(cbCargo.SelectedValue.ToString());
            funcionario.cpf = mtbCpf.Text;
            funcionario.rg = mtbRg.MaskFull ? mtbRg.Text : "";
            funcionario.nome = tbNome.Text;
            funcionario.nome_social = tbNomeSocial.Text;
            funcionario.senha = tbSenha.Text;

            funcionario.salario = tbSalario.Text != "" ? Convert.ToDouble(tbSalario.Text) : 0;

            funcionario.cep = mtbCep.MaskFull ? mtbCep.Text : "";
            funcionario.endereco = tbEndereco.Text;
            funcionario.numero = Convert.ToInt32(tbNumero.Text);
            funcionario.complemento = tbComplemento.Text;
            funcionario.bairro = tbBairro.Text;
            funcionario.cidade = tbCidade.Text;
            funcionario.estado = cbEstado.SelectedItem.ToString();

            funcionario.sexo = cbSexo.SelectedItem.ToString().First().ToString();
            funcionario.usuario = tbUsuario.Text;
            funcionario.estado_civil = cbEstadoCivil.SelectedItem.ToString();
            funcionario.data_nascimento = dtpDataNascimento.Value;
            funcionario.tipo_acesso = cbTipoAcesso.SelectedIndex;
            funcionario.telefone_recado = mtbTelefoneRecado.Text;
            funcionario.telefone_celular = mtbTelefoneCelular.MaskFull ? mtbTelefoneCelular.Text : "";
            funcionario.telefone_residencial = mtbTelefoneResidencial.MaskFull ? mtbTelefoneResidencial.Text : "";
            funcionario.email = tbEmail.Text;
            funcionario.status = cbStatus.SelectedIndex;

            // SALVANDO A FOTO NO BANCO DE DADOS!
            string fotoPerfil = Uploader.EnviarImagem(lbFoto.Text).Result;
            if (fotoPerfil.Contains("error"))
            {
                MessageBox.Show("Erro ao salvar a foto, funcionário será salvo sem foto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                funcionario.foto = fotoPerfil;
            }

            int response = funcionario.AtualizarFuncionario();
            if (response == 0)
            {
                MessageBox.Show("Não foi possível atualizar o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nome = funcionario.nome_social == "" ? funcionario.nome : funcionario.nome_social;
                MessageBox.Show("Funcionário: " + nome + " atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();
            }

            this.Close();
        }

        private bool ValidarCampos()
        {
            if (tbNome.Text == "" ||
            cbSexo.SelectedIndex == -1 ||
            cbEstadoCivil.SelectedIndex == -1 ||
            dtpDataNascimento.Text == " / /" ||
            tbSenha.Text == "" ||
            tbUsuario.Text == "" ||
            cbEstado.SelectedIndex == -1 ||
            tbCidade.Text == "" ||
            tbBairro.Text == "" ||
            tbNumero.Text == "" ||
            tbEndereco.Text == "" ||
            !mtbCpf.MaskFull ||
            !mtbTelefoneRecado.MaskFull ||
            cbCargo.SelectedIndex == -1 || 
            cbTipoAcesso.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            tbNome.BackColor = color;
            cbSexo.BackColor = color;
            cbEstadoCivil.BackColor = color;
            dtpDataNascimento.BackColor = color;
            tbSenha.BackColor = color;
            tbUsuario.BackColor = color;
            cbEstado.BackColor = color;
            tbCidade.BackColor = color;
            tbBairro.BackColor = color;
            tbNumero.BackColor = color;
            tbEndereco.BackColor = color;
            mtbCpf.BackColor = color;
            mtbTelefoneRecado.BackColor = color;
            cbTipoAcesso.BackColor = color;
            cbCargo.BackColor = color;
        }

        private void Limpar()
        {
            tbNome.Clear();
            tbNomeSocial.Clear();
            cbSexo.SelectedIndex = 0;
            cbEstadoCivil.SelectedIndex = 0;
            dtpDataNascimento.Value = DateTime.Now;
            cbCargo.SelectedIndex = -1;
            tbSalario.Clear();
            tbSenha.Clear();
            tbUsuario.Clear();
            tbEmail.Clear();
            tbComplemento.Clear();
            cbEstado.SelectedValue = "SP";
            tbCidade.Clear();
            tbBairro.Clear();
            tbNumero.Clear();
            tbEndereco.Clear();
            mtbRg.Clear();
            mtbCpf.Clear();
            mtbTelefoneResidencial.Clear();
            mtbTelefoneCelular.Clear();
            mtbTelefoneRecado.Clear();
            mtbCep.Clear();
            cbTipoAcesso.SelectedIndex = 0;
            cbStatus.SelectedIndex = 1;
        }


        private async void mtbCep_TextChanged(object sender, EventArgs e)
        {
            if (mtbCep.MaskFull)
            {
                string cep = mtbCep.Text.Replace("-", "");
                try
                {
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
                catch (Exception) { }
            }
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelectDialog = new OpenFileDialog();
            imageSelectDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            imageSelectDialog.Title = "Selecionar ícone";

            if (imageSelectDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbFoto.Image = new Bitmap(imageSelectDialog.FileName);
                    lbFoto.Text = imageSelectDialog.FileName.Replace("\\", "//");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar imagem, tente novamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
