namespace UI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDetranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.corDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papelDeParedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDeFundoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.papelDeParedeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.utilitáriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.veículosToolStripMenuItem.Text = "&Veículos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.marcasToolStripMenuItem.Text = "&Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.modelosToolStripMenuItem.Text = "M&odelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "&Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaCompraToolStripMenuItem,
            this.saídaVendaToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "&Movimentação";
            // 
            // entradaCompraToolStripMenuItem
            // 
            this.entradaCompraToolStripMenuItem.Name = "entradaCompraToolStripMenuItem";
            this.entradaCompraToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.entradaCompraToolStripMenuItem.Text = "&Entrada(Compra)";
            this.entradaCompraToolStripMenuItem.Click += new System.EventHandler(this.entradaCompraToolStripMenuItem_Click);
            // 
            // saídaVendaToolStripMenuItem
            // 
            this.saídaVendaToolStripMenuItem.Name = "saídaVendaToolStripMenuItem";
            this.saídaVendaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saídaVendaToolStripMenuItem.Text = "&Saída(Venda)";
            this.saídaVendaToolStripMenuItem.Click += new System.EventHandler(this.saídaVendaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.graficosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "C&onsulta";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estoqueToolStripMenuItem.Text = "&Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.graficosToolStripMenuItem.Text = "&Gráficos";
            this.graficosToolStripMenuItem.Click += new System.EventHandler(this.graficosToolStripMenuItem_Click);
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.consultaDetranToolStripMenuItem,
            this.toolStripMenuItem1,
            this.corDeFundoToolStripMenuItem,
            this.papelDeParedeToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "&Utilitários";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.calculadoraToolStripMenuItem.Text = "&Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // consultaDetranToolStripMenuItem
            // 
            this.consultaDetranToolStripMenuItem.Name = "consultaDetranToolStripMenuItem";
            this.consultaDetranToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.consultaDetranToolStripMenuItem.Text = "Consulta &Detran";
            this.consultaDetranToolStripMenuItem.Click += new System.EventHandler(this.consultaDetranToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // corDeFundoToolStripMenuItem
            // 
            this.corDeFundoToolStripMenuItem.Name = "corDeFundoToolStripMenuItem";
            this.corDeFundoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.corDeFundoToolStripMenuItem.Text = "Cor de &Fundo";
            this.corDeFundoToolStripMenuItem.Click += new System.EventHandler(this.corDeFundoToolStripMenuItem_Click);
            // 
            // papelDeParedeToolStripMenuItem
            // 
            this.papelDeParedeToolStripMenuItem.Name = "papelDeParedeToolStripMenuItem";
            this.papelDeParedeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.papelDeParedeToolStripMenuItem.Text = "&Papel de Parede";
            this.papelDeParedeToolStripMenuItem.Click += new System.EventHandler(this.papelDeParedeToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.sairToolStripMenuItem1.Text = "&Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 81);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 78);
            this.toolStripButton1.Text = "Entrada";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "\"Entrada(Compra)\"";
            this.toolStripButton1.Click += new System.EventHandler(this.entradaCompraToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 81);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(89, 78);
            this.toolStripButton2.Text = "Saída";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "Saída(Venda)";
            this.toolStripButton2.Click += new System.EventHandler(this.saídaVendaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 81);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(89, 78);
            this.toolStripButton3.Text = "Estoque";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.ToolTipText = "Consulta(Estoque)";
            this.toolStripButton3.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 81);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(89, 78);
            this.toolStripButton4.Text = "Gráficos";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.ToolTipText = "Gráficos das negociações";
            this.toolStripButton4.Click += new System.EventHandler(this.graficosToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 81);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(89, 78);
            this.toolStripButton5.Text = "Calculadora";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.ToolTipText = "Calculadora";
            this.toolStripButton5.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 81);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(89, 78);
            this.toolStripButton6.Text = "Sair";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirBarraToolStripMenuItem,
            this.corDeFundoToolStripMenuItem1,
            this.papelDeParedeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 70);
            // 
            // exibirBarraToolStripMenuItem
            // 
            this.exibirBarraToolStripMenuItem.Checked = true;
            this.exibirBarraToolStripMenuItem.CheckOnClick = true;
            this.exibirBarraToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exibirBarraToolStripMenuItem.Name = "exibirBarraToolStripMenuItem";
            this.exibirBarraToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exibirBarraToolStripMenuItem.Text = "Exibir barra";
            this.exibirBarraToolStripMenuItem.Click += new System.EventHandler(this.exibirBarraToolStripMenuItem_Click);
            // 
            // corDeFundoToolStripMenuItem1
            // 
            this.corDeFundoToolStripMenuItem1.Name = "corDeFundoToolStripMenuItem1";
            this.corDeFundoToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.corDeFundoToolStripMenuItem1.Text = "Cor de fundo";
            this.corDeFundoToolStripMenuItem1.Click += new System.EventHandler(this.corDeFundoToolStripMenuItem_Click);
            // 
            // papelDeParedeToolStripMenuItem1
            // 
            this.papelDeParedeToolStripMenuItem1.Name = "papelDeParedeToolStripMenuItem1";
            this.papelDeParedeToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.papelDeParedeToolStripMenuItem1.Text = "Papel de parede";
            this.papelDeParedeToolStripMenuItem1.Click += new System.EventHandler(this.papelDeParedeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 332);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "SisCar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDetranToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem corDeFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papelDeParedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirBarraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDeFundoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem papelDeParedeToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}