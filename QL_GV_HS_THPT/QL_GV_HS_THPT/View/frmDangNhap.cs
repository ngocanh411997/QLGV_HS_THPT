using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GV_HS_THPT.Entity;
using QL_GV_HS_THPT.BUS;



namespace QL_GV_HS_THPT.View
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndbus = new NguoiDungBUS();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = ndbus.DangNhap(txbTaikhoan.Text, txbMatkhau.Text);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nd.TaiKhoan = dt.Rows[i].ToString();
                    nd.MatKhau = dt.Rows[i].ToString();
                }
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
