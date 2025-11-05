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
    public partial class FormCargo : Form
    {
        public FormCargo()
        {
            InitializeComponent();
        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.Red);

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Cargo cargo = new Cargo();
            cargo.nome = tbNome.Text;
            cargo.observacao = tbObservacao.Text;
            cargo.status = cbStatus.SelectedIndex;

            int resultado = cargo.Cadastrar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao cadastrar cargo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cargo: " + cargo.nome + " cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ShowWarning(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
