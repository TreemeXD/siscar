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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();

            MarcaBLL marcabll = new MarcaBLL();
            Marca marca = new Marca();

            marcabll.inserirCodigo(marca);
            txtCOD_MARCA.Text = marca.Cod_Marca;
        }

        private void ZeraCampos()
        {
            //Limpa todos os campos
            MarcaBLL marcabll = new MarcaBLL();
            Marca marca = new Marca();

            marcabll.inserirCodigo(marca);
            txtCOD_MARCA.Text = marca.Cod_Marca;

            txtDS_MARCA.Clear();            
            txtDS_MARCA.Focus();
            btEXCLUIR.Enabled = false;
        }

        private void PreencherDataGrid(String NomeCliente)
        {
            MarcaBLL marcabll = new MarcaBLL();
            dataGridView1.DataSource = marcabll.consultarMarca(NomeCliente);

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Marca";            
        }

        private void frmMarcas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ZeraCampos();

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
            
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PreencherDataGrid(null);            
        }

        private void btGRAVAR_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaBLL marcabll = new MarcaBLL();

            try
            {
                marca.Cod_Marca = txtCOD_MARCA.Text;
                marca.Ds_Marca = txtDS_MARCA.Text;                

                marcabll.verificarCampos(marca);                
               
                marcabll.inserirMarca(marca);
                MessageBox.Show("A marca " + marca.Ds_Marca + " foi cadastrada!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ZeraCampos();
                marcabll.inserirCodigo(marca);
                txtCOD_MARCA.Text = marca.Cod_Marca;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaBLL marcabll = new MarcaBLL();

            marca.Cod_Marca = txtCOD_MARCA.Text;
            marca.Ds_Marca = txtDS_MARCA.Text;

            if (MessageBox.Show("Deseja EXCLUIR a marca " + marca.Ds_Marca + "?", "Excluir Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcabll.excluirMarca(marca);
                ZeraCampos();
                marcabll.inserirCodigo(marca);
                txtCOD_MARCA.Text = marca.Cod_Marca;                
                btEXCLUIR.Enabled = false;
            }            
        }

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Marca marca = new Marca();

            try
            {
                tabControl1.SelectTab(0);
                txtDS_MARCA.Focus();
                btEXCLUIR.Enabled = true;
                txtCONSULTA.Text = "";

                txtCOD_MARCA.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtDS_MARCA.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("A Pesquisa selecionada, não contém Dados!", "Consulta Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ZeraCampos();
            }
        }

        private void txtCONSULTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PreencherDataGrid(txtCONSULTA.Text);
        }
    }
}
