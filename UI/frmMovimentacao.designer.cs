namespace UI
{
    partial class frmMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacao));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbMODELO = new System.Windows.Forms.ComboBox();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.txtNOME_CLIENTE_SAIDA = new System.Windows.Forms.TextBox();
            this.txtCOD_CLIENTE_SAIDA = new System.Windows.Forms.TextBox();
            this.txtDATA_SAIDA = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gbCompra = new System.Windows.Forms.GroupBox();
            this.txtDATA_ENTRADA = new System.Windows.Forms.MaskedTextBox();
            this.txtCOD_CLIENTE_ENTRADA = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNOME_CLIENTE_ENTRADA = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRENAVAM = new System.Windows.Forms.MaskedTextBox();
            this.txtCOR = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbANO_MODELO = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbANO_FABRICACAO = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMARCA = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFECHAR = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.btGRAVAR = new System.Windows.Forms.Button();
            this.txtOBSERVACOES = new System.Windows.Forms.TextBox();
            this.txtPLACA = new System.Windows.Forms.MaskedTextBox();
            this.txtVERSAO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCOD_MOV_VEICULOS = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCONSULTA = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtVALOR_ENTRADA = new System.Windows.Forms.TextBox();
            this.txtVALOR_SAIDA = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.gbVenda.SuspendLayout();
            this.gbCompra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbMODELO);
            this.tabPage1.Controls.Add(this.gbVenda);
            this.tabPage1.Controls.Add(this.gbCompra);
            this.tabPage1.Controls.Add(this.txtRENAVAM);
            this.tabPage1.Controls.Add(this.txtCOR);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.cbANO_MODELO);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cbANO_FABRICACAO);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cbMARCA);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.txtOBSERVACOES);
            this.tabPage1.Controls.Add(this.txtPLACA);
            this.tabPage1.Controls.Add(this.txtVERSAO);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbMODELO
            // 
            this.cbMODELO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMODELO.FormattingEnabled = true;
            this.cbMODELO.Location = new System.Drawing.Point(188, 91);
            this.cbMODELO.Name = "cbMODELO";
            this.cbMODELO.Size = new System.Drawing.Size(163, 21);
            this.cbMODELO.TabIndex = 4;
            // 
            // gbVenda
            // 
            this.gbVenda.BackColor = System.Drawing.Color.LightGray;
            this.gbVenda.Controls.Add(this.txtVALOR_SAIDA);
            this.gbVenda.Controls.Add(this.txtNOME_CLIENTE_SAIDA);
            this.gbVenda.Controls.Add(this.txtCOD_CLIENTE_SAIDA);
            this.gbVenda.Controls.Add(this.txtDATA_SAIDA);
            this.gbVenda.Controls.Add(this.label10);
            this.gbVenda.Controls.Add(this.label11);
            this.gbVenda.Controls.Add(this.label21);
            this.gbVenda.Location = new System.Drawing.Point(20, 427);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(558, 71);
            this.gbVenda.TabIndex = 17;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Venda";
            // 
            // txtNOME_CLIENTE_SAIDA
            // 
            this.txtNOME_CLIENTE_SAIDA.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNOME_CLIENTE_SAIDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNOME_CLIENTE_SAIDA.Location = new System.Drawing.Point(259, 36);
            this.txtNOME_CLIENTE_SAIDA.MaxLength = 50;
            this.txtNOME_CLIENTE_SAIDA.Name = "txtNOME_CLIENTE_SAIDA";
            this.txtNOME_CLIENTE_SAIDA.Size = new System.Drawing.Size(281, 20);
            this.txtNOME_CLIENTE_SAIDA.TabIndex = 20;
            this.txtNOME_CLIENTE_SAIDA.TabStop = false;
            this.txtNOME_CLIENTE_SAIDA.DoubleClick += new System.EventHandler(this.txtNOME_CLIENTE_SAIDA_DoubleClick);
            // 
            // txtCOD_CLIENTE_SAIDA
            // 
            this.txtCOD_CLIENTE_SAIDA.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCOD_CLIENTE_SAIDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCOD_CLIENTE_SAIDA.Location = new System.Drawing.Point(211, 36);
            this.txtCOD_CLIENTE_SAIDA.MaxLength = 50;
            this.txtCOD_CLIENTE_SAIDA.Name = "txtCOD_CLIENTE_SAIDA";
            this.txtCOD_CLIENTE_SAIDA.Size = new System.Drawing.Size(45, 20);
            this.txtCOD_CLIENTE_SAIDA.TabIndex = 21;
            this.txtCOD_CLIENTE_SAIDA.DoubleClick += new System.EventHandler(this.txtNOME_CLIENTE_SAIDA_DoubleClick);
            // 
            // txtDATA_SAIDA
            // 
            this.txtDATA_SAIDA.Location = new System.Drawing.Point(13, 36);
            this.txtDATA_SAIDA.Mask = "00/00/0000";
            this.txtDATA_SAIDA.Name = "txtDATA_SAIDA";
            this.txtDATA_SAIDA.Size = new System.Drawing.Size(80, 20);
            this.txtDATA_SAIDA.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(111, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Valor Saída";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Cliente Saída";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 63;
            this.label21.Text = "Data Saída";
            // 
            // gbCompra
            // 
            this.gbCompra.BackColor = System.Drawing.Color.LightGray;
            this.gbCompra.Controls.Add(this.txtVALOR_ENTRADA);
            this.gbCompra.Controls.Add(this.txtDATA_ENTRADA);
            this.gbCompra.Controls.Add(this.txtCOD_CLIENTE_ENTRADA);
            this.gbCompra.Controls.Add(this.label18);
            this.gbCompra.Controls.Add(this.txtNOME_CLIENTE_ENTRADA);
            this.gbCompra.Controls.Add(this.label);
            this.gbCompra.Controls.Add(this.label4);
            this.gbCompra.Location = new System.Drawing.Point(20, 341);
            this.gbCompra.Name = "gbCompra";
            this.gbCompra.Size = new System.Drawing.Size(558, 71);
            this.gbCompra.TabIndex = 12;
            this.gbCompra.TabStop = false;
            this.gbCompra.Text = "Compra";
            // 
            // txtDATA_ENTRADA
            // 
            this.txtDATA_ENTRADA.Location = new System.Drawing.Point(13, 36);
            this.txtDATA_ENTRADA.Mask = "00/00/0000";
            this.txtDATA_ENTRADA.Name = "txtDATA_ENTRADA";
            this.txtDATA_ENTRADA.Size = new System.Drawing.Size(80, 20);
            this.txtDATA_ENTRADA.TabIndex = 13;
            // 
            // txtCOD_CLIENTE_ENTRADA
            // 
            this.txtCOD_CLIENTE_ENTRADA.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCOD_CLIENTE_ENTRADA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCOD_CLIENTE_ENTRADA.Location = new System.Drawing.Point(211, 36);
            this.txtCOD_CLIENTE_ENTRADA.MaxLength = 50;
            this.txtCOD_CLIENTE_ENTRADA.Name = "txtCOD_CLIENTE_ENTRADA";
            this.txtCOD_CLIENTE_ENTRADA.Size = new System.Drawing.Size(45, 20);
            this.txtCOD_CLIENTE_ENTRADA.TabIndex = 16;
            this.txtCOD_CLIENTE_ENTRADA.DoubleClick += new System.EventHandler(this.txtNOME_CLIENTE_ENTRADA_DoubleClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(112, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "Valor Entrada";
            // 
            // txtNOME_CLIENTE_ENTRADA
            // 
            this.txtNOME_CLIENTE_ENTRADA.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNOME_CLIENTE_ENTRADA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNOME_CLIENTE_ENTRADA.Location = new System.Drawing.Point(259, 36);
            this.txtNOME_CLIENTE_ENTRADA.MaxLength = 50;
            this.txtNOME_CLIENTE_ENTRADA.Name = "txtNOME_CLIENTE_ENTRADA";
            this.txtNOME_CLIENTE_ENTRADA.Size = new System.Drawing.Size(281, 20);
            this.txtNOME_CLIENTE_ENTRADA.TabIndex = 15;
            this.txtNOME_CLIENTE_ENTRADA.TabStop = false;
            this.txtNOME_CLIENTE_ENTRADA.DoubleClick += new System.EventHandler(this.txtNOME_CLIENTE_ENTRADA_DoubleClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(208, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 13);
            this.label.TabIndex = 73;
            this.label.Text = "Cliente Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Data Entrada";
            // 
            // txtRENAVAM
            // 
            this.txtRENAVAM.Location = new System.Drawing.Point(177, 196);
            this.txtRENAVAM.Mask = "0000000000";
            this.txtRENAVAM.Name = "txtRENAVAM";
            this.txtRENAVAM.PromptChar = ' ';
            this.txtRENAVAM.Size = new System.Drawing.Size(93, 20);
            this.txtRENAVAM.TabIndex = 10;
            // 
            // txtCOR
            // 
            this.txtCOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCOR.Location = new System.Drawing.Point(358, 143);
            this.txtCOR.MaxLength = 20;
            this.txtCOR.Name = "txtCOR";
            this.txtCOR.Size = new System.Drawing.Size(141, 20);
            this.txtCOR.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(355, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Cor";
            // 
            // cbANO_MODELO
            // 
            this.cbANO_MODELO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbANO_MODELO.FormattingEnabled = true;
            this.cbANO_MODELO.Items.AddRange(new object[] {
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.cbANO_MODELO.Location = new System.Drawing.Point(177, 143);
            this.cbANO_MODELO.Name = "cbANO_MODELO";
            this.cbANO_MODELO.Size = new System.Drawing.Size(93, 21);
            this.cbANO_MODELO.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(174, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Ano Modelo";
            // 
            // cbANO_FABRICACAO
            // 
            this.cbANO_FABRICACAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbANO_FABRICACAO.FormattingEnabled = true;
            this.cbANO_FABRICACAO.Items.AddRange(new object[] {
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.cbANO_FABRICACAO.Location = new System.Drawing.Point(20, 143);
            this.cbANO_FABRICACAO.Name = "cbANO_FABRICACAO";
            this.cbANO_FABRICACAO.Size = new System.Drawing.Size(93, 21);
            this.cbANO_FABRICACAO.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(185, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Modelo";
            // 
            // cbMARCA
            // 
            this.cbMARCA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMARCA.FormattingEnabled = true;
            this.cbMARCA.Location = new System.Drawing.Point(19, 91);
            this.cbMARCA.Name = "cbMARCA";
            this.cbMARCA.Size = new System.Drawing.Size(163, 21);
            this.cbMARCA.TabIndex = 3;
            this.cbMARCA.SelectedValueChanged += new System.EventHandler(this.cbMARCA_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Marca";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btFECHAR);
            this.panel2.Controls.Add(this.btEXCLUIR);
            this.panel2.Controls.Add(this.btGRAVAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 518);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(595, 41);
            this.panel2.TabIndex = 12;
            this.panel2.TabStop = true;
            // 
            // btFECHAR
            // 
            this.btFECHAR.Dock = System.Windows.Forms.DockStyle.Right;
            this.btFECHAR.Image = ((System.Drawing.Image)(resources.GetObject("btFECHAR.Image")));
            this.btFECHAR.Location = new System.Drawing.Point(514, 6);
            this.btFECHAR.Name = "btFECHAR";
            this.btFECHAR.Size = new System.Drawing.Size(75, 29);
            this.btFECHAR.TabIndex = 24;
            this.btFECHAR.Text = "&Fechar";
            this.btFECHAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFECHAR.UseVisualStyleBackColor = true;
            this.btFECHAR.Click += new System.EventHandler(this.btFECHAR_Click);
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEXCLUIR.Enabled = false;
            this.btEXCLUIR.Image = ((System.Drawing.Image)(resources.GetObject("btEXCLUIR.Image")));
            this.btEXCLUIR.Location = new System.Drawing.Point(81, 6);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(75, 29);
            this.btEXCLUIR.TabIndex = 23;
            this.btEXCLUIR.Text = "&Excluir";
            this.btEXCLUIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEXCLUIR.UseVisualStyleBackColor = true;
            this.btEXCLUIR.Click += new System.EventHandler(this.btEXCLUIR_Click);
            // 
            // btGRAVAR
            // 
            this.btGRAVAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btGRAVAR.Image = ((System.Drawing.Image)(resources.GetObject("btGRAVAR.Image")));
            this.btGRAVAR.Location = new System.Drawing.Point(6, 6);
            this.btGRAVAR.Name = "btGRAVAR";
            this.btGRAVAR.Size = new System.Drawing.Size(75, 29);
            this.btGRAVAR.TabIndex = 22;
            this.btGRAVAR.Text = "&Gravar";
            this.btGRAVAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGRAVAR.UseVisualStyleBackColor = true;
            this.btGRAVAR.Click += new System.EventHandler(this.btGRAVAR_Click);
            // 
            // txtOBSERVACOES
            // 
            this.txtOBSERVACOES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOBSERVACOES.Location = new System.Drawing.Point(20, 251);
            this.txtOBSERVACOES.MaxLength = 500;
            this.txtOBSERVACOES.Multiline = true;
            this.txtOBSERVACOES.Name = "txtOBSERVACOES";
            this.txtOBSERVACOES.Size = new System.Drawing.Size(558, 72);
            this.txtOBSERVACOES.TabIndex = 11;
            // 
            // txtPLACA
            // 
            this.txtPLACA.Location = new System.Drawing.Point(20, 196);
            this.txtPLACA.Mask = "AAA-9999";
            this.txtPLACA.Name = "txtPLACA";
            this.txtPLACA.PromptChar = ' ';
            this.txtPLACA.Size = new System.Drawing.Size(93, 20);
            this.txtPLACA.TabIndex = 9;
            // 
            // txtVERSAO
            // 
            this.txtVERSAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVERSAO.Location = new System.Drawing.Point(358, 92);
            this.txtVERSAO.MaxLength = 20;
            this.txtVERSAO.Name = "txtVERSAO";
            this.txtVERSAO.Size = new System.Drawing.Size(220, 20);
            this.txtVERSAO.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Observações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Placa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "RENAVAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano Fabricação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Versão";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCOD_MOV_VEICULOS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 52);
            this.panel1.TabIndex = 0;
            // 
            // txtCOD_MOV_VEICULOS
            // 
            this.txtCOD_MOV_VEICULOS.Enabled = false;
            this.txtCOD_MOV_VEICULOS.Location = new System.Drawing.Point(16, 22);
            this.txtCOD_MOV_VEICULOS.Mask = "0000000";
            this.txtCOD_MOV_VEICULOS.Name = "txtCOD_MOV_VEICULOS";
            this.txtCOD_MOV_VEICULOS.PromptChar = ' ';
            this.txtCOD_MOV_VEICULOS.Size = new System.Drawing.Size(100, 20);
            this.txtCOD_MOV_VEICULOS.TabIndex = 2;
            this.txtCOD_MOV_VEICULOS.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 511);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtCONSULTA
            // 
            this.txtCONSULTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCONSULTA.Location = new System.Drawing.Point(144, 12);
            this.txtCONSULTA.Name = "txtCONSULTA";
            this.txtCONSULTA.Size = new System.Drawing.Size(433, 20);
            this.txtCONSULTA.TabIndex = 1;
            this.txtCONSULTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCONSULTA_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCONSULTA);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 45);
            this.panel3.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Digite placa para consulta:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 588);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // txtVALOR_ENTRADA
            // 
            this.txtVALOR_ENTRADA.Location = new System.Drawing.Point(114, 36);
            this.txtVALOR_ENTRADA.Name = "txtVALOR_ENTRADA";
            this.txtVALOR_ENTRADA.Size = new System.Drawing.Size(91, 20);
            this.txtVALOR_ENTRADA.TabIndex = 14;
            this.txtVALOR_ENTRADA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVALOR_ENTRADA_KeyDown);
            // 
            // txtVALOR_SAIDA
            // 
            this.txtVALOR_SAIDA.Location = new System.Drawing.Point(114, 37);
            this.txtVALOR_SAIDA.Name = "txtVALOR_SAIDA";
            this.txtVALOR_SAIDA.Size = new System.Drawing.Size(91, 20);
            this.txtVALOR_SAIDA.TabIndex = 19;
            this.txtVALOR_SAIDA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVALOR_SAIDA_KeyDown);
            // 
            // frmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 588);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMovimentacao";
            this.Load += new System.EventHandler(this.frmMovimentacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovimentacao_KeyDown);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            this.gbCompra.ResumeLayout(false);
            this.gbCompra.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFECHAR;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.Button btGRAVAR;
        private System.Windows.Forms.TextBox txtOBSERVACOES;
        private System.Windows.Forms.MaskedTextBox txtPLACA;
        private System.Windows.Forms.TextBox txtVERSAO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtCOD_MOV_VEICULOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCONSULTA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMARCA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbANO_FABRICACAO;
        private System.Windows.Forms.TextBox txtCOR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbANO_MODELO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtRENAVAM;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.TextBox txtNOME_CLIENTE_SAIDA;
        private System.Windows.Forms.TextBox txtCOD_CLIENTE_SAIDA;
        private System.Windows.Forms.MaskedTextBox txtDATA_SAIDA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox gbCompra;
        private System.Windows.Forms.TextBox txtCOD_CLIENTE_ENTRADA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNOME_CLIENTE_ENTRADA;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMODELO;
        private System.Windows.Forms.MaskedTextBox txtDATA_ENTRADA;
        private System.Windows.Forms.TextBox txtVALOR_SAIDA;
        private System.Windows.Forms.TextBox txtVALOR_ENTRADA;
    }
}