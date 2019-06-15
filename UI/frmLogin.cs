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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Login = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;
               
                LoginBLL usuarioBll = new LoginBLL();

                if (usuarioBll.verificarLogin(usuario))
                {
                    frmPrincipal frmPrincipal1 = new frmPrincipal();
                    frmPrincipal1.usuario = txtUsuario.Text;
                    frmPrincipal1.Show();
                    this.Dispose(false);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto! Tente novamente!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
