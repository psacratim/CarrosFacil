
namespace CarrosFacil
{
    partial class FormCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new CarrosFacil.RJDatePicker();
            this.tbCodigoCargo = new CarrosFacil.RJTextBox();
            this.tbStatus = new CarrosFacil.RJTextBox();
            this.tbNomeCargo = new CarrosFacil.RJTextBox();
            this.tbObservacao = new CarrosFacil.RJTextBox();
            this.btnCadastrar = new CarrosFacil.RJButton();
            this.btnAtualizar = new CarrosFacil.RJButton();
            this.btnExcluir = new CarrosFacil.RJButton();
            this.btnSair = new CarrosFacil.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F);
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F);
            this.label2.Location = new System.Drawing.Point(228, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Data Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F);
            this.label3.Location = new System.Drawing.Point(457, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "* Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "* Nome do cargo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F);
            this.label5.Location = new System.Drawing.Point(28, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observação:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 22F);
            this.lbTitle.Location = new System.Drawing.Point(226, 17);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(209, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Cadastrar Cargo";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dtpDataCadastro.BorderRadius = 6;
            this.dtpDataCadastro.BorderSize = 2;
            this.dtpDataCadastro.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpDataCadastro.CustomFormat = "M/d/yyyy h:mm tt";
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(228, 116);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataCadastro.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(200, 35);
            this.dtpDataCadastro.SkinColor = System.Drawing.Color.White;
            this.dtpDataCadastro.TabIndex = 19;
            this.dtpDataCadastro.TextColor = System.Drawing.Color.Black;
            // 
            // tbCodigoCargo
            // 
            this.tbCodigoCargo.BackColor = System.Drawing.SystemColors.Window;
            this.tbCodigoCargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.tbCodigoCargo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.tbCodigoCargo.BorderRadius = 6;
            this.tbCodigoCargo.BorderSize = 2;
            this.tbCodigoCargo.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbCodigoCargo.ForeColor = System.Drawing.Color.Black;
            this.tbCodigoCargo.Location = new System.Drawing.Point(28, 116);
            this.tbCodigoCargo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigoCargo.Multiline = false;
            this.tbCodigoCargo.Name = "tbCodigoCargo";
            this.tbCodigoCargo.Padding = new System.Windows.Forms.Padding(5);
            this.tbCodigoCargo.PasswordChar = false;
            this.tbCodigoCargo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbCodigoCargo.PlaceholderText = "";
            this.tbCodigoCargo.Size = new System.Drawing.Size(167, 34);
            this.tbCodigoCargo.TabIndex = 18;
            this.tbCodigoCargo.Texts = "";
            this.tbCodigoCargo.UnderlinedStyle = false;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.tbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.tbStatus.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.tbStatus.BorderRadius = 6;
            this.tbStatus.BorderSize = 2;
            this.tbStatus.Enabled = false;
            this.tbStatus.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbStatus.ForeColor = System.Drawing.Color.Black;
            this.tbStatus.Location = new System.Drawing.Point(457, 116);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbStatus.Multiline = false;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Padding = new System.Windows.Forms.Padding(5);
            this.tbStatus.PasswordChar = false;
            this.tbStatus.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbStatus.PlaceholderText = "";
            this.tbStatus.Size = new System.Drawing.Size(167, 34);
            this.tbStatus.TabIndex = 20;
            this.tbStatus.Texts = "";
            this.tbStatus.UnderlinedStyle = false;
            // 
            // tbNomeCargo
            // 
            this.tbNomeCargo.BackColor = System.Drawing.SystemColors.Window;
            this.tbNomeCargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.tbNomeCargo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.tbNomeCargo.BorderRadius = 6;
            this.tbNomeCargo.BorderSize = 2;
            this.tbNomeCargo.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbNomeCargo.ForeColor = System.Drawing.Color.Black;
            this.tbNomeCargo.Location = new System.Drawing.Point(28, 204);
            this.tbNomeCargo.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomeCargo.Multiline = false;
            this.tbNomeCargo.Name = "tbNomeCargo";
            this.tbNomeCargo.Padding = new System.Windows.Forms.Padding(5);
            this.tbNomeCargo.PasswordChar = false;
            this.tbNomeCargo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNomeCargo.PlaceholderText = "";
            this.tbNomeCargo.Size = new System.Drawing.Size(596, 34);
            this.tbNomeCargo.TabIndex = 21;
            this.tbNomeCargo.Texts = "";
            this.tbNomeCargo.UnderlinedStyle = false;
            // 
            // tbObservacao
            // 
            this.tbObservacao.BackColor = System.Drawing.SystemColors.Window;
            this.tbObservacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.tbObservacao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.tbObservacao.BorderRadius = 6;
            this.tbObservacao.BorderSize = 2;
            this.tbObservacao.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbObservacao.ForeColor = System.Drawing.Color.Black;
            this.tbObservacao.Location = new System.Drawing.Point(28, 298);
            this.tbObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Padding = new System.Windows.Forms.Padding(5);
            this.tbObservacao.PasswordChar = false;
            this.tbObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbObservacao.PlaceholderText = "";
            this.tbObservacao.Size = new System.Drawing.Size(596, 107);
            this.tbObservacao.TabIndex = 22;
            this.tbObservacao.Texts = "";
            this.tbObservacao.UnderlinedStyle = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(238)))), ((int)(((byte)(78)))));
            this.btnCadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(238)))), ((int)(((byte)(78)))));
            this.btnCadastrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(16)))));
            this.btnCadastrar.BorderRadius = 6;
            this.btnCadastrar.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(28, 422);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnCadastrar.Size = new System.Drawing.Size(126, 42);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextColor = System.Drawing.Color.Black;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAtualizar.BorderRadius = 6;
            this.btnAtualizar.BorderSize = 2;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(172, 422);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAtualizar.Size = new System.Drawing.Size(120, 42);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcluir.BorderRadius = 6;
            this.btnExcluir.BorderSize = 2;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(310, 422);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(100, 42);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnSair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnSair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnSair.BorderRadius = 6;
            this.btnSair.BorderSize = 2;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(540, 422);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5);
            this.btnSair.Size = new System.Drawing.Size(84, 42);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextColor = System.Drawing.Color.Black;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // FormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 485);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbObservacao);
            this.Controls.Add(this.tbNomeCargo);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.tbCodigoCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormCargo";
            this.Text = "FormCargo";
            this.Load += new System.EventHandler(this.FormCargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTitle;
        private RJTextBox tbCodigoCargo;
        private RJDatePicker dtpDataCadastro;
        private RJTextBox tbStatus;
        private RJTextBox tbNomeCargo;
        private RJTextBox tbObservacao;
        private RJButton btnCadastrar;
        private RJButton btnAtualizar;
        private RJButton btnExcluir;
        private RJButton btnSair;
    }
}