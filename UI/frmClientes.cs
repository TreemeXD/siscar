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
    public partial class Cadastro_de_Clientes : Form
    {
        public Cadastro_de_Clientes()
        {
            InitializeComponent();

            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();

            clientebll.inserirCodigo(cliente);
            txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
            btnExcluir.Enabled = false;
            txtCOD_CLIENTE.Enabled = false;
        }
      private void ZeraCampos()
        {
          //Limpa todos os campos
            txtNome.Clear();
            txtCPF.Clear();
            txtDATA_NASC.Clear();
            txtENDERECO.Clear();
            txtBAIRRO.Clear();
            txtCEP.Clear();
            txtCIDADE.Clear();
            txtFONE1.Clear();
            txtFONE2.Clear();
            cbESTADO.SelectedIndex = -1;
            rbMASCULINO.Checked = false;
            rbFEMININO.Checked = false;
            txtCOD_CLIENTE.Enabled = false;
            txtNome.Focus();

        }

      private void PreencherDataGrid(string NomeCliente)
      {
          ClienteBLL clientebll = new ClienteBLL();
          dataGridView1.DataSource = clientebll.consultarCliente(NomeCliente);

          dataGridView1.Columns[0].HeaderText = "Código";
          dataGridView1.Columns[1].HeaderText = "Nome";
          dataGridView1.Columns[2].HeaderText = "CPF";
          dataGridView1.Columns[3].HeaderText = "Data_Nasc";
          dataGridView1.Columns[4].HeaderText = "Endereço";
          dataGridView1.Columns[5].HeaderText = "Bairro";
          dataGridView1.Columns[6].HeaderText = "CEP";
          dataGridView1.Columns[7].HeaderText = "Cidade";
          dataGridView1.Columns[8].HeaderText = "Estado";
          dataGridView1.Columns[9].HeaderText = "Fone1";
          dataGridView1.Columns[10].HeaderText = "Fone2";
          dataGridView1.Columns[11].HeaderText = "Sexo";
          dataGridView1.Columns[12].HeaderText = "Restrição";
      }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cadastro_de_Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ZeraCampos();
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnGRAVAR_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBLL clientebll = new ClienteBLL();

            try
            {
                cliente.Cod_Cliente = txtCOD_CLIENTE.Text;
                cliente.Nome = txtNome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.Data_Nasc = txtDATA_NASC.Text;
                cliente.Endereco = txtENDERECO.Text;
                cliente.Bairro = txtBAIRRO.Text;
                cliente.CEP = txtCEP.Text;
                cliente.Cidade = txtCIDADE.Text;
                cliente.Fone1 = txtFONE1.Text;
                cliente.Fone2 = txtFONE2.Text;
                cliente.Estado = cbESTADO.Text;

                if (rbMASCULINO.Checked)
                    cliente.Sexo = "M";
                else
                    cliente.Sexo = "F";
                if (ckRESTRICAO.Checked)
                    cliente.Restricao = "S";
                else
                    cliente.Restricao = "N";

                clientebll.VerificaCampos(cliente);
                clientebll.inserirCliente(cliente);

                MessageBox.Show("O usuário " + cliente.Nome + " foi cadastrado!", "Cadastro efetuado com sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ZeraCampos();
                clientebll.inserirCodigo(cliente);
                txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PreencherDataGrid(null);
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                PreencherDataGrid(txtCONSULTA.Text);
        }
    }
}
