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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            //ESTADOS
            cbEstado.Items.Add("AC"); // Acre
            cbEstado.Items.Add("AL"); // Alagoas
            cbEstado.Items.Add("AP"); // Amapá
            cbEstado.Items.Add("AM"); // Amazonas
            cbEstado.Items.Add("BA"); // Bahia
            cbEstado.Items.Add("CE"); // Ceará
            cbEstado.Items.Add("DF"); // Distrito Federal
            cbEstado.Items.Add("ES"); // Espírito Santo
            cbEstado.Items.Add("GO"); // Goiás
            cbEstado.Items.Add("MA"); // Maranhão
            cbEstado.Items.Add("MT"); // Mato Grosso
            cbEstado.Items.Add("MS"); // Mato Grosso do Sul
            cbEstado.Items.Add("MG"); // Minas Gerais
            cbEstado.Items.Add("PA"); // Pará
            cbEstado.Items.Add("PB"); // Paraíba
            cbEstado.Items.Add("PR"); // Paraná
            cbEstado.Items.Add("PE"); // Pernambuco
            cbEstado.Items.Add("PI"); // Piauí
            cbEstado.Items.Add("RJ"); // Rio de Janeiro
            cbEstado.Items.Add("RN"); // Rio Grande do Norte
            cbEstado.Items.Add("RS"); // Rio Grande do Sul
            cbEstado.Items.Add("RO"); // Rondônia
            cbEstado.Items.Add("RR"); // Roraima
            cbEstado.Items.Add("SC"); // Santa Catarina
            cbEstado.Items.Add("SP"); // São Paulo
            cbEstado.Items.Add("SE"); // Sergipe
            cbEstado.Items.Add("TO"); // Tocantins
            cbEstado.SelectedItem = "SP";

            //ESTADOS CIVIL
            cbEstadoCivil.Items.Add("Solteiro(a)");
            cbEstadoCivil.Items.Add("Casado(a)");
            cbEstadoCivil.Items.Add("Separado(a)");
            cbEstadoCivil.Items.Add("Divorciado(a)");
            cbEstadoCivil.Items.Add("Viúvo(a)");
            cbEstadoCivil.SelectedIndex = 0;

            //TipoAcesso de acesso
            cbTipoAcesso.Items.Add("Comum");
            cbTipoAcesso.Items.Add("Administrador");
            cbTipoAcesso.SelectedIndex = 0;

            // CARGO - ALIMENTADA PELO DB
            cB
        }
    }
}
