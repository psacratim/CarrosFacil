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

namespace CarrosFacil.Forms.Relatorios
{
    public partial class FormRelVeiculo : Form
    {
        public FormRelVeiculo()
        {
            InitializeComponent();
        }

        private void FormRelVeiculo_Load(object sender, EventArgs e)
        {
            // CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Modelo de veículo");     
            cbTipoRel.Items.Add("Categoria de veículo");
            cbTipoRel.Items.Add("Estado do veículo");
            cbTipoRel.Items.Add("Lucro na venda");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            // CARREGANDO COMBO ESTADOS
            cbEstado.Items.Add("Usado");
            cbEstado.Items.Add("Novo");
            cbEstado.SelectedIndex = -1;

            // Carros de passeio
            //cbCategoria.Items.Add("Hatchback");
            //cbCategoria.Items.Add("Sedan");
            //cbCategoria.Items.Add("SUV");
            //cbCategoria.Items.Add("Crossover");
            //cbCategoria.Items.Add("Cupê");
            //cbCategoria.Items.Add("Conversível");
            //cbCategoria.Items.Add("Perua / Station Wagon");
            //cbCategoria.Items.Add("Roadster");
            //cbCategoria.Items.Add("Esportivo");
            //cbCategoria.Items.Add("Compacto");
            //cbCategoria.Items.Add("Minivan");
            //cbCategoria.Items.Add("Pickup");

            //// Utilitários e comerciais leves
            //cbCategoria.Items.Add("Van");
            //cbCategoria.Items.Add("Furgão");
            //cbCategoria.Items.Add("Caminhonete");

            //// Esportivos e luxo
            //cbCategoria.Items.Add("Esportivo");
            //cbCategoria.Items.Add("Superesportivo");
            //cbCategoria.Items.Add("Luxo / Premium");
            //cbCategoria.Items.Add("Gran Turismo (GT)");
            //cbCategoria.Items.Add("Roadster");
            //cbCategoria.Items.Add("Conversível Esportivo");

            //// Caminhões e veículos pesados
            //cbCategoria.Items.Add("Caminhão Leve");
            //cbCategoria.Items.Add("Caminhão Médio");
            //cbCategoria.Items.Add("Caminhão Pesado");
            //cbCategoria.Items.Add("Carreta");

            //// Motos e similares
            //cbCategoria.Items.Add("Motocicleta");
            //cbCategoria.Items.Add("Scooter");
            //cbCategoria.Items.Add("Triciclo");
            //cbCategoria.Items.Add("Quadriciclo");

            //// Veículos especiais
            //cbCategoria.Items.Add("Buggy");
            //cbCategoria.Items.Add("Off-Road / 4x4");
            //cbCategoria.Items.Add("Motorhome");

            // CARREGANDO: MODELO 
            _ = Task.Run(() => 
            {
                // OBTENDO AS CIDADES DO BANCO
                Veiculo veiculo = new Veiculo();
                DataTable modelos = veiculo.CarregarModelos();
                DataTable categorias = veiculo.CarregarCategorias();

                // VOLTANDO AO THREAD ANTERIOR
                this.Invoke((Action)(() =>
                {
                    cbModelo.DataSource = modelos;
                    cbModelo.DisplayMember = "nome";
                    cbModelo.ValueMember = "id";
                    if (cbModelo.Items.Count > 0) cbModelo.SelectedIndex = 0;

                    cbCategoria.DataSource = categorias;
                    cbCategoria.DisplayMember = "categoria";
                    cbCategoria.ValueMember = "categoria";
                    cbCategoria.DataSource = categorias;
                    if (cbCategoria.Items.Count > 0) cbCategoria.SelectedIndex = 0;
                }));
            });
            this.rvVeiculo.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbModelo.Enabled = cbTipoRel.SelectedIndex == 0;
            gbCategoria.Enabled = cbTipoRel.SelectedIndex == 1;
            gbEstado.Enabled = cbTipoRel.SelectedIndex == 2;
            gbLucro.Enabled = cbTipoRel.SelectedIndex == 3;
            gbStatus.Enabled = cbTipoRel.SelectedIndex == 4;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o relatório de veículos?", "Sistema Carros Fácil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            int relatorio = Convert.ToInt32(cbTipoRel.SelectedIndex);

            switch (relatorio)
            {
                case 1: // Categoria
                    if (cbCategoria.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, selecione uma categoria válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string categoria = cbCategoria.SelectedValue.ToString();

                    VeiculoBindingSource.DataSource = veiculo.RelatorioPorCategoria(categoria);
                    rvVeiculo.RefreshReport();
                    break;
                    
                case 2: // Estado do veiculo
                    if (cbEstado.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, selecione um estado de veículo válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string estado;
                    switch (cbEstado.SelectedIndex)
                    {
                        case 1:
                            estado = "Novo";
                            break;

                        default:
                            estado = "Usado";
                            break;
                    }

                    VeiculoBindingSource.DataSource = veiculo.RelatorioPorEstado(estado);
                    rvVeiculo.RefreshReport();
                    break;

                case 3: // Lucro
                    int lucroMinimo = 0, lucroMaximo = 99999;
                    if (!string.IsNullOrEmpty(txtLucroMinimo.Text))
                    {
                        lucroMinimo = Convert.ToInt32(txtLucroMinimo.Text);
                    }

                    if (!string.IsNullOrEmpty(txtLucroMaximo.Text))
                    {
                        lucroMaximo = Convert.ToInt32(txtLucroMaximo.Text);
                    }

                    VeiculoBindingSource.DataSource = veiculo.RelatorioPorLucro(lucroMinimo, lucroMaximo);
                    rvVeiculo.RefreshReport();
                    break;

                case 4: // Status
                    int status = rbAtivo.Checked ? 1 : 0;

                    VeiculoBindingSource.DataSource = veiculo.RelatorioPorStatus(status);
                    rvVeiculo.RefreshReport();
                    break;

                default: // Modelo
                    if (cbModelo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, selecione um modelo válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int modelo = Convert.ToInt32(cbModelo.SelectedValue);

                    VeiculoBindingSource.DataSource = veiculo.RelatorioPorModelo(modelo);
                    rvVeiculo.RefreshReport();
                    break;
            }
        }
    }
}
