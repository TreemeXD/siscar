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
    public partial class frmModelos : Form
    {
        public frmModelos()
        {
            InitializeComponent();

            ModeloBLL modelobll = new ModeloBLL();
            Modelo modelo = new Modelo();

            modelobll.inserirCodigo(modelo);
            txtCOD_MODELO.Text = modelo.Cod_Modelo;
        }

        private void ZeraCampos()
        {
            //Limpa todos os campos

            ModeloBLL modelobll = new ModeloBLL();
            Modelo modelo = new Modelo();

            modelobll.inserirCodigo(modelo);
            txtCOD_MODELO.Text = modelo.Cod_Modelo;

            cbMarca.SelectedIndex = -1;
            txtDS_MODELO.Clear();
            txtDS_MODELO.Focus();
            btEXCLUIR.Enabled = false;
        }

        private void PreencherDataGrid(String NomeModelo)
        {
            ModeloBLL modelobll = new ModeloBLL();
            dataGridView1.DataSource = modelobll.consultarModelo(NomeModelo);

            dataGridView1.Columns[0].HeaderText = "Código"; 
            dataGridView1.Columns[1].HeaderText = "Marca";
            dataGridView1.Columns[2].HeaderText = "Modelo";
        }
                
        private void frmModelos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ZeraCampos();

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {
            MarcaBLL marcabll = new MarcaBLL();

            marcabll.retornaMarca();

            cbMarca.DataSource = marcabll.retornaMarca(); 
            cbMarca.DisplayMember = marcabll.retornaMarca().Columns[1].ToString();
            cbMarca.ValueMember = marcabll.retornaMarca().Columns[0].ToString();
            cbMarca.SelectedIndex = -1;            
        }

        private void btGRAVAR_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            ModeloBLL modelobll = new ModeloBLL();            

            try
            {
                int Codigo = Convert.ToInt32(cbMarca.SelectedValue);

                modelo.Cod_Modelo = txtCOD_MODELO.Text;
                modelo.Cod_Marca = Convert.ToString(Codigo);
                modelo.Ds_Modelo = txtDS_MODELO.Text;

                modelobll.verificarCampos(modelo);

                modelobll.inserirModelo(modelo);
                MessageBox.Show("O modelo " + modelo.Ds_Modelo + " foi cadastrado!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ZeraCampos();
                modelobll.inserirCodigo(modelo);
                txtCOD_MODELO.Text = modelo.Cod_Modelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            ModeloBLL modelobll = new ModeloBLL();

            modelo.Cod_Modelo = txtCOD_MODELO.Text;
            modelo.Ds_Modelo = txtDS_MODELO.Text;

            if (MessageBox.Show("Deseja EXCLUIR o modelo " + modelo.Ds_Modelo + "?", "Excluir Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modelobll.excluirModelo(modelo);
                ZeraCampos();
                modelobll.inserirCodigo(modelo);
                txtCOD_MODELO.Text = modelo.Cod_Modelo;
                btEXCLUIR.Enabled = false;
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PreencherDataGrid(null);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Modelo nodelo = new Modelo();

            try
            {
                tabControl1.SelectTab(0);
                txtDS_MODELO.Focus();
                btEXCLUIR.Enabled = true;
                txtCONSULTA.Text = "";

                txtCOD_MODELO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbMarca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDS_MODELO.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
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

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
