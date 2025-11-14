
using CarrosFacil.FormElements;

namespace CarrosFacil.Forms
{
    partial class FormConsFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsFuncionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDataAdmissao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.gbTipoBusca = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbDataAdmissao.SuspendLayout();
            this.gbTipoBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.mskCpf);
            this.panel1.Controls.Add(this.cbOpcoes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbCargo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.gbDataAdmissao);
            this.panel1.Controls.Add(this.gbTipoBusca);
            this.panel1.Controls.Add(this.cbSexo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCidade);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 389);
            this.panel1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(13, 337);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(132, 43);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(228, 337);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 43);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(212, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "CPF:";
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mskCpf.Location = new System.Drawing.Point(212, 34);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(105, 25);
            this.mskCpf.TabIndex = 24;
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(13, 34);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(193, 25);
            this.cbOpcoes.TabIndex = 20;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(13, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Filtro:";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(170, 306);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(147, 25);
            this.cbStatus.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(170, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status:";
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(13, 306);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(147, 25);
            this.cbCargo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(13, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cargo:";
            // 
            // gbDataAdmissao
            // 
            this.gbDataAdmissao.Controls.Add(this.label6);
            this.gbDataAdmissao.Controls.Add(this.label5);
            this.gbDataAdmissao.Controls.Add(this.dtpDataFinal);
            this.gbDataAdmissao.Controls.Add(this.dtpDataInicial);
            this.gbDataAdmissao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataAdmissao.Location = new System.Drawing.Point(13, 198);
            this.gbDataAdmissao.Name = "gbDataAdmissao";
            this.gbDataAdmissao.Size = new System.Drawing.Size(304, 74);
            this.gbDataAdmissao.TabIndex = 14;
            this.gbDataAdmissao.TabStop = false;
            this.gbDataAdmissao.Text = "Data de Admissão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(265, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Até:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "De:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(160, 45);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(138, 25);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(7, 45);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(138, 25);
            this.dtpDataInicial.TabIndex = 2;
            // 
            // gbTipoBusca
            // 
            this.gbTipoBusca.Controls.Add(this.rbContem);
            this.gbTipoBusca.Controls.Add(this.rbInicio);
            this.gbTipoBusca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoBusca.Location = new System.Drawing.Point(13, 136);
            this.gbTipoBusca.Name = "gbTipoBusca";
            this.gbTipoBusca.Size = new System.Drawing.Size(147, 45);
            this.gbTipoBusca.TabIndex = 13;
            this.gbTipoBusca.TabStop = false;
            this.gbTipoBusca.Text = "Tipo de busca";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Checked = true;
            this.rbContem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContem.Location = new System.Drawing.Point(69, 20);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(76, 23);
            this.rbContem.TabIndex = 8;
            this.rbContem.TabStop = true;
            this.rbContem.Text = "Contém";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInicio.Location = new System.Drawing.Point(7, 20);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(59, 23);
            this.rbInicio.TabIndex = 7;
            this.rbInicio.Text = "Início";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(170, 98);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(147, 25);
            this.cbSexo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(170, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(170, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome:";
            // 
            // cbCidade
            // 
            this.cbCidade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(13, 98);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(147, 25);
            this.cbCidade.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(170, 158);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(147, 25);
            this.tbNome.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros de Pesquisa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(524, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Clique no funcionário para editar";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeColumns = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionarios.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFuncionarios.Location = new System.Drawing.Point(350, 53);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowHeadersWidth = 51;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(641, 389);
            this.dgvFuncionarios.TabIndex = 52;
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            this.dgvFuncionarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuncionarios_CellMouseClick);
            // 
            // FormConsFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaFuncionarioV2";
            this.Load += new System.EventHandler(this.FormConsultaFuncionarioV2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDataAdmissao.ResumeLayout(false);
            this.gbDataAdmissao.PerformLayout();
            this.gbTipoBusca.ResumeLayout(false);
            this.gbTipoBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.GroupBox gbTipoBusca;
        private System.Windows.Forms.GroupBox gbDataAdmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
    }
}