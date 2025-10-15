
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
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKmsRodado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.Enabled = false;
            this.cbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(20, 125);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(227, 30);
            this.cbVeiculo.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(20, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 74;
            this.label5.Text = "* Veículo:";
            // 
            // cbModelo
            // 
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(268, 125);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(227, 30);
            this.cbModelo.TabIndex = 71;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(900, 522);
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
            this.btnDeletar.Location = new System.Drawing.Point(323, 522);
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
            this.btnAtualizar.Location = new System.Drawing.Point(176, 522);
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
            this.btnCadastrar.Location = new System.Drawing.Point(19, 522);
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
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(515, 125);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(227, 30);
            this.cbCategoria.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 22F);
            this.label12.Location = new System.Drawing.Point(388, 15);
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
            this.label26.Location = new System.Drawing.Point(312, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(387, 27);
            this.label26.TabIndex = 64;
            this.label26.Text = "Todos os campos com * são obrigatorios.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(268, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "* Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(515, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "* Categoria:";
            // 
            // cbEstadoVeiculo
            // 
            this.cbEstadoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbEstadoVeiculo.FormattingEnabled = true;
            this.cbEstadoVeiculo.Location = new System.Drawing.Point(763, 125);
            this.cbEstadoVeiculo.Name = "cbEstadoVeiculo";
            this.cbEstadoVeiculo.Size = new System.Drawing.Size(227, 30);
            this.cbEstadoVeiculo.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(763, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "* Estado do veículo:";
            // 
            // cbTipoCombustivel
            // 
            this.cbTipoCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbTipoCombustivel.FormattingEnabled = true;
            this.cbTipoCombustivel.Location = new System.Drawing.Point(20, 200);
            this.cbTipoCombustivel.Name = "cbTipoCombustivel";
            this.cbTipoCombustivel.Size = new System.Drawing.Size(227, 30);
            this.cbTipoCombustivel.TabIndex = 79;
            // 
            // cbTipoCambio
            // 
            this.cbTipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbTipoCambio.FormattingEnabled = true;
            this.cbTipoCambio.Location = new System.Drawing.Point(268, 200);
            this.cbTipoCambio.Name = "cbTipoCambio";
            this.cbTipoCambio.Size = new System.Drawing.Size(227, 30);
            this.cbTipoCambio.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(20, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 77;
            this.label3.Text = "* Tipo de combustivel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(268, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 76;
            this.label6.Text = "* Tipo de câmbio:";
            // 
            // tbTempoUso
            // 
            this.tbTempoUso.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbTempoUso.Location = new System.Drawing.Point(515, 200);
            this.tbTempoUso.Name = "tbTempoUso";
            this.tbTempoUso.Size = new System.Drawing.Size(227, 30);
            this.tbTempoUso.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(515, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "* Tempo de uso: (dias)";
            // 
            // tbPreco
            // 
            this.tbPreco.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbPreco.Location = new System.Drawing.Point(763, 200);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(227, 30);
            this.tbPreco.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(763, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 85;
            this.label8.Text = "* Preço:";
            // 
            // tbKmsRodado
            // 
            this.tbKmsRodado.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbKmsRodado.Location = new System.Drawing.Point(20, 278);
            this.tbKmsRodado.Name = "tbKmsRodado";
            this.tbKmsRodado.Size = new System.Drawing.Size(227, 30);
            this.tbKmsRodado.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F);
            this.label9.Location = new System.Drawing.Point(20, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 87;
            this.label9.Text = "* KMs rodado:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbPlaca.Location = new System.Drawing.Point(268, 278);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(227, 30);
            this.tbPlaca.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.Location = new System.Drawing.Point(268, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 23);
            this.label11.TabIndex = 91;
            this.label11.Text = "* Placa:";
            // 
            // cbColor
            // 
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(515, 278);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(227, 30);
            this.cbColor.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.Location = new System.Drawing.Point(515, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 23);
            this.label13.TabIndex = 92;
            this.label13.Text = "* Cor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F);
            this.label14.Location = new System.Drawing.Point(763, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 23);
            this.label14.TabIndex = 95;
            this.label14.Text = "* Ano:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(20, 356);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(227, 30);
            this.cbVendedor.TabIndex = 101;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14F);
            this.label17.Location = new System.Drawing.Point(20, 329);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 23);
            this.label17.TabIndex = 100;
            this.label17.Text = "Vendedor:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbDescricao.Location = new System.Drawing.Point(20, 437);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(970, 76);
            this.tbDescricao.TabIndex = 102;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14F);
            this.label18.Location = new System.Drawing.Point(20, 408);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 23);
            this.label18.TabIndex = 103;
            this.label18.Text = "* Descrição:";
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(268, 356);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(227, 30);
            this.cbStatus.TabIndex = 105;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Calibri", 14F);
            this.Status.Location = new System.Drawing.Point(268, 329);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(63, 23);
            this.Status.TabIndex = 104;
            this.Status.Text = "Status:";
            // 
            // tbAno
            // 
            this.tbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.Location = new System.Drawing.Point(763, 278);
            this.tbAno.Mask = "0000";
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(227, 29);
            this.tbAno.TabIndex = 106;
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 580);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbKmsRodado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTempoUso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbEstadoVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoCombustivel);
            this.Controls.Add(this.cbTipoCambio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormVeiculo";
            this.Text = "FormVeiculo";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKmsRodado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.MaskedTextBox tbAno;
    }
}