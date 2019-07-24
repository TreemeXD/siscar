﻿using System;
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
        private string consulta = null;

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
            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();

            clientebll.inserirCodigo(cliente);
            txtCOD_CLIENTE.Text = cliente.Cod_Cliente;

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
            btnExcluir.Enabled = false;
            consulta = null;

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

                if (consulta == null)
                {
                    clientebll.inserirCliente(cliente);
                    MessageBox.Show("O usuário " + cliente.Nome + " foi Cadastrado!", "Cadastro efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ZeraCampos();
                    clientebll.inserirCodigo(cliente);
                    txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
                }

                else
                {
                    clientebll.atualizarCliente(cliente);
                    MessageBox.Show("A atualização do usuário: " + cliente.Nome + " foi feita com sucesso!", "Atualização efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ZeraCampos();
                    clientebll.inserirCodigo(cliente);
                    txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
                    consulta = null;
                }
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                tabControl1.SelectTab(0);
                consulta = "S";
                txtNome.Focus();
                btnExcluir.Enabled = true;
                txtCONSULTA.Text = "";

                txtCOD_CLIENTE.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCPF.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDATA_NASC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtENDERECO.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtBAIRRO.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtCEP.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtCIDADE.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cbESTADO.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtFONE1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtFONE2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                cliente.Sexo = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                cliente.Restricao = dataGridView1.CurrentRow.Cells[12].Value.ToString();

                if (cliente.Sexo == "M")
                    rbMASCULINO.Checked = true;
                else
                    rbFEMININO.Checked = true;
                if (cliente.Restricao == "S")
                    ckRESTRICAO.Checked = true;
                else
                    ckRESTRICAO.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("A pesquisa selecionada, não contém Dados!", "Consulta Vazia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBLL clientebll = new ClienteBLL();

            cliente.Cod_Cliente = txtCOD_CLIENTE.Text;
            cliente.Nome = txtNome.Text;

            if (MessageBox.Show("Deseja excluir o usuário " + cliente.Nome + "?", "Excluir Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clientebll.excluirCliente(cliente);
                ZeraCampos();
                clientebll.inserirCodigo(cliente);
                txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
                consulta = null;
                btnExcluir.Enabled = false;
            }
        }
    }
}