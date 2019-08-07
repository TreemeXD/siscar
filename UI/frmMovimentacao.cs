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
    public partial class frmMovimentacao : Form
    {
        private String consulta = null; 
        public String Entrada_Saida = null; 
        
        public frmMovimentacao()
        {
            InitializeComponent();

            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
            Movimentacao movimentacao = new Movimentacao();

            movimentacaobll.inserirCodigo(movimentacao);
            txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
            btEXCLUIR.Enabled = false;
            cbMARCA.Focus();
        }      

        private void ZeraCampos()
        {
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
            Movimentacao movimentacao = new Movimentacao();

            movimentacaobll.inserirCodigo(movimentacao);
            txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;

            //Limpa todos os campos  
            cbMARCA.SelectedIndex = -1;
            cbMODELO.SelectedIndex = -1;            
            txtVERSAO.Clear();
            cbANO_FABRICACAO.SelectedIndex = -1;
            cbANO_MODELO.SelectedIndex = -1;
            txtCOR.Clear();
            txtPLACA.Clear();
            txtRENAVAM.Clear();
            txtOBSERVACOES.Clear();
            txtDATA_ENTRADA.Clear();
            txtDATA_SAIDA.Clear();
            txtVALOR_ENTRADA.Clear();
            txtVALOR_SAIDA.Clear();
            txtCOD_CLIENTE_ENTRADA.Clear();
            txtCOD_CLIENTE_SAIDA.Clear();
            txtNOME_CLIENTE_ENTRADA.Clear();
            txtNOME_CLIENTE_SAIDA.Clear();            
            btEXCLUIR.Enabled = false;
            consulta = null;
        }

        private void PreencherDataGrid(String Texto)
        {
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();            

            if (Entrada_Saida == "E")
            {
                dataGridView1.DataSource = movimentacaobll.consultarMovimentacaoEntrada(Texto);
                dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                dataGridView1.Columns[12].HeaderText = "Cliente Entrada";           
            }
            else
            {
                dataGridView1.DataSource = movimentacaobll.consultarMovimentacaoSaida(Texto);
                dataGridView1.Columns[10].HeaderText = "Dt. Saída";
                dataGridView1.Columns[11].HeaderText = "Vr. Saída";
                dataGridView1.Columns[12].HeaderText = "Cliente Saída";
            }

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
        }

        private void frmMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ZeraCampos();

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {
            MarcaBLL marcabll = new MarcaBLL();

            if (Entrada_Saida == "E")
            {
                gbVenda.Visible = false;
                this.Text = "Entrada (Compra)";                 
            }
            else
            {
                gbCompra.Visible = false;                
                this.Text = "Saída (Venda)";
                tabControl1.SelectTab(1);
            }
            
            cbMARCA.DataSource = marcabll.retornaMarca();
            cbMARCA.DisplayMember = marcabll.retornaMarca().Columns[1].ToString();
            cbMARCA.ValueMember = marcabll.retornaMarca().Columns[0].ToString();
            cbMARCA.SelectedIndex = -1;
        }       

        private void btGRAVAR_Click(object sender, EventArgs e)
        {
            Movimentacao movimentacao = new Movimentacao();
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();

            try
            {
                movimentacao.Cod_Mov_Veiculos = txtCOD_MOV_VEICULOS.Text;
                movimentacao.Cod_Marca = Convert.ToString(cbMARCA.SelectedValue);
                movimentacao.Cod_Modelo = Convert.ToString(cbMODELO.SelectedValue);
                movimentacao.Versao = txtVERSAO.Text;
                movimentacao.Ano_Fabricacao = cbANO_FABRICACAO.Text;
                movimentacao.Ano_Modelo = cbANO_MODELO.Text;
                movimentacao.Cor = txtCOR.Text;
                movimentacao.Placa = txtPLACA.Text;
                movimentacao.Renavam = txtRENAVAM.Text;
                movimentacao.Observacoes = txtOBSERVACOES.Text;                

                movimentacaobll.verificarCampos(movimentacao);   

                if (Entrada_Saida == "E")
                {
                    movimentacao.Valor_Entrada = txtVALOR_ENTRADA.Text.Replace(",",".");
                    movimentacao.Data_Entrada = txtDATA_ENTRADA.Text;
                    movimentacao.Cod_Cliente_Entrada = txtCOD_CLIENTE_ENTRADA.Text;
                    movimentacaobll.verificarCamposCompra(movimentacao);
                }
                else
                {
                    movimentacao.Valor_Saida = txtVALOR_SAIDA.Text.Replace(",",".");
                    movimentacao.Data_Saida = txtDATA_SAIDA.Text;
                    movimentacao.Cod_Cliente_Saida = txtCOD_CLIENTE_SAIDA.Text;
                    movimentacaobll.verificarCamposVenda(movimentacao);
                }               

                if (consulta == null && Entrada_Saida == "E")
                {                    
                    movimentacaobll.inserirMovimentacaoEntrada(movimentacao);
                    MessageBox.Show("A movimentação foi inserida com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else if (consulta == null && Entrada_Saida == "S")
                {
                    movimentacaobll.inserirMovimentacaoSaida(movimentacao);
                    MessageBox.Show("A movimentação foi inserida com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else if (consulta != null && Entrada_Saida == "E")
                {
                    movimentacaobll.atulizarMovimentacaoEntrada(movimentacao);
                    MessageBox.Show("A atualização da movimentação foi efetuado com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
                }
                else if (consulta != null && Entrada_Saida == "S")
                {                    
                    movimentacaobll.atulizarMovimentacaoSaida(movimentacao);
                    MessageBox.Show("A atualização da movimentação foi efetuado com Sucesso!", "Atualização Efetuada com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                   
                    consulta = null;
                }
                
                ZeraCampos();
                movimentacaobll.inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            Movimentacao movimentacao = new Movimentacao();
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();

            movimentacao.Cod_Mov_Veiculos = txtCOD_MOV_VEICULOS.Text;            

            if (MessageBox.Show("Deseja EXCLUIR essa Movimentação?", "Excluir Movimentação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                movimentacaobll.excluirMovimentacao(movimentacao);
                ZeraCampos();
                movimentacaobll.inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
                consulta = null;
                btEXCLUIR.Enabled = false;
            }
        }

        private void txtCONSULTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PreencherDataGrid(txtCONSULTA.Text);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PreencherDataGrid(null);            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ClienteBLL clientebll = new ClienteBLL(); 
            Cliente cliente = new Cliente();
            Movimentacao movimentacao = new Movimentacao();
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
            
            try
            {
                tabControl1.SelectTab(0);
                consulta = "S";
                cbMARCA.Focus();
                btEXCLUIR.Enabled = true;
                txtCONSULTA.Text = "";                
                txtCOD_CLIENTE_ENTRADA.Text = "";
                txtCOD_CLIENTE_SAIDA.Text = "";
                txtNOME_CLIENTE_ENTRADA.Text = "";
                txtNOME_CLIENTE_SAIDA.Text = "";

                txtCOD_MOV_VEICULOS.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbMARCA.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cbMODELO.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();                
                txtVERSAO.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbANO_FABRICACAO.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cbANO_MODELO.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtCOR.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtPLACA.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtRENAVAM.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtOBSERVACOES.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                if (Entrada_Saida == "E")
                {
                    txtDATA_ENTRADA.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    txtVALOR_ENTRADA.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    txtNOME_CLIENTE_ENTRADA.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    cliente.Nome = txtNOME_CLIENTE_ENTRADA.Text;
                    clientebll.pesquisarCliente(cliente);
                    txtCOD_CLIENTE_ENTRADA.Text = cliente.Cod_Cliente;
                }
                else
                {
                    txtDATA_SAIDA.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();   
                    txtVALOR_SAIDA.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();                                
                    txtNOME_CLIENTE_SAIDA.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    cliente.Nome = txtNOME_CLIENTE_SAIDA.Text;
                    clientebll.pesquisarCliente(cliente);
                    txtCOD_CLIENTE_SAIDA.Text = cliente.Cod_Cliente;
                }           
            }
            catch (Exception)
            {
                MessageBox.Show("A Pesquisa selecionada, não contém Dados!", "Consulta Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ZeraCampos();
                movimentacaobll.inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
            }
        }   

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }       

        private void txtNOME_CLIENTE_ENTRADA_DoubleClick(object sender, EventArgs e)
        {
            frmClientes frmClientes1 = new frmClientes();            
            frmClientes1.ShowDialog();
            txtCOD_CLIENTE_ENTRADA.Text = frmClientes1.CodigoCliente;
            txtNOME_CLIENTE_ENTRADA.Text = frmClientes1.NomeCliente;
        }

        private void txtNOME_CLIENTE_SAIDA_DoubleClick(object sender, EventArgs e)
        {
            frmClientes frmClientes1 = new frmClientes();
            frmClientes1.ShowDialog();
            txtCOD_CLIENTE_SAIDA.Text = frmClientes1.CodigoCliente;
            txtNOME_CLIENTE_SAIDA.Text = frmClientes1.NomeCliente;
        }   
        
        private void cbMARCA_SelectedValueChanged(object sender, EventArgs e)
        {
            ModeloBLL modelobll = new ModeloBLL();           

            cbMODELO.DataSource = modelobll.retornaModelo(cbMARCA.Text);
            cbMODELO.ValueMember = modelobll.retornaModelo(cbMARCA.Text).Columns[0].ToString();
            cbMODELO.DisplayMember = modelobll.retornaModelo(cbMARCA.Text).Columns[2].ToString();
            cbMODELO.SelectedIndex = -1;
        }

        private void txtVALOR_ENTRADA_KeyDown(object sender, KeyEventArgs e)
        {
            if (((((e.KeyValue >= 96) && (e.KeyValue <= 105)) || ((e.KeyValue >= 48) && (e.KeyValue <= 57))) || ((e.KeyValue == 188) || (e.KeyValue == 8) || (e.KeyValue == 36))) == false)
                SendKeys.Send("{BACKSPACE}"); 
        }

        private void txtVALOR_SAIDA_KeyDown(object sender, KeyEventArgs e)
        {
            if (((((e.KeyValue >= 96) && (e.KeyValue <= 105)) || ((e.KeyValue >= 48) && (e.KeyValue <= 57))) || ((e.KeyValue == 188) || (e.KeyValue == 8) || (e.KeyValue == 36))) == false)
                SendKeys.Send("{BACKSPACE}"); 
        }                     
    }
}
