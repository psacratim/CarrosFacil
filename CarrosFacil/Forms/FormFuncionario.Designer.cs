
namespace CarrosFacil
{
    partial class FormFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTipoAcesso = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtbTelefoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefoneRecado = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDadosRegistro.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbNome.Location = new System.Drawing.Point(8, 59);
            this.tbNome.MaxLength = 60;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(483, 27);
            this.tbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22F);
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Funcionário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Social:";
            // 
            // tbNomeSocial
            // 
            this.tbNomeSocial.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbNomeSocial.Location = new System.Drawing.Point(8, 123);
            this.tbNomeSocial.MaxLength = 60;
            this.tbNomeSocial.Name = "tbNomeSocial";
            this.tbNomeSocial.Size = new System.Drawing.Size(481, 27);
            this.tbNomeSocial.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "* CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(121, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "RG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(497, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "* Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(497, 123);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(177, 27);
            this.cbSexo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(497, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "* Data de Nascimento";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "";
            this.dtpDataNascimento.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(497, 59);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(177, 27);
            this.dtpDataNascimento.TabIndex = 16;
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(220, 184);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(223, 27);
            this.cbCargo.TabIndex = 18;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F);
            this.label9.Location = new System.Drawing.Point(220, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cargo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.Location = new System.Drawing.Point(568, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Salário:";
            // 
            // tbSalario
            // 
            this.tbSalario.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbSalario.Location = new System.Drawing.Point(568, 184);
            this.tbSalario.MaxLength = 11;
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(106, 27);
            this.tbSalario.TabIndex = 20;
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(8, 126);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(151, 27);
            this.cbStatus.TabIndex = 31;
            // 
            // mtbRg
            // 
            this.mtbRg.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtbRg.Location = new System.Drawing.Point(121, 184);
            this.mtbRg.Mask = "00,000,000-0";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(93, 27);
            this.mtbRg.TabIndex = 24;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtbCpf.Location = new System.Drawing.Point(9, 184);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(106, 27);
            this.mtbCpf.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTipoAcesso);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbSenha);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbUsuario);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupBox2.Location = new System.Drawing.Point(187, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 165);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de Acesso";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbTipoAcesso
            // 
            this.cbTipoAcesso.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbTipoAcesso.FormattingEnabled = true;
            this.cbTipoAcesso.Location = new System.Drawing.Point(6, 126);
            this.cbTipoAcesso.Name = "cbTipoAcesso";
            this.cbTipoAcesso.Size = new System.Drawing.Size(366, 27);
            this.cbTipoAcesso.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.Location = new System.Drawing.Point(6, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "* Tipo de Acesso:";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbSenha.Location = new System.Drawing.Point(179, 57);
            this.tbSenha.MaxLength = 26;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(193, 27);
            this.tbSenha.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F);
            this.label14.Location = new System.Drawing.Point(179, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "* Senha:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbUsuario.Location = new System.Drawing.Point(6, 57);
            this.tbUsuario.MaxLength = 20;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(167, 27);
            this.tbUsuario.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14F);
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "* Usuário:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtbTelefoneResidencial);
            this.groupBox3.Controls.Add(this.mtbTelefoneCelular);
            this.groupBox3.Controls.Add(this.mtbTelefoneRecado);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupBox3.Location = new System.Drawing.Point(577, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 165);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de Contato";
            // 
            // mtbTelefoneResidencial
            // 
            this.mtbTelefoneResidencial.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtbTelefoneResidencial.Location = new System.Drawing.Point(257, 63);
            this.mtbTelefoneResidencial.Mask = "(00) 00000-0000";
            this.mtbTelefoneResidencial.Name = "mtbTelefoneResidencial";
            this.mtbTelefoneResidencial.Size = new System.Drawing.Size(115, 27);
            this.mtbTelefoneResidencial.TabIndex = 58;
            // 
            // mtbTelefoneCelular
            // 
            this.mtbTelefoneCelular.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtbTelefoneCelular.Location = new System.Drawing.Point(134, 63);
            this.mtbTelefoneCelular.Mask = "(00) 00000-0000";
            this.mtbTelefoneCelular.Name = "mtbTelefoneCelular";
            this.mtbTelefoneCelular.Size = new System.Drawing.Size(117, 27);
            this.mtbTelefoneCelular.TabIndex = 57;
            // 
            // mtbTelefoneRecado
            // 
            this.mtbTelefoneRecado.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtbTelefoneRecado.Location = new System.Drawing.Point(10, 63);
            this.mtbTelefoneRecado.Mask = "(00) 00000-0000";
            this.mtbTelefoneRecado.Name = "mtbTelefoneRecado";
            this.mtbTelefoneRecado.Size = new System.Drawing.Size(118, 27);
            this.mtbTelefoneRecado.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14F);
            this.label18.Location = new System.Drawing.Point(257, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 23);
            this.label18.TabIndex = 40;
            this.label18.Text = "T. Residencial";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F);
            this.label16.Location = new System.Drawing.Point(134, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 23);
            this.label16.TabIndex = 38;
            this.label16.Text = "T. Celular";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbEmail.Location = new System.Drawing.Point(10, 126);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(362, 27);
            this.tbEmail.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14F);
            this.label15.Location = new System.Drawing.Point(10, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 23);
            this.label15.TabIndex = 36;
            this.label15.Text = "Email:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14F);
            this.label17.Location = new System.Drawing.Point(10, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 23);
            this.label17.TabIndex = 32;
            this.label17.Text = "* T. Recado";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mtbCep);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.tbComplemento);
            this.groupBox4.Controls.Add(this.cbEstado);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.tbCidade);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.tbBairro);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.tbNumero);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.tbEndereco);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupBox4.Location = new System.Drawing.Point(11, 501);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(950, 186);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados de Endereço";
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtbCep.Location = new System.Drawing.Point(13, 65);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(80, 27);
            this.mtbCep.TabIndex = 25;
            this.mtbCep.TextChanged += new System.EventHandler(this.mtbCep_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 14F);
            this.label25.Location = new System.Drawing.Point(514, 111);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 23);
            this.label25.TabIndex = 55;
            this.label25.Text = "Complemento:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbComplemento.Location = new System.Drawing.Point(514, 140);
            this.tbComplemento.MaxLength = 200;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(424, 27);
            this.tbComplemento.TabIndex = 54;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(428, 140);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(80, 27);
            this.cbEstado.TabIndex = 53;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 14F);
            this.label24.Location = new System.Drawing.Point(428, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 23);
            this.label24.TabIndex = 52;
            this.label24.Text = "* Estado:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 14F);
            this.label23.Location = new System.Drawing.Point(13, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 23);
            this.label23.TabIndex = 50;
            this.label23.Text = "* Cidade:";
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbCidade.Location = new System.Drawing.Point(13, 140);
            this.tbCidade.MaxLength = 50;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(409, 27);
            this.tbCidade.TabIndex = 49;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 14F);
            this.label22.Location = new System.Drawing.Point(654, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 23);
            this.label22.TabIndex = 48;
            this.label22.Text = "* Bairro:";
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbBairro.Location = new System.Drawing.Point(654, 65);
            this.tbBairro.MaxLength = 32;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(284, 27);
            this.tbBairro.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 14F);
            this.label21.Location = new System.Drawing.Point(557, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 23);
            this.label21.TabIndex = 46;
            this.label21.Text = "* Número:";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbNumero.Location = new System.Drawing.Point(557, 65);
            this.tbNumero.MaxLength = 5;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(91, 27);
            this.tbNumero.TabIndex = 45;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 14F);
            this.label20.Location = new System.Drawing.Point(99, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 44;
            this.label20.Text = "* Endereço:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbEndereco.Location = new System.Drawing.Point(99, 65);
            this.tbEndereco.MaxLength = 60;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(452, 27);
            this.tbEndereco.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14F);
            this.label19.Location = new System.Drawing.Point(13, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 23);
            this.label19.TabIndex = 42;
            this.label19.Text = "CEP:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 16F);
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(293, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(387, 27);
            this.label26.TabIndex = 31;
            this.label26.Text = "Todos os campos com * são obrigatorios.";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(872, 693);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(7);
            this.btnSair.Size = new System.Drawing.Size(89, 46);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(305, 693);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(7);
            this.btnDeletar.Size = new System.Drawing.Size(111, 46);
            this.btnDeletar.TabIndex = 29;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(163, 693);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(7);
            this.btnAtualizar.Size = new System.Drawing.Size(122, 46);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(11, 693);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(7);
            this.btnCadastrar.Size = new System.Drawing.Size(132, 46);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbDadosRegistro
            // 
            this.gbDadosRegistro.Controls.Add(this.cbStatus);
            this.gbDadosRegistro.Controls.Add(this.label27);
            this.gbDadosRegistro.Controls.Add(this.label28);
            this.gbDadosRegistro.Controls.Add(this.tbCodigo);
            this.gbDadosRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbDadosRegistro.Location = new System.Drawing.Point(11, 99);
            this.gbDadosRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.gbDadosRegistro.Name = "gbDadosRegistro";
            this.gbDadosRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.gbDadosRegistro.Size = new System.Drawing.Size(169, 165);
            this.gbDadosRegistro.TabIndex = 113;
            this.gbDadosRegistro.TabStop = false;
            this.gbDadosRegistro.Text = "Registro";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 14F);
            this.label27.Location = new System.Drawing.Point(8, 99);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 23);
            this.label27.TabIndex = 39;
            this.label27.Text = "Status:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 14F);
            this.label28.Location = new System.Drawing.Point(7, 30);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 23);
            this.label28.TabIndex = 37;
            this.label28.Text = "Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbCodigo.Location = new System.Drawing.Point(7, 57);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigo.MaxLength = 20;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(151, 27);
            this.tbCodigo.TabIndex = 31;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbEstadoCivil);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.mtbCpf);
            this.groupBox5.Controls.Add(this.mtbRg);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.tbSalario);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbNome);
            this.groupBox5.Controls.Add(this.tbNomeSocial);
            this.groupBox5.Controls.Add(this.cbCargo);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cbSexo);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.dtpDataNascimento);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox5.Location = new System.Drawing.Point(11, 272);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(684, 222);
            this.groupBox5.TabIndex = 114;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dados Pessoais";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Location = new System.Drawing.Point(449, 184);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(113, 27);
            this.cbEstadoCivil.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(449, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Estado Civil:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(703, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(258, 222);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto (Clique na foto pra mudar)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F);
            this.label11.Location = new System.Drawing.Point(97, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Sem foto";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbDadosRegistro);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormFuncionario";
            this.Text = "a";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDadosRegistro.ResumeLayout(false);
            this.gbDadosRegistro.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomeSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneResidencial;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneRecado;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbTipoAcesso;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox gbDadosRegistro;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}