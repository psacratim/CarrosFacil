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

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void FormCargo_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo();

            cargo.nome = tbNomeCargo.Texts;
            if (string.IsNullOrEmpty(cargo.nome))
            {
                tbNomeCargo.BackColor = ColorTranslator.FromHtml("#F88E8E");
                ShowWarning("Aviso - Nome do Cargo", "Preencha todos os campos obrigatórios.");
                return;
            }

            cargo.observacao = tbObservacao.Texts;
            int resp = cargo.Cadastrar();
            if (resp == 1)
            {
                MessageBox.Show("Cargo: " + cargo.nome + " cadastrado com sucesso!", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            } else
            {
                ShowWarning("Erro", "Não foi possível cadastrar o cargo " + cargo.nome + "");
            }
        }

        private void ClearForm()
        {
            tbNomeCargo.BackColor = Color.White;

            tbNomeCargo.Texts = "";
            tbObservacao.Texts = "";
        }

        private void ShowWarning(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
