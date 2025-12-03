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
        private List<ItemVenda> itensVenda = new List<ItemVenda>(); // Lista de itens que aparecerá na grid de itens vendidos.
        private decimal vendaTotal = 0; // Valor total da venda
        private int qntItensVenda = 0;

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
            txtQtde.Text = "1";
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

        private void AtualizarItensVenda()
        {
            // Crie uma nova DataTable
            DataTable dt = new DataTable();

            // Adiciona as colunas na DT
            dt.Columns.Add("Código");
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Valor Unitário");
            dt.Columns.Add("Valor Total");

            // Criar classe veiculo
            var veiculo = new Veiculo();

            // Faça um for nos itens da lista
            foreach (ItemVenda venda in itensVenda)
            {
                dt.Rows.Add(venda.id_veiculo, veiculo.ObterNomeModelo(venda.id_veiculo), venda.quantidade, venda.valor_unitario, venda.valor_total);
                dt.AcceptChanges();
            }

            // Atualize o data source da grid para o novo.
            dgvItens.DataSource = dt;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProduto.Text))
            {
                MessageBox.Show("Não tem nenhum produto para ser inserido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItemVenda item = new ItemVenda();
            item.id_veiculo = (int)dgvProduto.SelectedRows[0].Cells[0].Value;
            item.quantidade = Convert.ToInt32(txtQtde.Text);
            item.valor_unitario = Convert.ToDecimal(txtValor.Text);
            item.valor_total = Convert.ToDecimal(txtTotal.Text);

            itensVenda.Add(item);
            qntItensVenda++;

            AtualizarItensVenda();
        }

        private void txtPercentualDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtPercentualDesconto.Text == "" || txtPercentualDesconto.Text == "0") {
                decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);
                txtTotalVenda.Text = valorTotal.ToString("N2");

                txtPercentualDesconto.Text = "0";
                txtPercentualDesconto.SelectAll();

                txtTotalDesconto.Text = "0,00";
                return;
            }

            decimal percentual = Convert.ToDecimal(txtPercentualDesconto.Text) / 100;
            decimal valorVenda = Convert.ToDecimal(txtValorTotal.Text);
            decimal valorDesconto = percentual * valorVenda;

            txtTotalDesconto.Text = valorDesconto.ToString("N2");

            decimal totalVenda = valorVenda - valorDesconto;
            txtTotalVenda.Text = totalVenda.ToString("N2");
        }
    }
}
