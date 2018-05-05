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
    public partial class frmQuanLyChung : Form
    {
        public frmQuanLyChung()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHocSinh HocSinh = new frmHocSinh();
            HocSinh.ShowDialog();
            this.Show();
    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuNhiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLChuNhiem qlcn = new frmQLChuNhiem();
            qlcn.ShowDialog();
            this.Show();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiaoVien GiaoVien = new frmGiaoVien();
            GiaoVien.ShowDialog();
            this.Show();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMonHoc MonHoc = new frmMonHoc();
            MonHoc.ShowDialog();
            this.Show();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiem Diem = new frmDiem();
            Diem.ShowDialog();
            this.Show();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLop Lop = new frmLop();
            Lop.ShowDialog();
            this.Show();
        }
    }
}
