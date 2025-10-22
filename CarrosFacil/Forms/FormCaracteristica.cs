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
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
            caracteristica.iconePath = lbIcone.Text;

            int resultado = caracteristica.Cadastrar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao cadastrar marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Caracteristica: " + caracteristica.nome + " cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;
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
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar imagem, tente novamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
