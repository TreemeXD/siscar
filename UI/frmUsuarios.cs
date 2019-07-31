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
    public partial class frmUsuarios : Form
    {
        private String consulta = null; 

        public frmUsuarios()
        {
            InitializeComponent();            
        }

        private void ZeraCampos()
        {
            //Limpa todos os campos
            txtLOGIN.Clear();
            txtNOME.Clear();
            txtSENHA.Clear();
            ckSN_ATIVO.Checked = false;
            txtLOGIN.Focus();
            btEXCLUIR.Enabled = false;
            consulta = null;
        }

        private void PreencherDataGrid(String NomeCliente)
        {
            UsuarioBLL usuariobll = new UsuarioBLL();
            dataGridView1.DataSource = usuariobll.consultarUsuario(NomeCliente);

            dataGridView1.Columns[0].HeaderText = "Login";
            dataGridView1.Columns[1].HeaderText = "Nome"; 
            dataGridView1.Columns[2].HeaderText = "Senha";
            dataGridView1.Columns[3].HeaderText = "Ativo";            
        }               

        private void frmUsuarios_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCONSULTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                PreencherDataGrid(txtCONSULTA.Text);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            try
            {
                tabControl1.SelectTab(0);
                consulta = "S";
                txtLOGIN.Focus();
                btEXCLUIR.Enabled = true;
                txtCONSULTA.Text = "";
                txtLOGIN.Enabled = false;
                txtNOME.Focus();

                txtLOGIN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNOME.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSENHA.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();                
                usuario.Ativo = dataGridView1.CurrentRow.Cells[3].Value.ToString();                             

                if (usuario.Ativo == "S")
                    ckSN_ATIVO.Checked = true;
                else
                    ckSN_ATIVO.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("A Pesquisa selecionada, não contém Dados!", "Consulta Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }        

        private void btGRAVAR_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioBLL usuariobll = new UsuarioBLL();

            try
            {
                usuario.Login = txtLOGIN.Text;
                usuario.Nome = txtNOME.Text;
                usuario.Senha = txtSENHA.Text;

                if (ckSN_ATIVO.Checked)
                    usuario.Ativo = "S";
                else
                    usuario.Ativo = "N";

                usuariobll.verificarCampos(usuario);

                if (consulta == null)
                {
                    if (usuariobll.verificarUsuario(usuario))
                    {
                        MessageBox.Show("Esse login já está sendo utilizado por outro Usuário!", "Login Existente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        usuariobll.inserirUsuario(usuario);                        
                        MessageBox.Show("O usuário " + usuario.Nome + " foi cadastrado!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ZeraCampos();                       
                    }
                }
                else
                {
                    usuariobll.atulizarUsuario(usuario);
                    MessageBox.Show("A atualização do usuário: " + usuario.Nome + " foi feita com Sucesso!", "Atualização Efetuada com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ZeraCampos();
                    consulta = null;
                    txtLOGIN.Enabled = true;
                    txtLOGIN.Focus();
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioBLL usuariobll = new UsuarioBLL();

            usuario.Login = txtLOGIN.Text;
            usuario.Nome = txtNOME.Text;

            if (MessageBox.Show("Deseja EXCLUIR o usuário " + usuario.Nome + "?", "Excluir Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usuariobll.excluirUsuario(usuario);
                ZeraCampos();
                consulta = null;
                btEXCLUIR.Enabled = false;
            }        
        }

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }       
    }
}
