
namespace CarrosFacil.Forms
{
    partial class FormVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVeiculo));
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstadoVeiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.cbTipoCambio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTempoUso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrecoCusto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKmsRodado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.MaskedTextBox();
            this.tbLucro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbPrecoVenda = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDescontoNao = new System.Windows.Forms.RadioButton();
            this.rbDescontoSim = new System.Windows.Forms.RadioButton();
            this.tbPrecoDesconto = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.gbEspecificacoes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbFoto = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbAdicionar = new System.Windows.Forms.Button();
            this.tbRemoverSelecionado = new System.Windows.Forms.Button();
            this.gbPrecoVenda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDadosRegistro.SuspendLayout();
            this.gbEspecificacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(7, 53);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(326, 29);
            this.cbModelo.TabIndex = 71;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(611, 641);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 39);
            this.btnSair.TabIndex = 70;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeletar.Enabled = false;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(163, 641);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(111, 39);
            this.btnDeletar.TabIndex = 69;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(280, 641);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(122, 39);
            this.btnAtualizar.TabIndex = 68;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 641);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 39);
            this.btnCadastrar.TabIndex = 67;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(339, 53);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(321, 29);
            this.cbCategoria.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.label12.Location = new System.Drawing.Point(560, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 32);
            this.label12.TabIndex = 65;
            this.label12.Text = "Cadastrar Veículo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label26.Location = new System.Drawing.Point(462, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(411, 30);
            this.label26.TabIndex = 64;
            this.label26.Text = "Todos os campos com * são obrigatorios.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "* Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(339, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "* Categoria:";
            // 
            // cbEstadoVeiculo
            // 
            this.cbEstadoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbEstadoVeiculo.FormattingEnabled = true;
            this.cbEstadoVeiculo.Location = new System.Drawing.Point(7, 118);
            this.cbEstadoVeiculo.Name = "cbEstadoVeiculo";
            this.cbEstadoVeiculo.Size = new System.Drawing.Size(184, 29);
            this.cbEstadoVeiculo.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "* Estado do veículo:";
            // 
            // cbTipoCombustivel
            // 
            this.cbTipoCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCombustivel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbTipoCombustivel.FormattingEnabled = true;
            this.cbTipoCombustivel.Location = new System.Drawing.Point(8, 53);
            this.cbTipoCombustivel.Name = "cbTipoCombustivel";
            this.cbTipoCombustivel.Size = new System.Drawing.Size(141, 29);
            this.cbTipoCombustivel.TabIndex = 79;
            // 
            // cbTipoCambio
            // 
            this.cbTipoCambio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbTipoCambio.FormattingEnabled = true;
            this.cbTipoCambio.Location = new System.Drawing.Point(155, 53);
            this.cbTipoCambio.Name = "cbTipoCambio";
            this.cbTipoCambio.Size = new System.Drawing.Size(247, 29);
            this.cbTipoCambio.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 77;
            this.label3.Text = "* Combustivel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(155, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "* Tipo de câmbio:";
            // 
            // tbTempoUso
            // 
            this.tbTempoUso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTempoUso.Location = new System.Drawing.Point(339, 118);
            this.tbTempoUso.MaxLength = 5;
            this.tbTempoUso.Name = "tbTempoUso";
            this.tbTempoUso.Size = new System.Drawing.Size(184, 29);
            this.tbTempoUso.TabIndex = 82;
            this.tbTempoUso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTempoUso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(339, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 21);
            this.label7.TabIndex = 83;
            this.label7.Text = "* Tempo de uso: (dias)";
            // 
            // tbPrecoCusto
            // 
            this.tbPrecoCusto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPrecoCusto.Location = new System.Drawing.Point(6, 53);
            this.tbPrecoCusto.MaxLength = 11;
            this.tbPrecoCusto.Name = "tbPrecoCusto";
            this.tbPrecoCusto.Size = new System.Drawing.Size(156, 29);
            this.tbPrecoCusto.TabIndex = 84;
            this.tbPrecoCusto.TextChanged += new System.EventHandler(this.tbPreco_TextChanged);
            this.tbPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPreco_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 85;
            this.label8.Text = "* Preço Custo:";
            // 
            // tbKmsRodado
            // 
            this.tbKmsRodado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbKmsRodado.Location = new System.Drawing.Point(594, 53);
            this.tbKmsRodado.MaxLength = 7;
            this.tbKmsRodado.Name = "tbKmsRodado";
            this.tbKmsRodado.Size = new System.Drawing.Size(73, 29);
            this.tbKmsRodado.TabIndex = 86;
            this.tbKmsRodado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKmsRodado_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(594, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 87;
            this.label9.Text = "* KMs:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPlaca.Location = new System.Drawing.Point(529, 120);
            this.tbPlaca.MaxLength = 1;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(131, 29);
            this.tbPlaca.TabIndex = 90;
            this.tbPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlaca_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(529, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 21);
            this.label11.TabIndex = 91;
            this.label11.Text = "* Final da placa:";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(408, 53);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(115, 29);
            this.cbColor.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.Location = new System.Drawing.Point(408, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 21);
            this.label13.TabIndex = 92;
            this.label13.Text = "* Cor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.Location = new System.Drawing.Point(529, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 21);
            this.label14.TabIndex = 95;
            this.label14.Text = "* Ano:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDescricao.Location = new System.Drawing.Point(7, 188);
            this.tbDescricao.MaxLength = 250;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(653, 76);
            this.tbDescricao.TabIndex = 102;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label18.Location = new System.Drawing.Point(7, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 21);
            this.label18.TabIndex = 103;
            this.label18.Text = "* Descrição:";
            // 
            // tbAno
            // 
            this.tbAno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbAno.Location = new System.Drawing.Point(529, 53);
            this.tbAno.Mask = "0000";
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(59, 29);
            this.tbAno.TabIndex = 106;
            // 
            // tbLucro
            // 
            this.tbLucro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLucro.Location = new System.Drawing.Point(6, 118);
            this.tbLucro.MaxLength = 5;
            this.tbLucro.Name = "tbLucro";
            this.tbLucro.Size = new System.Drawing.Size(156, 29);
            this.tbLucro.TabIndex = 107;
            this.tbLucro.TextChanged += new System.EventHandler(this.tbPercentualLucro_TextChanged);
            this.tbLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPercentualLucro_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(6, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 108;
            this.label10.Text = "* Lucro: (%)";
            // 
            // gbPrecoVenda
            // 
            this.gbPrecoVenda.Controls.Add(this.groupBox3);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoDesconto);
            this.gbPrecoVenda.Controls.Add(this.label20);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoVenda);
            this.gbPrecoVenda.Controls.Add(this.label17);
            this.gbPrecoVenda.Controls.Add(this.tbDesconto);
            this.gbPrecoVenda.Controls.Add(this.label5);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoCusto);
            this.gbPrecoVenda.Controls.Add(this.label8);
            this.gbPrecoVenda.Controls.Add(this.tbLucro);
            this.gbPrecoVenda.Controls.Add(this.label10);
            this.gbPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gbPrecoVenda.Location = new System.Drawing.Point(201, 92);
            this.gbPrecoVenda.Name = "gbPrecoVenda";
            this.gbPrecoVenda.Size = new System.Drawing.Size(497, 156);
            this.gbPrecoVenda.TabIndex = 111;
            this.gbPrecoVenda.TabStop = false;
            this.gbPrecoVenda.Text = "Calcular preço de venda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDescontoNao);
            this.groupBox3.Controls.Add(this.rbDescontoSim);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.Location = new System.Drawing.Point(169, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 53);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ativar desconto?";
            // 
            // rbDescontoNao
            // 
            this.rbDescontoNao.AutoSize = true;
            this.rbDescontoNao.Checked = true;
            this.rbDescontoNao.Location = new System.Drawing.Point(92, 26);
            this.rbDescontoNao.Name = "rbDescontoNao";
            this.rbDescontoNao.Size = new System.Drawing.Size(57, 25);
            this.rbDescontoNao.TabIndex = 117;
            this.rbDescontoNao.TabStop = true;
            this.rbDescontoNao.Text = "Não";
            this.rbDescontoNao.UseVisualStyleBackColor = true;
            this.rbDescontoNao.CheckedChanged += new System.EventHandler(this.rbDescontoNao_CheckedChanged);
            // 
            // rbDescontoSim
            // 
            this.rbDescontoSim.AutoSize = true;
            this.rbDescontoSim.Location = new System.Drawing.Point(7, 26);
            this.rbDescontoSim.Name = "rbDescontoSim";
            this.rbDescontoSim.Size = new System.Drawing.Size(55, 25);
            this.rbDescontoSim.TabIndex = 116;
            this.rbDescontoSim.Text = "Sim";
            this.rbDescontoSim.UseVisualStyleBackColor = true;
            this.rbDescontoSim.CheckedChanged += new System.EventHandler(this.rbDescontoSim_CheckedChanged);
            // 
            // tbPrecoDesconto
            // 
            this.tbPrecoDesconto.Enabled = false;
            this.tbPrecoDesconto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPrecoDesconto.Location = new System.Drawing.Point(332, 53);
            this.tbPrecoDesconto.MaxLength = 11;
            this.tbPrecoDesconto.Name = "tbPrecoDesconto";
            this.tbPrecoDesconto.Size = new System.Drawing.Size(156, 29);
            this.tbPrecoDesconto.TabIndex = 113;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label20.Location = new System.Drawing.Point(332, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 21);
            this.label20.TabIndex = 114;
            this.label20.Text = "* Preço Desconto:";
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Enabled = false;
            this.tbPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPrecoVenda.Location = new System.Drawing.Point(169, 53);
            this.tbPrecoVenda.MaxLength = 11;
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(156, 29);
            this.tbPrecoVenda.TabIndex = 111;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label17.Location = new System.Drawing.Point(169, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 21);
            this.label17.TabIndex = 112;
            this.label17.Text = "* Preço Venda:";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Enabled = false;
            this.tbDesconto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDesconto.Location = new System.Drawing.Point(332, 118);
            this.tbDesconto.MaxLength = 5;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(156, 29);
            this.tbDesconto.TabIndex = 109;
            this.tbDesconto.TextChanged += new System.EventHandler(this.tbDesconto_TextChanged);
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesconto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(332, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 110;
            this.label5.Text = "Desconto: (%)";
            // 
            // gbDadosRegistro
            // 
            this.gbDadosRegistro.Controls.Add(this.label19);
            this.gbDadosRegistro.Controls.Add(this.label16);
            this.gbDadosRegistro.Controls.Add(this.cbStatus);
            this.gbDadosRegistro.Controls.Add(this.tbCodigoVeiculo);
            this.gbDadosRegistro.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gbDadosRegistro.Location = new System.Drawing.Point(25, 92);
            this.gbDadosRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.gbDadosRegistro.Name = "gbDadosRegistro";
            this.gbDadosRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.gbDadosRegistro.Size = new System.Drawing.Size(169, 156);
            this.gbDadosRegistro.TabIndex = 112;
            this.gbDadosRegistro.TabStop = false;
            this.gbDadosRegistro.Text = "Registro";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label19.Location = new System.Drawing.Point(8, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 21);
            this.label19.TabIndex = 37;
            this.label19.Text = "Código Veículo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.Location = new System.Drawing.Point(8, 92);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 21);
            this.label16.TabIndex = 39;
            this.label16.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(8, 118);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(147, 29);
            this.cbStatus.TabIndex = 31;
            // 
            // tbCodigoVeiculo
            // 
            this.tbCodigoVeiculo.Enabled = false;
            this.tbCodigoVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbCodigoVeiculo.Location = new System.Drawing.Point(8, 53);
            this.tbCodigoVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigoVeiculo.MaxLength = 20;
            this.tbCodigoVeiculo.Name = "tbCodigoVeiculo";
            this.tbCodigoVeiculo.Size = new System.Drawing.Size(147, 29);
            this.tbCodigoVeiculo.TabIndex = 31;
            // 
            // gbEspecificacoes
            // 
            this.gbEspecificacoes.Controls.Add(this.cbTipoCombustivel);
            this.gbEspecificacoes.Controls.Add(this.label3);
            this.gbEspecificacoes.Controls.Add(this.cbTipoCambio);
            this.gbEspecificacoes.Controls.Add(this.tbAno);
            this.gbEspecificacoes.Controls.Add(this.label6);
            this.gbEspecificacoes.Controls.Add(this.label13);
            this.gbEspecificacoes.Controls.Add(this.cbColor);
            this.gbEspecificacoes.Controls.Add(this.label9);
            this.gbEspecificacoes.Controls.Add(this.label14);
            this.gbEspecificacoes.Controls.Add(this.tbKmsRodado);
            this.gbEspecificacoes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gbEspecificacoes.Location = new System.Drawing.Point(25, 256);
            this.gbEspecificacoes.Margin = new System.Windows.Forms.Padding(4);
            this.gbEspecificacoes.Name = "gbEspecificacoes";
            this.gbEspecificacoes.Padding = new System.Windows.Forms.Padding(4);
            this.gbEspecificacoes.Size = new System.Drawing.Size(674, 93);
            this.gbEspecificacoes.TabIndex = 113;
            this.gbEspecificacoes.TabStop = false;
            this.gbEspecificacoes.Text = "Especificações:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEstoque);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbModelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbDescricao);
            this.groupBox1.Controls.Add(this.cbEstadoVeiculo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPlaca);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbTempoUso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox1.Location = new System.Drawing.Point(25, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 277);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do veículo";
            // 
            // tbEstoque
            // 
            this.tbEstoque.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbEstoque.Location = new System.Drawing.Point(197, 118);
            this.tbEstoque.MaxLength = 5;
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(136, 29);
            this.tbEstoque.TabIndex = 104;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.Location = new System.Drawing.Point(197, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 21);
            this.label15.TabIndex = 105;
            this.label15.Text = "* Estoque:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCaracteristicas);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox2.Location = new System.Drawing.Point(713, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(597, 287);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características:";
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Location = new System.Drawing.Point(7, 26);
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.Size = new System.Drawing.Size(583, 254);
            this.dgvCaracteristicas.TabIndex = 115;
            this.dgvCaracteristicas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCaracteristicas_CellMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbFoto);
            this.groupBox4.Controls.Add(this.pbFoto);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox4.Location = new System.Drawing.Point(713, 387);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(597, 293);
            this.groupBox4.TabIndex = 116;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Foto do veículo (Clique na foto para mudar)";
            // 
            // lbFoto
            // 
            this.lbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFoto.AutoSize = true;
            this.lbFoto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbFoto.Location = new System.Drawing.Point(278, 267);
            this.lbFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(64, 19);
            this.lbFoto.TabIndex = 40;
            this.lbFoto.Text = "Sem foto";
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(195, 31);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Padding = new System.Windows.Forms.Padding(10);
            this.pbFoto.Size = new System.Drawing.Size(230, 230);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // tbAdicionar
            // 
            this.tbAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAdicionar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbAdicionar.ForeColor = System.Drawing.Color.Black;
            this.tbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("tbAdicionar.Image")));
            this.tbAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAdicionar.Location = new System.Drawing.Point(956, 51);
            this.tbAdicionar.Name = "tbAdicionar";
            this.tbAdicionar.Size = new System.Drawing.Size(124, 39);
            this.tbAdicionar.TabIndex = 117;
            this.tbAdicionar.Text = "Adicionar";
            this.tbAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbAdicionar.UseVisualStyleBackColor = false;
            this.tbAdicionar.Click += new System.EventHandler(this.tbAdicionar_Click);
            // 
            // tbRemoverSelecionado
            // 
            this.tbRemoverSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbRemoverSelecionado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbRemoverSelecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbRemoverSelecionado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbRemoverSelecionado.ForeColor = System.Drawing.Color.Black;
            this.tbRemoverSelecionado.Image = ((System.Drawing.Image)(resources.GetObject("tbRemoverSelecionado.Image")));
            this.tbRemoverSelecionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRemoverSelecionado.Location = new System.Drawing.Point(1086, 51);
            this.tbRemoverSelecionado.Name = "tbRemoverSelecionado";
            this.tbRemoverSelecionado.Size = new System.Drawing.Size(224, 39);
            this.tbRemoverSelecionado.TabIndex = 118;
            this.tbRemoverSelecionado.Text = "Remover selecionado";
            this.tbRemoverSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbRemoverSelecionado.UseVisualStyleBackColor = false;
            this.tbRemoverSelecionado.Click += new System.EventHandler(this.tbRemoverSelecionado_Click);
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 688);
            this.Controls.Add(this.tbRemoverSelecionado);
            this.Controls.Add(this.tbAdicionar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEspecificacoes);
            this.Controls.Add(this.gbDadosRegistro);
            this.Controls.Add(this.gbPrecoVenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label26);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciando - Veiculo";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            this.gbPrecoVenda.ResumeLayout(false);
            this.gbPrecoVenda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbDadosRegistro.ResumeLayout(false);
            this.gbDadosRegistro.PerformLayout();
            this.gbEspecificacoes.ResumeLayout(false);
            this.gbEspecificacoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbModelo;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnDeletar;
        public System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbEstadoVeiculo;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbTipoCombustivel;
        public System.Windows.Forms.ComboBox cbTipoCambio;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbTempoUso;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbPrecoCusto;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbKmsRodado;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbPlaca;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cbColor;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tbDescricao;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.MaskedTextBox tbAno;
        public System.Windows.Forms.TextBox tbLucro;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox gbPrecoVenda;
        public System.Windows.Forms.GroupBox gbDadosRegistro;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox tbCodigoVeiculo;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.GroupBox gbEspecificacoes;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvCaracteristicas;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbPrecoDesconto;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tbPrecoVenda;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox tbDesconto;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbEstoque;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.PictureBox pbFoto;
        public System.Windows.Forms.Label lbFoto;
        public System.Windows.Forms.RadioButton rbDescontoNao;
        public System.Windows.Forms.RadioButton rbDescontoSim;
        public System.Windows.Forms.Button tbAdicionar;
        public System.Windows.Forms.Button tbRemoverSelecionado;
    }
}