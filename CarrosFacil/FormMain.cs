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
