﻿
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
            this.tbCusto = new System.Windows.Forms.TextBox();
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
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbPrecoVenda = new System.Windows.Forms.GroupBox();
            this.gbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbEspecificacoes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPrecoVenda.SuspendLayout();
            this.gbDadosRegistro.SuspendLayout();
            this.gbEspecificacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModelo
            // 
            this.cbModelo.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(7, 55);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(321, 27);
            this.cbModelo.TabIndex = 71;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(1221, 586);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(7);
            this.btnSair.Size = new System.Drawing.Size(89, 46);
            this.btnSair.TabIndex = 70;
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
            this.btnDeletar.Location = new System.Drawing.Point(163, 586);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(7);
            this.btnDeletar.Size = new System.Drawing.Size(111, 46);
            this.btnDeletar.TabIndex = 69;
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
            this.btnAtualizar.Location = new System.Drawing.Point(280, 586);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(7);
            this.btnAtualizar.Size = new System.Drawing.Size(122, 46);
            this.btnAtualizar.TabIndex = 68;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 586);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(7);
            this.btnCadastrar.Size = new System.Drawing.Size(132, 46);
            this.btnCadastrar.TabIndex = 67;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(339, 55);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(321, 27);
            this.cbCategoria.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 22F);
            this.label12.Location = new System.Drawing.Point(554, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 37);
            this.label12.TabIndex = 65;
            this.label12.Text = "Cadastrar Veículo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 16F);
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(475, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(387, 27);
            this.label26.TabIndex = 64;
            this.label26.Text = "Todos os campos com * são obrigatorios.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "* Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(339, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "* Categoria:";
            // 
            // cbEstadoVeiculo
            // 
            this.cbEstadoVeiculo.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbEstadoVeiculo.FormattingEnabled = true;
            this.cbEstadoVeiculo.Location = new System.Drawing.Point(7, 120);
            this.cbEstadoVeiculo.Name = "cbEstadoVeiculo";
            this.cbEstadoVeiculo.Size = new System.Drawing.Size(321, 27);
            this.cbEstadoVeiculo.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "* Estado do veículo:";
            // 
            // cbTipoCombustivel
            // 
            this.cbTipoCombustivel.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbTipoCombustivel.FormattingEnabled = true;
            this.cbTipoCombustivel.Location = new System.Drawing.Point(8, 54);
            this.cbTipoCombustivel.Name = "cbTipoCombustivel";
            this.cbTipoCombustivel.Size = new System.Drawing.Size(141, 27);
            this.cbTipoCombustivel.TabIndex = 79;
            // 
            // cbTipoCambio
            // 
            this.cbTipoCambio.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbTipoCambio.FormattingEnabled = true;
            this.cbTipoCambio.Location = new System.Drawing.Point(155, 54);
            this.cbTipoCambio.Name = "cbTipoCambio";
            this.cbTipoCambio.Size = new System.Drawing.Size(247, 27);
            this.cbTipoCambio.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 77;
            this.label3.Text = "* Combustivel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(155, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 76;
            this.label6.Text = "* Tipo de câmbio:";
            // 
            // tbTempoUso
            // 
            this.tbTempoUso.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbTempoUso.Location = new System.Drawing.Point(339, 120);
            this.tbTempoUso.MaxLength = 5;
            this.tbTempoUso.Name = "tbTempoUso";
            this.tbTempoUso.Size = new System.Drawing.Size(184, 27);
            this.tbTempoUso.TabIndex = 82;
            this.tbTempoUso.TextChanged += new System.EventHandler(this.tbTempoUso_TextChanged);
            this.tbTempoUso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTempoUso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(339, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "* Tempo de uso: (dias)";
            // 
            // tbCusto
            // 
            this.tbCusto.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbCusto.Location = new System.Drawing.Point(8, 57);
            this.tbCusto.MaxLength = 11;
            this.tbCusto.Name = "tbCusto";
            this.tbCusto.Size = new System.Drawing.Size(108, 27);
            this.tbCusto.TabIndex = 84;
            this.tbCusto.TextChanged += new System.EventHandler(this.tbPreco_TextChanged);
            this.tbCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPreco_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(8, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 85;
            this.label8.Text = "* Custo:";
            // 
            // tbKmsRodado
            // 
            this.tbKmsRodado.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbKmsRodado.Location = new System.Drawing.Point(594, 54);
            this.tbKmsRodado.MaxLength = 7;
            this.tbKmsRodado.Name = "tbKmsRodado";
            this.tbKmsRodado.Size = new System.Drawing.Size(73, 27);
            this.tbKmsRodado.TabIndex = 86;
            this.tbKmsRodado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKmsRodado_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F);
            this.label9.Location = new System.Drawing.Point(594, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 87;
            this.label9.Text = "* KMs:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbPlaca.Location = new System.Drawing.Point(529, 120);
            this.tbPlaca.MaxLength = 1;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(131, 27);
            this.tbPlaca.TabIndex = 90;
            this.tbPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlaca_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.Location = new System.Drawing.Point(529, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 91;
            this.label11.Text = "* Final da placa:";
            // 
            // cbColor
            // 
            this.cbColor.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(408, 54);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(115, 27);
            this.cbColor.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.Location = new System.Drawing.Point(408, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 23);
            this.label13.TabIndex = 92;
            this.label13.Text = "* Cor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F);
            this.label14.Location = new System.Drawing.Point(529, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 23);
            this.label14.TabIndex = 95;
            this.label14.Text = "* Ano:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbDescricao.Location = new System.Drawing.Point(7, 190);
            this.tbDescricao.MaxLength = 250;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(653, 76);
            this.tbDescricao.TabIndex = 102;
            this.tbDescricao.TextChanged += new System.EventHandler(this.tbDescricao_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14F);
            this.label18.Location = new System.Drawing.Point(7, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 23);
            this.label18.TabIndex = 103;
            this.label18.Text = "* Descrição:";
            // 
            // tbAno
            // 
            this.tbAno.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbAno.Location = new System.Drawing.Point(529, 54);
            this.tbAno.Mask = "0000";
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(59, 27);
            this.tbAno.TabIndex = 106;
            // 
            // tbLucro
            // 
            this.tbLucro.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbLucro.Location = new System.Drawing.Point(122, 57);
            this.tbLucro.MaxLength = 5;
            this.tbLucro.Name = "tbLucro";
            this.tbLucro.Size = new System.Drawing.Size(101, 27);
            this.tbLucro.TabIndex = 107;
            this.tbLucro.TextChanged += new System.EventHandler(this.tbPercentualLucro_TextChanged);
            this.tbLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPercentualLucro_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.Location = new System.Drawing.Point(122, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 108;
            this.label10.Text = "* Lucro: (%)";
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Enabled = false;
            this.tbPrecoVenda.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbPrecoVenda.Location = new System.Drawing.Point(229, 57);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(133, 27);
            this.tbPrecoVenda.TabIndex = 109;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14F);
            this.label15.Location = new System.Drawing.Point(229, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 23);
            this.label15.TabIndex = 110;
            this.label15.Text = "Preço de venda:";
            // 
            // gbPrecoVenda
            // 
            this.gbPrecoVenda.Controls.Add(this.tbCusto);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoVenda);
            this.gbPrecoVenda.Controls.Add(this.label15);
            this.gbPrecoVenda.Controls.Add(this.label8);
            this.gbPrecoVenda.Controls.Add(this.tbLucro);
            this.gbPrecoVenda.Controls.Add(this.label10);
            this.gbPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrecoVenda.Location = new System.Drawing.Point(330, 92);
            this.gbPrecoVenda.Name = "gbPrecoVenda";
            this.gbPrecoVenda.Size = new System.Drawing.Size(368, 93);
            this.gbPrecoVenda.TabIndex = 111;
            this.gbPrecoVenda.TabStop = false;
            this.gbPrecoVenda.Text = "Calcular preço de venda";
            // 
            // gbDadosRegistro
            // 
            this.gbDadosRegistro.Controls.Add(this.label16);
            this.gbDadosRegistro.Controls.Add(this.label19);
            this.gbDadosRegistro.Controls.Add(this.tbCodigoVeiculo);
            this.gbDadosRegistro.Controls.Add(this.cbStatus);
            this.gbDadosRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbDadosRegistro.Location = new System.Drawing.Point(25, 92);
            this.gbDadosRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.gbDadosRegistro.Name = "gbDadosRegistro";
            this.gbDadosRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.gbDadosRegistro.Size = new System.Drawing.Size(298, 93);
            this.gbDadosRegistro.TabIndex = 112;
            this.gbDadosRegistro.TabStop = false;
            this.gbDadosRegistro.Text = "Registro";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F);
            this.label16.Location = new System.Drawing.Point(143, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 23);
            this.label16.TabIndex = 39;
            this.label16.Text = "Status:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14F);
            this.label19.Location = new System.Drawing.Point(8, 30);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 23);
            this.label19.TabIndex = 37;
            this.label19.Text = "Código Veículo:";
            // 
            // tbCodigoVeiculo
            // 
            this.tbCodigoVeiculo.Enabled = false;
            this.tbCodigoVeiculo.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbCodigoVeiculo.Location = new System.Drawing.Point(8, 57);
            this.tbCodigoVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigoVeiculo.MaxLength = 20;
            this.tbCodigoVeiculo.Name = "tbCodigoVeiculo";
            this.tbCodigoVeiculo.Size = new System.Drawing.Size(127, 27);
            this.tbCodigoVeiculo.TabIndex = 31;
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(143, 57);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(147, 27);
            this.cbStatus.TabIndex = 31;
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
            this.gbEspecificacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbEspecificacoes.Location = new System.Drawing.Point(25, 193);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(25, 294);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 277);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do veículo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(713, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(597, 479);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Calibri", 14F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(396, 33);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(194, 38);
            this.button2.TabIndex = 115;
            this.button2.Text = "Deletar Selecionado";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 33);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(230, 38);
            this.button1.TabIndex = 115;
            this.button1.Text = "Adicionar característica";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 391);
            this.dataGridView1.TabIndex = 115;
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 644);
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
            this.Name = "FormVeiculo";
            this.Text = "FormVeiculo";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            this.gbPrecoVenda.ResumeLayout(false);
            this.gbPrecoVenda.PerformLayout();
            this.gbDadosRegistro.ResumeLayout(false);
            this.gbDadosRegistro.PerformLayout();
            this.gbEspecificacoes.ResumeLayout(false);
            this.gbEspecificacoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstadoVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoCombustivel;
        private System.Windows.Forms.ComboBox cbTipoCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTempoUso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCusto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKmsRodado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox tbAno;
        private System.Windows.Forms.TextBox tbLucro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbPrecoVenda;
        private System.Windows.Forms.GroupBox gbDadosRegistro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbCodigoVeiculo;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox gbEspecificacoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}