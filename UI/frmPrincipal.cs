using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Models;
using DAL;
using BLL;


namespace UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o SisCar?", "SisCar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
            Application.Exit();
        }
        public string usuario;

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            PerfilBLL perfilbll = new PerfilBLL();
            Perfil perfil = new Perfil();

            toolStripStatusLabel1.Text = "Bem-Vindo " + usuario + "!";

            if (perfilbll.VerificaCoreFundo(perfil).Equals("C"))

                this.BackColor = ColorTranslator.FromHtml(perfilbll.RetornaCoreFundo(perfil));

            else if (perfilbll.VerificaCoreFundo(perfil).Equals("I"))

                this.BackgroundImage = Image.FromFile(perfilbll.RetornaCoreFundo(perfil));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Data: " + DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = "Hora: " + DateTime.Now.ToShortTimeString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void consultaDetranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "WWW.detran.rs.gov.br");
        }

        private void exibirBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exibirBarraToolStripMenuItem.Checked)
                toolStrip1.Show();
            else
                toolStrip1.Hide();
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg1 = new DialogResult();
            if (this.BackgroundImage != null)
            {
                dlg1 = MessageBox.Show("Deseja descartar o papel de parede atual?", "Cor de fundo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            if ((dlg1 == DialogResult.Yes) || (dlg1 == DialogResult.None))
            {
                Perfil perfil = new Perfil();
                PerfilBLL perfilbll = new PerfilBLL();



                colorDialog1.ShowDialog();
                this.BackColor = colorDialog1.Color;
                perfil.Cor = ColorTranslator.ToHtml(this.BackColor);
                perfilbll.SalvarCor(perfil);
                this.BackgroundImage = null;
            }
            
        }

        private void papelDeParedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "selecione uma figura para o fundo";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de imagem |(*.bmp;*.jpg;*.gif)|Todos os arquivos| *.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

            Perfil perfil = new Perfil();
            PerfilBLL perfilbll = new PerfilBLL();

            perfil.Imagem = openFileDialog1.FileName;
            perfilbll.SalvarImagem(perfil);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Clientes frmClientes1 = new Cadastro_de_Clientes();
            frmClientes1.ShowDialog();
        }
    }
}
