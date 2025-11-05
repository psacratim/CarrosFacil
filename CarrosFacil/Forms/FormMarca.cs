using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil
{
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbNomeSocial_TextChanged(object sender, EventArgs e)
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

            Marca marca = new Marca();
            marca.nome = tbNome.Text;
            marca.observacao = tbObservacao.Text;
            marca.status = cbStatus.SelectedIndex;

            int resultado = marca.Cadastrar();
            if (resultado == 0) { // ERRO
                MessageBox.Show("Erro ao cadastrar marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                MessageBox.Show("Marca: "+marca.nome+" cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefinirCorCamposObrigatorios(SystemColors.Window);
                Limpar();
            }
        }

        private bool ValidarCampos()
        {
            if (tbNome.Text == "")
            {
                return false;
            }

            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            tbNome.BackColor = color;
        }

        private void Limpar()
        {
            tbNome.Clear();
            tbObservacao.Clear();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
