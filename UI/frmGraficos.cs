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
    public partial class frmGraficos : Form
    {
        public frmGraficos()
        {
            InitializeComponent();
        }

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraficoBLL graficobll = new GraficoBLL();
            chart1.DataSource = graficobll.ConsultarMarca();
            chart1.Series["Series1"].XValueMember = "X";
            chart1.Series["Series1"].YValueMembers = "Y";
            chart1.DataBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GraficoBLL graficobll = new GraficoBLL();
            chart1.DataSource = graficobll.ConsultarModelo();
            chart1.Series["Series1"].XValueMember = "X";
            chart1.Series["Series1"].YValueMembers = "Y";
            chart1.DataBind();
        }      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Series1"].IsVisibleInLegend = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series["Series1"].IsVisibleInLegend = true;
        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }       
    }
}
