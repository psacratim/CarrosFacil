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

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            string nome = txtPesqProduto.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite o nome do produto para pesquisar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesqProduto.Focus();
                txtPesqProduto.BackColor = Color.Red;
                return;
            }

            // Restaura a cor original.
            txtPesqProduto.BackColor = SystemColors.Window;

            // Obtem o cliente e mostra
            Veiculo veiculo = new Veiculo();
            dgvProduto.DataSource = veiculo.CarregarGridVeiculo(nome);
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduto.SelectedRows.Count <= 0) { 
                return;
            }

            int selectedId = (int) dgvProduto.SelectedRows[0].Cells[0].Value;
            Veiculo veiculo = new Veiculo();
            veiculo.ConsultaVeiculo(selectedId);

            var modelo = new Modelo();
            modelo.ConsultaModelo(veiculo.id_modelo);

            txtProduto.Text = modelo.nome;
            txtQtdeEstoque.Text = veiculo.estoque.ToString();
            txtValor.Text = (veiculo.tem_desconto ? veiculo.preco_desconto : veiculo.preco_venda).ToString();
            txtQtde_TextChanged(this, new EventArgs());
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            string quantidadeTexto = txtQtde.Text;
            if (string.IsNullOrWhiteSpace(quantidadeTexto) || quantidadeTexto == "0")
            {
                MessageBox.Show("Por favor, digite uma quantidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtde.Focus();
                txtQtde.BackColor = Color.Red;
                return;
            }

            int quantidadeVendida = Convert.ToInt32(quantidadeTexto);
            int quantidadeEstoque = Convert.ToInt32(txtQtdeEstoque.Text);

            if (quantidadeVendida > quantidadeEstoque)
            {
                MessageBox.Show("A quantidade disponível no estoque é: "+quantidadeEstoque+" unidades!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtde.Focus();
                txtQtde.BackColor = Color.Red;
                txtQtde.Text = "1";
                txtQtde.SelectAll();
                return;
            }

            txtQtde.BackColor = SystemColors.Window;
            decimal valor = Convert.ToDecimal(txtValor.Text);

            txtTotal.Text = (quantidadeVendida * valor).ToString();
        }
    }
}
