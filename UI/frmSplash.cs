using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value = progressBar1.Value + 50;
            else
            {
                frmLogin frmLogin1 = new frmLogin();
                timer1.Enabled = false;
                frmLogin1.Show();
                this.Dispose(false);
            }
        }
    }
}
