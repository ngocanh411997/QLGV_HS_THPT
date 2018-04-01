using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GV_HS_THPT.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýChungToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyChung QLChung = new frmQuanLyChung();
            QLChung.ShowDialog();
        }
    }
}
