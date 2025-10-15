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
    public partial class FormVeiculo : Form
    {
        public FormVeiculo()
        {
            InitializeComponent();
        }

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            // Estado do veículo
            cbEstadoVeiculo.Items.Add("Usado");
            cbEstadoVeiculo.Items.Add("Novo");
            cbEstadoVeiculo.SelectedIndex = -1;

            // Tipo de combustivel
            cbTipoCombustivel.Items.Add("Gasolina");
            cbTipoCombustivel.Items.Add("Etanol");
            cbTipoCombustivel.Items.Add("Flex");
            cbTipoCombustivel.Items.Add("Diesel");
            cbTipoCombustivel.Items.Add("Gás Natural Veicular (GNV)");
            cbTipoCombustivel.SelectedIndex = -1;

            // Tipo de câmbio
            cbTipoCambio.Items.Add("Manual");
            cbTipoCambio.Items.Add("Automático Tradicional");
            cbTipoCambio.Items.Add("CVT (Transmissão Continuamente Variável)");
            cbTipoCambio.Items.Add("Automatizado (Monoembreagem)");
            cbTipoCambio.Items.Add("Automático de Dupla Embreagem (DCT)");
            cbTipoCambio.SelectedIndex = -1;

            // Cores do veículo
            cbColor.Items.Add("Branco");
            cbColor.Items.Add("Preto");
            cbColor.Items.Add("Prata");
            cbColor.Items.Add("Cinza");
            cbColor.Items.Add("Vermelho");
            cbColor.Items.Add("Azul");
            cbColor.Items.Add("Verde");
            cbColor.Items.Add("Amarelo");
            cbColor.Items.Add("Laranja");
            cbColor.Items.Add("Marrom");
            cbColor.Items.Add("Bege");
            cbColor.Items.Add("Bordo");
            cbColor.Items.Add("Dourado");
            cbColor.Items.Add("Roxo");
            cbColor.Items.Add("Rosa");
            cbColor.Items.Add("Grafite");
            cbColor.Items.Add("Champagne");
            cbColor.Items.Add("Vinho");
            cbColor.SelectedIndex = -1;

            // Modeos - ALIMENTADO PELO DB
            _ = Task.Run(() =>
            {
                Modelo modelo = new Modelo();
                DataTable modelos = modelo.CarregarModelos();

                this.Invoke((Action)(() =>
                {
                    cbModelo.DataSource = modelos;
                    cbModelo.DisplayMember = "nome";
                    cbModelo.ValueMember = "id";
                    cbModelo.SelectedIndex = -1;
                }));

                Cliente cliente = new Cliente();
                DataTable clientes = cliente.CarregarClientes();

                this.Invoke((Action)(() =>
                {
                    cbVendedor.DataSource = clientes;
                    cbVendedor.DisplayMember = "nome";
                    cbVendedor.ValueMember = "id";
                    cbVendedor.SelectedIndex = -1;
                }));
            });

            // Carros de passeio
            cbCategoria.Items.Add("Hatchback");
            cbCategoria.Items.Add("Sedan");
            cbCategoria.Items.Add("SUV");
            cbCategoria.Items.Add("Crossover");
            cbCategoria.Items.Add("Cupê");
            cbCategoria.Items.Add("Conversível");
            cbCategoria.Items.Add("Perua / Station Wagon");
            cbCategoria.Items.Add("Roadster");
            cbCategoria.Items.Add("Esportivo");
            cbCategoria.Items.Add("Compacto");
            cbCategoria.Items.Add("Minivan");
            cbCategoria.Items.Add("Pickup");

            // Utilitários e comerciais leves
            cbCategoria.Items.Add("Van");
            cbCategoria.Items.Add("Furgão");
            cbCategoria.Items.Add("Caminhonete");

            // Esportivos e luxo
            cbCategoria.Items.Add("Esportivo");
            cbCategoria.Items.Add("Superesportivo");
            cbCategoria.Items.Add("Luxo / Premium");
            cbCategoria.Items.Add("Gran Turismo (GT)");
            cbCategoria.Items.Add("Roadster");
            cbCategoria.Items.Add("Conversível Esportivo");

            // Caminhões e veículos pesados
            cbCategoria.Items.Add("Caminhão Leve");
            cbCategoria.Items.Add("Caminhão Médio");
            cbCategoria.Items.Add("Caminhão Pesado");
            cbCategoria.Items.Add("Carreta");

            // Motos e similares
            cbCategoria.Items.Add("Motocicleta");
            cbCategoria.Items.Add("Scooter");
            cbCategoria.Items.Add("Triciclo");
            cbCategoria.Items.Add("Quadriciclo");

            // Veículos especiais
            cbCategoria.Items.Add("Buggy");
            cbCategoria.Items.Add("Off-Road / 4x4");
            cbCategoria.Items.Add("Motorhome");

            // Configuração final
            cbCategoria.SelectedIndex = -1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso - Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DefinirCorCamposObrigatorios(Color.Red);
                tbTempoUso.Focus();
                return;
            }

            Veiculo veiculo = new Veiculo();
            veiculo.id_modelo = (int) cbModelo.SelectedValue;
            veiculo.categoria = cbCategoria.SelectedItem.ToString();
            veiculo.tipo_combustivel = cbTipoCombustivel.SelectedItem.ToString();
            veiculo.tipo_cambio = cbTipoCambio.SelectedItem.ToString();
            veiculo.tempo_de_uso = Convert.ToInt32(tbTempoUso.Text);
            veiculo.kms_rodado = Convert.ToInt32(tbKmsRodado.Text);
            veiculo.final_placa = tbPlaca.Text;
            veiculo.cor = cbColor.SelectedItem.ToString();
            veiculo.status = cbStatus.SelectedIndex;
            veiculo.id_vendedor = (int) cbVendedor.SelectedValue;

            int response = veiculo.Cadastrar();
            if (response == 0)
            {
                MessageBox.Show("Não foi possível cadastrar o veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Veiculo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();
            }
        }


        private bool ValidarCampos()
        {
            if (cbModelo.SelectedIndex == -1 ||
            cbCategoria.SelectedIndex == -1 ||
            cbTipoCombustivel.SelectedIndex == -1 ||
            cbTipoCambio.SelectedIndex == -1 ||
            tbTempoUso.Text == "" ||
            tbKmsRodado.Text == "" ||
            tbPlaca.Text == "" ||
            cbColor.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            cbModelo.BackColor = color;
            cbCategoria.BackColor = color;
            cbTipoCombustivel.BackColor = color;
            cbTipoCambio.BackColor = color;
            tbTempoUso.BackColor = color;
            tbKmsRodado.BackColor = color;
            tbPlaca.BackColor = color;
            cbColor.BackColor = color;
        }

        private void Limpar()
        {
            cbModelo.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbTipoCombustivel.SelectedIndex = -1;
            cbTipoCambio.SelectedIndex = -1;
            tbTempoUso.Text = "";
            tbKmsRodado.Text = "";
            tbPlaca.Text = "";
            cbColor.SelectedIndex = -1;
            cbVendedor.SelectedIndex = -1;
        }
    }
}
