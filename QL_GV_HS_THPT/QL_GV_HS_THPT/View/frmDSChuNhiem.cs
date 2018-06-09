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
        string magv;
       
        public frmDSChuNhiem(string _magv):this()
        {
            magv = _magv;         
        }
        public void ShowLop()
        {
            DataTable dt = new DataTable();
            dt = Bus.DatCN();
            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";

        }
        private void HienThi()
        {
            ShowLop();
            txtMaGV.Text = magv;
            txtMaGV.Enabled = false;
            dgvCN.DataSource = Bus.GetData("SELECT ChuNhiem.MaGV,TenGV,TenLop,NamHoc FROM dbo.GiaoVien INNER JOIN dbo.ChuNhiem ON ChuNhiem.MaGV = GiaoVien.MaGV INNER JOIN dbo.Lop ON Lop.MaLop = ChuNhiem.MaLop WHERE ChuNhiem.MaGV LIKE'"+txtMaGV.Text+"'");
            grbThaoTac.Visible = false;

        }
       
        private void frmDSChuNhiem_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void btnThemCN_Click(object sender, EventArgs e)
        {
            frmQLChuNhiem CN = new frmQLChuNhiem();
            CN.ShowDialog();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            obj.MaGV = txtMaGV.Text;
            obj.MaLop = cbMaLop.SelectedValue.ToString();
            obj.NamHoc = txtNamHoc.Text;           
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();                       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
          
        }

        private void btnDatChuNhiem_Click_1(object sender, EventArgs e)
        {
            grbThaoTac.Visible = true;
        }
    }
}
