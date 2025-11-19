namespace CarrosFacil.Forms.Relatorios
{
    partial class FormRelVeiculo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelVeiculo));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.gbModelo = new System.Windows.Forms.GroupBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.gbLucro = new System.Windows.Forms.GroupBox();
            this.txtLucroMaximo = new System.Windows.Forms.TextBox();
            this.txtLucroMinimo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbTipoRel = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.rvVeiculo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCategoria.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gbModelo.SuspendLayout();
            this.gbLucro.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbTipoRel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(33, 196);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(207, 66);
            this.gbCategoria.TabIndex = 128;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(9, 28);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(185, 27);
            this.cbCategoria.TabIndex = 66;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(12, 484);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(169, 43);
            this.btGerarRelatorio.TabIndex = 131;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(7, 26);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(187, 27);
            this.cbTipoRel.TabIndex = 130;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.cbEstado);
            this.gbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.Location = new System.Drawing.Point(33, 268);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(207, 66);
            this.gbEstado.TabIndex = 127;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado do veículo:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(9, 28);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(185, 27);
            this.cbEstado.TabIndex = 66;
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.cbModelo);
            this.gbModelo.Location = new System.Drawing.Point(33, 124);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(207, 66);
            this.gbModelo.TabIndex = 125;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Modelo:";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(10, 25);
            this.cbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(184, 27);
            this.cbModelo.TabIndex = 78;
            // 
            // gbLucro
            // 
            this.gbLucro.Controls.Add(this.txtLucroMaximo);
            this.gbLucro.Controls.Add(this.txtLucroMinimo);
            this.gbLucro.Controls.Add(this.label13);
            this.gbLucro.Controls.Add(this.label14);
            this.gbLucro.Location = new System.Drawing.Point(33, 340);
            this.gbLucro.Name = "gbLucro";
            this.gbLucro.Size = new System.Drawing.Size(206, 66);
            this.gbLucro.TabIndex = 124;
            this.gbLucro.TabStop = false;
            this.gbLucro.Text = "Lucro:";
            // 
            // txtLucroMaximo
            // 
            this.txtLucroMaximo.Location = new System.Drawing.Point(140, 25);
            this.txtLucroMaximo.MaxLength = 5;
            this.txtLucroMaximo.Name = "txtLucroMaximo";
            this.txtLucroMaximo.Size = new System.Drawing.Size(50, 27);
            this.txtLucroMaximo.TabIndex = 45;
            // 
            // txtLucroMinimo
            // 
            this.txtLucroMinimo.Location = new System.Drawing.Point(46, 25);
            this.txtLucroMinimo.MaxLength = 5;
            this.txtLucroMinimo.Name = "txtLucroMinimo";
            this.txtLucroMinimo.Size = new System.Drawing.Size(50, 27);
            this.txtLucroMinimo.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 19);
            this.label13.TabIndex = 43;
            this.label13.Text = "De:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(101, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Até:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(33, 412);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(207, 66);
            this.gbStatus.TabIndex = 122;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(98, 30);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(71, 23);
            this.rbInativo.TabIndex = 2;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(9, 30);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(12, 12);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1014, 34);
            this.pnTituloFuncionario.TabIndex = 121;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(408, 2);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(224, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Veiculos";
            // 
            // gbTipoRel
            // 
            this.gbTipoRel.Controls.Add(this.cbTipoRel);
            this.gbTipoRel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoRel.Location = new System.Drawing.Point(33, 52);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(207, 66);
            this.gbTipoRel.TabIndex = 133;
            this.gbTipoRel.TabStop = false;
            this.gbTipoRel.Text = "Selecione o Relatório:";
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(187, 484);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(74, 43);
            this.btSair.TabIndex = 134;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // rvVeiculo
            // 
            reportDataSource1.Name = "dsVeiculos";
            reportDataSource1.Value = this.VeiculoBindingSource;
            this.rvVeiculo.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVeiculo.LocalReport.ReportEmbeddedResource = "CarrosFacil.Forms.Relatorios.RDLCs.RPTVeiculos.rdlc";
            this.rvVeiculo.Location = new System.Drawing.Point(267, 52);
            this.rvVeiculo.Name = "rvVeiculo";
            this.rvVeiculo.ServerReport.BearerToken = null;
            this.rvVeiculo.Size = new System.Drawing.Size(759, 475);
            this.rvVeiculo.TabIndex = 135;
            // 
            // VeiculoBindingSource
            // 
            this.VeiculoBindingSource.DataSource = typeof(CarrosFacil.Entities.Veiculo);
            // 
            // FormRelVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 541);
            this.Controls.Add(this.rvVeiculo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.gbTipoRel);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.gbModelo);
            this.Controls.Add(this.gbLucro);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRelVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelVeiculo";
            this.Load += new System.EventHandler(this.FormRelVeiculo_Load);
            this.gbCategoria.ResumeLayout(false);
            this.gbEstado.ResumeLayout(false);
            this.gbModelo.ResumeLayout(false);
            this.gbLucro.ResumeLayout(false);
            this.gbLucro.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbTipoRel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btGerarRelatorio;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.GroupBox gbLucro;
        private System.Windows.Forms.TextBox txtLucroMaximo;
        private System.Windows.Forms.TextBox txtLucroMinimo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbTipoRel;
        private System.Windows.Forms.Button btSair;
        private Microsoft.Reporting.WinForms.ReportViewer rvVeiculo;
        private System.Windows.Forms.BindingSource VeiculoBindingSource;
    }
}