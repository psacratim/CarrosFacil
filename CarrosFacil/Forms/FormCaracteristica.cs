using CarrosFacil.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil.Forms
{
    public partial class FormCaracteristica : Form
    {
        public string tipo;
        public int status;

        public FormCaracteristica()
        {
            InitializeComponent();
        }

        private void FormCaracteristica_Load(object sender, EventArgs e)
        {
            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            if (tipo == "Atualização")
            {
                btnCadastrar.Enabled = false;
                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;

                cbStatus.Enabled = true;
                cbStatus.SelectedIndex = status;
            } else
            {
                cbStatus.Enabled = false;
                btnCadastrar.Enabled = true;
                btnAtualizar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }


        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {

        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.Red);

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Caracteristica caracteristica = new Caracteristica();
            caracteristica.nome = tbNome.Text;
            caracteristica.descricao = tbDescricao.Text;
            caracteristica.status = cbStatus.SelectedIndex;
            caracteristica.icone = await Uploader.EnviarImagem(lbIcone.Text);

            int resultado = caracteristica.Cadastrar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao cadastrar caracteristica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Caracteristica: " + caracteristica.nome + " cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DefinirCorCamposObrigatorios(SystemColors.Window);
                Limpar();
            }
        }

        private bool ValidarCampos()
        {
            if (tbNome.Text == "" || tbDescricao.Text == "" || lbIcone.Text == "Nenhum ícone selecionado")
            {
                return false;
            }

            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            tbNome.BackColor = color;
            tbDescricao.BackColor = color;
            gbIcone.BackColor = color;
        }

        private void Limpar()
        {
            tbNome.Clear();
            tbDescricao.Clear();
            lbIcone.Text = "";
            pbIcon.Image = pbIcon.InitialImage;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pbIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelectDialog = new OpenFileDialog();
            imageSelectDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            imageSelectDialog.Title = "Selecionar ícone";

            if (imageSelectDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbIcon.Image = new Bitmap(imageSelectDialog.FileName);
                    lbIcone.Text = imageSelectDialog.FileName.Replace("\\", "//");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar imagem, tente novamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.Red);

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Caracteristica caracteristica = new Caracteristica();
            caracteristica.id = Convert.ToInt32(tbCodigo.Text);
            caracteristica.nome = tbNome.Text;
            caracteristica.descricao = tbDescricao.Text;
            caracteristica.status = cbStatus.SelectedIndex;
            caracteristica.icone = await Uploader.EnviarImagem(lbIcone.Text);

            int resultado = caracteristica.Atualizar();
            if (resultado == 0)
            {
                MessageBox.Show("Erro ao atualizar caracteristica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Caracteristica: " + caracteristica.nome + " atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DefinirCorCamposObrigatorios(SystemColors.Window);
            Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
