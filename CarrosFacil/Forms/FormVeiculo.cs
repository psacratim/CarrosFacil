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
            cbTipoCombustivel.Items.Add("GNV (Gás Natural Veicular)");
            cbTipoCombustivel.SelectedIndex = -1;

            // Tipo de câmbio
            cbTipoCambio.Items.Add("Manual");
            cbTipoCambio.Items.Add("Automático Tradicional");
            cbTipoCambio.Items.Add("CVT");
            cbTipoCambio.Items.Add("Automatizado (Monoembreagem)");
            cbTipoCambio.Items.Add("DCT (Automático de Dupla Embreagem)");
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

            if (tbPrecoVenda.Text == "")
            {
                MessageBox.Show("Por favor, insira o preço do veículo e o percentual de lucro.", "Aviso - Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tbCusto.BackColor = Color.Red;
                tbLucro.BackColor = Color.Red;
                return;
            }

            Veiculo veiculo = new Veiculo();
            veiculo.id_modelo = (int) cbModelo.SelectedValue;
            veiculo.categoria = cbCategoria.SelectedItem.ToString();
            veiculo.estado_do_veiculo = cbEstadoVeiculo.SelectedItem.ToString();
            veiculo.tempo_de_uso = Convert.ToInt32(tbTempoUso.Text);
            veiculo.preco = Convert.ToDecimal(tbPrecoVenda.Text);
            veiculo.kms_rodado = Convert.ToInt32(tbKmsRodado.Text);
            veiculo.final_placa = tbPlaca.Text;
            veiculo.cor = cbColor.SelectedItem.ToString();
            veiculo.descricao = tbDescricao.Text;
            veiculo.ano = Convert.ToInt32(tbAno.Text);
            veiculo.tipo_cambio = cbTipoCambio.SelectedItem.ToString();
            veiculo.tipo_combustivel = cbTipoCombustivel.SelectedItem.ToString();
            veiculo.estoque = 0;
            veiculo.status = 1;

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
            cbEstadoVeiculo.SelectedIndex == -1 ||
            tbTempoUso.Text == "" ||
            tbKmsRodado.Text == "" ||
            tbPlaca.Text == "" ||
            cbColor.SelectedIndex == -1 ||
            tbDescricao.Text == "" ||
            tbAno.Text == "" ||
            cbTipoCambio.SelectedIndex == -1 ||
            cbTipoCombustivel.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            cbModelo.BackColor = color;
            cbCategoria.BackColor = color;
            cbEstadoVeiculo.BackColor = color;
            tbTempoUso.BackColor = color;
            tbKmsRodado.BackColor = color;
            tbPlaca.BackColor = color;
            cbColor.BackColor = color;
            tbDescricao.BackColor = color;
            tbAno.BackColor = color;
            cbTipoCambio.BackColor = color;
            cbTipoCombustivel.BackColor = color;
            tbCusto.BackColor = color;
            tbLucro.BackColor = color;
        }

        private void Limpar()
        {
            cbModelo.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbEstadoVeiculo.SelectedIndex = -1;
            tbTempoUso.Clear();
            tbKmsRodado.Clear();
            tbPlaca.Clear();
            cbColor.SelectedIndex = -1;
            tbDescricao.Clear();
            tbAno.Clear();
            cbTipoCambio.SelectedIndex = -1;
            cbTipoCombustivel.SelectedIndex = -1;
            tbPrecoVenda.Clear();
            tbCusto.Clear();
            tbLucro.Clear();
        }

        private void tbDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPercentualLucro_TextChanged(object sender, EventArgs e)
        {
            AtualizarPrecoVendas();
        }

        private void tbPreco_TextChanged(object sender, EventArgs e)
        {
            AtualizarPrecoVendas();
        }

        private void AtualizarPrecoVendas()
        {
            // 1. Se não tem nada escrito em preço de veículo ou em % de lucro = return; ---> Aguardando ele digitar todos
            // 2. Converta todos os números para decimais.
            // 3. Calculate o preço de venda.
            // 4. Mostre ao usuário
            // 5. Resposta visual ao usuário apenas para erros de: lucro menor que 1, digite apenas números.
            if (tbCusto.Text == "" || tbLucro.Text == "") return;

            decimal preco = SafeDecimalConvert(tbCusto.Text, "Por favor, digite apenas números válidos!");
            decimal percentualLucro = SafeDecimalConvert(tbLucro.Text, "Por favor, digite apenas números válidos!");

            if (percentualLucro < 1)
            {
                MessageBox.Show("Por favor, insira um lucro maior ou igual a 1%.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal fatorLucro = 1 + (percentualLucro / 100); // Output: 1 + (50 / 100) -> 1 + 0,5 -> 1,5. Result: price + 1,5 -> final_price;
            decimal precoVenda = preco * fatorLucro;
            decimal lucroObtido = precoVenda - preco;

            tbPrecoVenda.Text = Convert.ToString(precoVenda);
        }

        private decimal SafeDecimalConvert(string text, string errorMessage)
        {
            try
            {
                return Convert.ToDecimal(text);
            } catch (FormatException)
            {
                MessageBox.Show(errorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        private void tbTempoUso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Char 08: BACKSPACE
            // Char 27: Escape
            // Char 44: ,
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTempoUso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPercentualLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && tbPlaca.Text.Length >= 1)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas o último digito da placa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbKmsRodado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
