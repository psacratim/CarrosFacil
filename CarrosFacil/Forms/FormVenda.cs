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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }       
             
        private void formVenda49_Load(object sender, EventArgs e)
        {
            //CARREGAR DATA DA VENDA
            txtDataVenda.Text = DateTime.Now.ToShortDateString();

            //COMBO FORMA DE PAGAMENTO
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Pix");
            cbFormaPagamento.SelectedIndex = -1;

            // COMBO FUNCIONARIOS
            _ = Task.Run(() =>
            {
                // Obtem os cargos.
                Funcionario funcionario = new Funcionario();
                DataTable funcionarios = funcionario.BuscarFuncionario();

                this.Invoke((Action)(() =>
                {
                    cbFuncionario.DataSource = funcionarios;
                    cbFuncionario.DisplayMember = "nome";
                    cbFuncionario.ValueMember = "id";
                    cbFuncionario.SelectedIndex = -1;
                }));
            });
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gbClientes_Enter(object sender, EventArgs e)
        {

        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            string nome = txtPesqCliente.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite o nome de cliente para pesquisar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesqCliente.Focus();
                txtPesqCliente.BackColor = Color.Red;
                return;
            }
            
            // Restaura a cor original.
            txtPesqCliente.BackColor = SystemColors.Window;

            // Obtem o cliente e mostra
            Cliente cliente = new Cliente();
            dgvCliente.DataSource = cliente.CarregaGridClient(nome);
        }
    }
}
