//VTV
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GV_HS_THPT.BUS;
using QL_GV_HS_THPT.DAL;
using QL_GV_HS_THPT.Entity;

namespace QL_GV_HS_THPT.View
{
    public partial class frmDSChuNhiem : Form
    {

        ChuNhiemEntity obj = new ChuNhiemEntity();
        ChuNhiemBUS Bus = new ChuNhiemBUS();
        public frmDSChuNhiem()
        {
            InitializeComponent();
        }
        string ma;
        public frmDSChuNhiem(string text):this()
        {
            ma = text;
        }       
        private void HienThi()
        {
            txtMaGV.Text = ma;
            txtMaGV.Enabled = false;
            dgvDSChuNhiem.DataSource = Bus.GetData(" SELECT TenGV,TenLop,NamHoc FROM dbo.GiaoVien INNER JOIN dbo.ChuNhiem ON ChuNhiem.MaGV = GiaoVien.MaGV INNER JOIN dbo.Lop ON Lop.MaGVCN = GiaoVien.MaGV where ChuNhiem.MaGV like '%"+txtMaGV.Text.Trim()+"%'");
        }
        private void frmDSChuNhiem_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }
    }
}
