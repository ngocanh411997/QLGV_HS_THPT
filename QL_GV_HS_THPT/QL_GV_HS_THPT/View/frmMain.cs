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
            Application.Exit();
        }

        private void quảnLýChungToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyChung QLChung = new frmQuanLyChung();
            QLChung.ShowDialog();
            this.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmhuongdan hd = new frmhuongdan();
            hd.ShowDialog();
            this.Show();
            
        }
    }
}
