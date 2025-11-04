using CarrosFacil.Forms;
using CarrosFacil.Forms.Consultas;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            statusLbData.Text = DateTime.Now.ToShortDateString();
            statusLbHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja fechar o sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuCadCargos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCargo>().Count() > 0)
            {
                MessageBox.Show("O cadastro de cargos já está aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormCargo formCargo = new FormCargo();
            formCargo.Show();
        }

        private void menuCadFuncionarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFuncionario>().Count() > 0)
            {
                MessageBox.Show("O cadastro de funcionários já está aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormFuncionario formFuncionario = new FormFuncionario();
            formFuncionario.Show();
        }

        private void menuCadMarcas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormMarca>().Count() > 0)
            {
                MessageBox.Show("O cadastro de marcas já está aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormMarca formMarca = new FormMarca();
            formMarca.Show();
        }

        private void menuCadModelos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormModelo>().Count() > 0)
            {
                MessageBox.Show("O cadastro de modelos já está aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormModelo formModelo = new FormModelo();
            formModelo.Show();
        }

        private void menuCadCaracteristicas_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FormCaracteristica>().Count() > 0)
            {
                MessageBox.Show("O cadastro de características já está aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormCaracteristica formCaracteristicas = new FormCaracteristica();
            formCaracteristicas.Show();
        }

        private void menuCadCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCliente>().Count() > 0)
            {
                MessageBox.Show("O cadastro de cliente já está aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void menuCadVeiculo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormVeiculo>().Count() > 0)
            {
                MessageBox.Show("O cadastro de veículos já está aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormVeiculo formVeiculo = new FormVeiculo();
            formVeiculo.Show();
        }

        private void menuConsFuncionarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsFuncionario>().Count() > 0)
            {
                MessageBox.Show("A consulta de funcionarios já está aberta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormConsFuncionario form = new FormConsFuncionario();
            form.Show();
        }

        private void menuConsClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsCliente>().Count() > 0)
            {
                MessageBox.Show("A consulta de clientes já está aberta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormConsCliente form = new FormConsCliente();
            form.Show();
        }

        private void menuConsVeiculos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsVeiculo>().Count() > 0)
            {
                MessageBox.Show("A consulta de veiculos já está aberta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormConsVeiculo form = new FormConsVeiculo();
            form.Show();
        }


        //private void menuCadMDI_Click(object sender, EventArgs e)
        //{
        //    FormMDI formMDI = new FormMDI();
        //    formMDI.MdiParent = this; // O Parent deve ser isMdiContainer.
        //    formMDI.Show();
        //}

        //private void menuCadSDI_Click(object sender, EventArgs e)
        //{
        //    FormSDI formSDI = new FormSDI();
        //    formSDI.Show();
        //}
    }
}
