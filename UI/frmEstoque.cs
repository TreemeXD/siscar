using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using BLL;

namespace UI
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void PreencherDataGrid(String Texto)
        {
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();           
            
            dataGridView1.DataSource = movimentacaobll.consultarMovimentacaoEntrada(Texto);
            dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
            dataGridView1.Columns[1].HeaderText = "Marca";
            dataGridView1.Columns[2].HeaderText = "Modelo";
            dataGridView1.Columns[3].HeaderText = "Versão";
            dataGridView1.Columns[4].HeaderText = "Ano Fab.";
            dataGridView1.Columns[5].HeaderText = "Ano Mod.";
            dataGridView1.Columns[6].HeaderText = "Cor";
            dataGridView1.Columns[7].HeaderText = "Placa";
            dataGridView1.Columns[8].HeaderText = "Renavam";
            dataGridView1.Columns[9].HeaderText = "Observações";
            dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
            dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
            dataGridView1.Columns[12].HeaderText = "Cliente Entrada";     
        }                  

        private void frmEstoque_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            PreencherDataGrid(null);            
        }

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCONSULTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PreencherDataGrid(txtCONSULTA.Text);
        }


    }
}
