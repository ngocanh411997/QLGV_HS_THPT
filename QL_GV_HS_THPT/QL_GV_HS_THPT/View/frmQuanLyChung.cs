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
            frmHocSinh HocSinh = new frmHocSinh();
            HocSinh.ShowDialog();
    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuNhiem_Click(object sender, EventArgs e)
        {
            frmQLChuNhiem qlcn = new frmQLChuNhiem();
            qlcn.Show();
    

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien GiaoVien = new frmGiaoVien();
            GiaoVien.ShowDialog();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc MonHoc = new frmMonHoc();
            MonHoc.ShowDialog();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmDiem Diem = new frmDiem();
            Diem.ShowDialog();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            frmLop Lop = new frmLop();
            Lop.ShowDialog();
        }
    }
}
