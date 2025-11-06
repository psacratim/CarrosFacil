using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil.Forms.Consultas
{
    public partial class FormConsCargo : Form
    {
        public FormConsCargo()
        {
            InitializeComponent();
        }

        private void FormConsCargo_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            cbOpcoes.Items.Add("- Nenhum Filtro -");
            cbOpcoes.Items.Add("Filtrar por código");
            cbOpcoes.Items.Add("Filtrar por nome");
            cbOpcoes.Items.Add("Filtrar por status");
            cbOpcoes.SelectedIndex = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Substitui 'var modelo = new Modelo();' por 'var cargo = new Cargo();'
            var cargo = new Cargo();
            switch (cbOpcoes.SelectedIndex)
            {
                case 1: // Filtrar por código
                    if (tbCodigo.Text == "")
                    {
                        MessageBox.Show("Por favor, insira um código para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var codigo = Convert.ToInt32(tbCodigo.Text);
                    // Adaptação do método de consulta para Cargo
                    dgvCargos.DataSource = cargo.ConsultarPorCodigo(codigo);
                    break;

                case 2: // Filtrar por nome
                    if (tbNome.Text == "")
                    {
                        MessageBox.Show("Por favor, insira um nome para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var nome = tbNome.Text;
                    // Adaptação do método de consulta para Cargo
                    dgvCargos.DataSource = cargo.ConsultarPorNome(nome);
                    break;

                case 3: // Filtrar por status
                    // Adaptação do DataGridView (de dgvMarcas para dgvCargos) e método de consulta para Cargo
                    dgvCargos.DataSource = cargo.ConsultarPorStatus(cbStatus.SelectedIndex);
                    break;

                default: // Nenhum Filtro
                    // Adaptação do DataGridView (de dgvMarcas para dgvCargos) e método de consulta para Cargo
                    dgvCargos.DataSource = cargo.ConsultarSemFiltro();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir o cargo selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                // Cria o cargo e obtém os dados.
                // Substitui 'Modelo' por 'Cargo' e 'ConsultaModelo' por 'ConsultaCargo'
                Cargo cargo = new Cargo();
                cargo.ConsultaCargo(Convert.ToInt32(dgvCargos.SelectedRows[0].Cells[0].Value));

                // Define os campos do Cargo
                // Substitui 'FormModelo' por 'FormCargo'
                FormCargo formCargo = new FormCargo();
                formCargo.tipo = "Atualização";
                formCargo.status = cargo.status;
                // **Nota:** A linha 'formModelo.id_marca = modelo.id_marca;' foi removida, 
                // pois cargos geralmente não têm id_marca.

                formCargo.tbCodigo.Text = cargo.id.ToString();
                formCargo.tbNome.Text = cargo.nome.ToString();
                formCargo.tbObservacao.Text = cargo.observacao;

                // Modo exclusivo (ShowDialog)
                formCargo.ShowDialog();

                // Atualiza a grid de consulta.
                btnPesquisar_Click(this, new EventArgs());
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lógica para permitir apenas números, se for o caso
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCodigo.Enabled = cbOpcoes.SelectedIndex == 1;
            tbNome.Enabled = cbOpcoes.SelectedIndex == 2;
            cbStatus.Enabled = cbOpcoes.SelectedIndex == 3;
        }
    }
}
