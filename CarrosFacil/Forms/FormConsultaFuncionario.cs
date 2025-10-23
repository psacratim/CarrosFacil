using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace CarrosFacil.Forms
{
    public partial class FormConsultaFuncionario : Form
    {
        public FormConsultaFuncionario()
        {
            InitializeComponent();        
        }

        private void FormConsultaFuncionario_Load(object sender, System.EventArgs e)
        {
            // CARREGANDO OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Cargo");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Data de Admissão");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.SelectedIndex = 0;

            // CARREGANDO SEXOS
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.SelectedIndex = 0;

            // CARGO - ALIMENTADA PELO DB
            _ = Task.Run(() =>
            {
                // CIDADES
                Funcionario funcionario = new Funcionario();
                DataTable cidades = funcionario.CarregarCidades();

                // Cargos
                Cargo cargo = new Cargo();
                DataTable cargos = cargo.CarregarCargo();

                this.Invoke((Action)(() =>
                {
                    cbCargo.DataSource = cargos;
                    cbCargo.DisplayMember = "nome";
                    cbCargo.ValueMember = "id";
                    cbCargo.SelectedIndex = 0;

                    cbCidade.DataSource = cidades;
                    cbCidade.DisplayMember = "cidade";
                    cbCidade.ValueMember = "cidade";
                    cbCidade.SelectedValue = "Piracicaba";
                }));
            });
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Versão curta, mas vários IFs. (Isso não importa muito, mas a manutenção pode ser melhorada)
            gbTipoPesquisa.Enabled = cbOpcoes.SelectedIndex == 0;
            gbNome.Enabled = cbOpcoes.SelectedIndex == 0;
            gbCPF.Enabled = cbOpcoes.SelectedIndex == 1;
            gbCargo.Enabled = cbOpcoes.SelectedIndex == 2;
            gbSexo.Enabled = cbOpcoes.SelectedIndex == 3;
            gbCidade.Enabled = cbOpcoes.SelectedIndex == 4;
            gbDataAdmissao.Enabled = cbOpcoes.SelectedIndex == 5;
            gbStatus.Enabled = cbOpcoes.SelectedIndex == 6;
        }

        private void PesquisarPorNome()
        {
            if (txtNome.Text == "") {
                MessageBox.Show("Por favor, digite um nome válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.Red;
                txtNome.Focus();
                return;
            }

            dgvFuncionario.DataSource = new Funcionario().ConsultarPorNome(txtNome.Text, rbInicio.Checked);
        }

        private void PesquisarPorCPF()
        {
            if (mskCpf.MaskFull)
            {
                dgvFuncionario.DataSource = new Funcionario().ConsultarPorCpf(mskCpf.Text);
            } else
            {
                MessageBox.Show("Por favor, insira um cpf completo e válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbCPF.BackColor = Color.Red;
                gbCPF.Focus();
            }
        }

        private void PesquisarPorCargo()
        {
            dgvFuncionario.DataSource = new Funcionario().ConsultarPorCargo((int) cbCargo.SelectedValue);
        }

        private void PesquisarPorSexo()
        {
            dgvFuncionario.DataSource = new Funcionario().ConsultarPorSexo(cbSexo.SelectedItem.ToString().Substring(0, 1));
        }

        private void PesquisarPorCidade()
        {
            dgvFuncionario.DataSource = new Funcionario().ConsultarPorCidade(cbCidade.SelectedValue.ToString());
        }

        private void PesquisarPorDataAdmissao()
        {
            dgvFuncionario.DataSource = new Funcionario().ConsultarPorDataAdmissao(dtpDataInicial.Value, dtpDataFinal.Value);
        }
        private void PesquisarPorStatus()
        {
            dgvFuncionario.DataSource = new Funcionario().ConsultarPorStatus(rbAtivo.Checked ? 1 : 0);
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            switch (cbOpcoes.SelectedIndex)
            {
                case 1:
                    PesquisarPorCPF();
                    break;

                case 2:
                    PesquisarPorCargo();
                    break;

                case 3:
                    PesquisarPorSexo();
                    break;

                case 4:
                    PesquisarPorCidade();
                    break;

                case 5:
                    PesquisarPorDataAdmissao();
                    break;

                case 6:
                    PesquisarPorStatus();
                    break;

                default:
                    PesquisarPorNome();
                    break;
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFuncionario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir o funcionário selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                // Cria o funcionario e obtém os dados.
                Funcionario funcionario = new Funcionario();
                funcionario.ConsultaFuncionario(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));

                // Define os campos do funcionário
                FormFuncionario formFuncionario = new FormFuncionario();
                formFuncionario.tbCodigo.Text = funcionario.id.ToString();
                formFuncionario.tbUsuario.Text = funcionario.usuario;
                formFuncionario.tbSenha.Text = funcionario.senha;
                formFuncionario.tipo_acesso = funcionario.tipo_acesso;
                formFuncionario.mtbTelefoneRecado.Text = funcionario.telefone_recado;
                formFuncionario.mtbTelefoneCelular.Text = funcionario.telefone_celular;
                formFuncionario.mtbTelefoneResidencial.Text = funcionario.telefone_residencial;
                formFuncionario.tbEmail.Text = funcionario.email;
                formFuncionario.tbNome.Text = funcionario.nome;
                formFuncionario.dtpDataNascimento.Value = funcionario.data_nascimento;
                formFuncionario.tbNomeSocial.Text = funcionario.nome_social;
                formFuncionario.sexo = funcionario.sexo;

                formFuncionario.cbSexo.Text = funcionario.sexo;
                formFuncionario.mtbCpf.Text = funcionario.cpf;
                formFuncionario.mtbRg.Text = funcionario.rg;
                formFuncionario.cargo = funcionario.id_cargo;
                formFuncionario.estado_civil = funcionario.estado_civil;
                formFuncionario.tbSalario.Text = funcionario.salario.ToString().Replace(".", ",");
                formFuncionario.mtbCep.Text = funcionario.cep;
                formFuncionario.tbEndereco.Text = funcionario.endereco;
                formFuncionario.tbNumero.Text = funcionario.numero.ToString();
                formFuncionario.tbBairro.Text = funcionario.bairro;
                formFuncionario.tbCidade.Text = funcionario.cidade;
                formFuncionario.estado = funcionario.estado;
                formFuncionario.tbComplemento.Text = funcionario.complemento;
                formFuncionario.data_cadastro = funcionario.data_cadastro;

                // Altera o tipo do funcionario.
                formFuncionario.tipo = "Atualização";

                // Modo exclusivo (ShowDialog)
                formFuncionario.ShowDialog();

                // Atualiza a grid de consulta.
                btPesquisar_Click(this, new EventArgs());
            }
        }
    }
}
