namespace UI
{
    partial class frmModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelos));
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCOD_MODELO = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFECHAR = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.btGRAVAR = new System.Windows.Forms.Button();
            this.txtDS_MODELO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCONSULTA = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Digite nome para consulta:";
            // 
            // txtCOD_MODELO
            // 
            this.txtCOD_MODELO.Enabled = false;
            this.txtCOD_MODELO.Location = new System.Drawing.Point(16, 22);
            this.txtCOD_MODELO.Mask = "00000";
            this.txtCOD_MODELO.Name = "txtCOD_MODELO";
            this.txtCOD_MODELO.PromptChar = ' ';
            this.txtCOD_MODELO.Size = new System.Drawing.Size(100, 20);
            this.txtCOD_MODELO.TabIndex = 2;
            this.txtCOD_MODELO.ValidatingType = typeof(int);            
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 288);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbMarca);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.txtDS_MODELO);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Marca";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(20, 79);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(193, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btFECHAR);
            this.panel2.Controls.Add(this.btEXCLUIR);
            this.panel2.Controls.Add(this.btGRAVAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 218);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(511, 41);
            this.panel2.TabIndex = 15;
            this.panel2.TabStop = true;
            // 
            // btFECHAR
            // 
            this.btFECHAR.Dock = System.Windows.Forms.DockStyle.Right;
            this.btFECHAR.Image = ((System.Drawing.Image)(resources.GetObject("btFECHAR.Image")));
            this.btFECHAR.Location = new System.Drawing.Point(430, 6);
            this.btFECHAR.Name = "btFECHAR";
            this.btFECHAR.Size = new System.Drawing.Size(75, 29);
            this.btFECHAR.TabIndex = 2;
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
            this.btEXCLUIR.TabIndex = 1;
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
            this.btGRAVAR.TabIndex = 0;
            this.btGRAVAR.Text = "&Gravar";
            this.btGRAVAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGRAVAR.UseVisualStyleBackColor = true;
            this.btGRAVAR.Click += new System.EventHandler(this.btGRAVAR_Click);
            // 
            // txtDS_MODELO
            // 
            this.txtDS_MODELO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDS_MODELO.Location = new System.Drawing.Point(20, 136);
            this.txtDS_MODELO.MaxLength = 50;
            this.txtDS_MODELO.Name = "txtDS_MODELO";
            this.txtDS_MODELO.Size = new System.Drawing.Size(300, 20);
            this.txtDS_MODELO.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCOD_MODELO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 52);
            this.panel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(517, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
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
            this.dataGridView1.Size = new System.Drawing.Size(511, 211);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCONSULTA);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 45);
            this.panel3.TabIndex = 0;
            // 
            // txtCONSULTA
            // 
            this.txtCONSULTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCONSULTA.Location = new System.Drawing.Point(144, 12);
            this.txtCONSULTA.Name = "txtCONSULTA";
            this.txtCONSULTA.Size = new System.Drawing.Size(270, 20);
            this.txtCONSULTA.TabIndex = 1;
            this.txtCONSULTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCONSULTA_KeyDown);
            // 
            // frmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 288);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos";
            this.Load += new System.EventHandler(this.frmModelos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmModelos_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtCOD_MODELO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFECHAR;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.Button btGRAVAR;
        private System.Windows.Forms.TextBox txtDS_MODELO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCONSULTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMarca;
    }
}