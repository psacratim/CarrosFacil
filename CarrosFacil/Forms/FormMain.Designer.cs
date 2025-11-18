
namespace CarrosFacil
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCaracteristicas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsCaracteristicas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbData = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.menuRelFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuConsFuncionarios,
            this.menuRelatorios,
            this.menuVendas,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(7);
            this.menuPrincipal.Size = new System.Drawing.Size(764, 50);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menus";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadCargos,
            this.menuCadFuncionarios,
            this.menuCadMarcas,
            this.menuCadModelos,
            this.menuCadCaracteristicas,
            this.menuCadCliente,
            this.menuCadVeiculo});
            this.menuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastros.Image")));
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(143, 36);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuCadCargos
            // 
            this.menuCadCargos.Name = "menuCadCargos";
            this.menuCadCargos.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuCadCargos.Size = new System.Drawing.Size(232, 30);
            this.menuCadCargos.Text = "Cargos";
            this.menuCadCargos.Click += new System.EventHandler(this.menuCadCargos_Click);
            // 
            // menuCadFuncionarios
            // 
            this.menuCadFuncionarios.Name = "menuCadFuncionarios";
            this.menuCadFuncionarios.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuCadFuncionarios.Size = new System.Drawing.Size(232, 30);
            this.menuCadFuncionarios.Text = "Funcionarios";
            this.menuCadFuncionarios.Click += new System.EventHandler(this.menuCadFuncionarios_Click);
            // 
            // menuCadMarcas
            // 
            this.menuCadMarcas.Name = "menuCadMarcas";
            this.menuCadMarcas.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuCadMarcas.Size = new System.Drawing.Size(232, 30);
            this.menuCadMarcas.Text = "Marcas";
            this.menuCadMarcas.Click += new System.EventHandler(this.menuCadMarcas_Click);
            // 
            // menuCadModelos
            // 
            this.menuCadModelos.Name = "menuCadModelos";
            this.menuCadModelos.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuCadModelos.Size = new System.Drawing.Size(232, 30);
            this.menuCadModelos.Text = "Modelos";
            this.menuCadModelos.Click += new System.EventHandler(this.menuCadModelos_Click);
            // 
            // menuCadCaracteristicas
            // 
            this.menuCadCaracteristicas.Name = "menuCadCaracteristicas";
            this.menuCadCaracteristicas.Size = new System.Drawing.Size(232, 30);
            this.menuCadCaracteristicas.Text = "Caracteristicas";
            this.menuCadCaracteristicas.Click += new System.EventHandler(this.menuCadCaracteristicas_Click);
            // 
            // menuCadCliente
            // 
            this.menuCadCliente.Name = "menuCadCliente";
            this.menuCadCliente.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuCadCliente.Size = new System.Drawing.Size(232, 30);
            this.menuCadCliente.Text = "Cliente";
            this.menuCadCliente.Click += new System.EventHandler(this.menuCadCliente_Click);
            // 
            // menuCadVeiculo
            // 
            this.menuCadVeiculo.Name = "menuCadVeiculo";
            this.menuCadVeiculo.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuCadVeiculo.Size = new System.Drawing.Size(232, 30);
            this.menuCadVeiculo.Text = "Veiculo";
            this.menuCadVeiculo.Click += new System.EventHandler(this.menuCadVeiculo_Click);
            // 
            // menuConsFuncionarios
            // 
            this.menuConsFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.menuConsClientes,
            this.menuConsVeiculos,
            this.menuConsModelos,
            this.menuConsCargos,
            this.menuConsCaracteristicas,
            this.menuConsMarcas});
            this.menuConsFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("menuConsFuncionarios.Image")));
            this.menuConsFuncionarios.Name = "menuConsFuncionarios";
            this.menuConsFuncionarios.Size = new System.Drawing.Size(142, 36);
            this.menuConsFuncionarios.Text = "Consultas";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.menuConsFuncionarios_Click);
            // 
            // menuConsClientes
            // 
            this.menuConsClientes.Name = "menuConsClientes";
            this.menuConsClientes.Size = new System.Drawing.Size(210, 30);
            this.menuConsClientes.Text = "Clientes";
            this.menuConsClientes.Click += new System.EventHandler(this.menuConsClientes_Click);
            // 
            // menuConsVeiculos
            // 
            this.menuConsVeiculos.Name = "menuConsVeiculos";
            this.menuConsVeiculos.Size = new System.Drawing.Size(210, 30);
            this.menuConsVeiculos.Text = "Veiculos";
            this.menuConsVeiculos.Click += new System.EventHandler(this.menuConsVeiculos_Click);
            // 
            // menuConsModelos
            // 
            this.menuConsModelos.Name = "menuConsModelos";
            this.menuConsModelos.Size = new System.Drawing.Size(210, 30);
            this.menuConsModelos.Text = "Modelos";
            this.menuConsModelos.Click += new System.EventHandler(this.menuConsModelos_Click);
            // 
            // menuConsCargos
            // 
            this.menuConsCargos.Name = "menuConsCargos";
            this.menuConsCargos.Size = new System.Drawing.Size(210, 30);
            this.menuConsCargos.Text = "Cargos";
            this.menuConsCargos.Click += new System.EventHandler(this.menuConsCargos_Click);
            // 
            // menuConsCaracteristicas
            // 
            this.menuConsCaracteristicas.Name = "menuConsCaracteristicas";
            this.menuConsCaracteristicas.Size = new System.Drawing.Size(210, 30);
            this.menuConsCaracteristicas.Text = "Caracteristicas";
            this.menuConsCaracteristicas.Click += new System.EventHandler(this.menuConsCaracteristicas_Click);
            // 
            // menuConsMarcas
            // 
            this.menuConsMarcas.Name = "menuConsMarcas";
            this.menuConsMarcas.Size = new System.Drawing.Size(210, 30);
            this.menuConsMarcas.Text = "Marcas";
            this.menuConsMarcas.Click += new System.EventHandler(this.menuConsMarcas_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelFuncionario});
            this.menuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("menuRelatorios.Image")));
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(145, 36);
            this.menuRelatorios.Text = "Relatorios";
            // 
            // menuVendas
            // 
            this.menuVendas.Image = ((System.Drawing.Image)(resources.GetObject("menuVendas.Image")));
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(120, 36);
            this.menuVendas.Text = "Vendas";
            // 
            // menuSair
            // 
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.Name = "menuSair";
            this.menuSair.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.menuSair.Size = new System.Drawing.Size(90, 36);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbHora,
            this.statusLbData,
            this.statusLbMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(764, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // statusLbHora
            // 
            this.statusLbHora.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusLbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.statusLbHora.Name = "statusLbHora";
            this.statusLbHora.Size = new System.Drawing.Size(53, 25);
            this.statusLbHora.Text = "Hora";
            // 
            // statusLbData
            // 
            this.statusLbData.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusLbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.statusLbData.Name = "statusLbData";
            this.statusLbData.Size = new System.Drawing.Size(51, 25);
            this.statusLbData.Text = "Data";
            // 
            // statusLbMensagem
            // 
            this.statusLbMensagem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusLbMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.statusLbMensagem.Name = "statusLbMensagem";
            this.statusLbMensagem.Size = new System.Drawing.Size(105, 25);
            this.statusLbMensagem.Text = "Mensagem";
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // menuRelFuncionario
            // 
            this.menuRelFuncionario.Name = "menuRelFuncionario";
            this.menuRelFuncionario.Size = new System.Drawing.Size(191, 30);
            this.menuRelFuncionario.Text = "Funcionário";
            this.menuRelFuncionario.Click += new System.EventHandler(this.menuRelFuncionario_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 478);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema - Carros Fácil";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuCadCargos;
        private System.Windows.Forms.ToolStripMenuItem menuCadFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuConsFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbMensagem;
        private System.Windows.Forms.ToolStripStatusLabel statusLbData;
        private System.Windows.Forms.ToolStripStatusLabel statusLbHora;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadMarcas;
        private System.Windows.Forms.ToolStripMenuItem menuCadModelos;
        private System.Windows.Forms.ToolStripMenuItem menuCadCaracteristicas;
        private System.Windows.Forms.ToolStripMenuItem menuCadCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadVeiculo;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConsClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConsVeiculos;
        private System.Windows.Forms.ToolStripMenuItem menuConsModelos;
        private System.Windows.Forms.ToolStripMenuItem menuConsCargos;
        private System.Windows.Forms.ToolStripMenuItem menuConsCaracteristicas;
        private System.Windows.Forms.ToolStripMenuItem menuConsMarcas;
        private System.Windows.Forms.ToolStripMenuItem menuRelFuncionario;
    }
}

