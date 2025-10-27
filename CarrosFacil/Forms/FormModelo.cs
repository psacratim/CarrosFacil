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

namespace CarrosFacil
{
    public partial class FormModelo : Form
    {
        public FormModelo()
        {
            InitializeComponent();
        }

        private void FormModelo_Load(object sender, EventArgs e)
        {
            // STATUS
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            //MARCAS - ALIMENTADA PELO DB
            _ = Task.Run(() =>
            {
                Marca marca = new Marca();
                DataTable marcas = marca.CarregarMarcas();

                try // TODO: Adicionar isso em todos os outros tasks.
                {
                    this.Invoke((Action)(() =>
                    {
                        cbMarca.DataSource = marcas;
                        cbMarca.DisplayMember = "nome";
                        cbMarca.ValueMember = "id";
                        cbMarca.SelectedIndex = -1;
                    }));
                }
                catch (Exception) { }
            });
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.Red);

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Modelo modelo = new Modelo();
            modelo.id_marca = (int) cbMarca.SelectedValue;
            modelo.nome = tbNome.Text;
            modelo.observacao = tbObservacao.Text;

            int resultado = modelo.Cadastrar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao cadastrar modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Modelo: " + modelo.nome + " cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }

        private bool ValidarCampos()
        {
            if (cbMarca.SelectedIndex == -1 || tbNome.Text == "")
            {
                return false;
            }

            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            tbNome.BackColor = color;
            cbMarca.BackColor = color;
        }

        private void Limpar()
        {
            tbNome.Clear();
            tbObservacao.Clear();
            cbMarca.SelectedIndex = -1;
        }
    }
}
