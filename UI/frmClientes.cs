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
    }
}
