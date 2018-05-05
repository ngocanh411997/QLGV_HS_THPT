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
using QL_GV_HS_THPT.Entity;
namespace QL_GV_HS_THPT.View
{
    public partial class frmXemDiem : Form
    {
        Diem diem = new Diem();
        DiemBUS Bus = new DiemBUS();
        public frmXemDiem()
        {
            InitializeComponent();
        }
        string ma = "";
        public frmXemDiem(string text): this()
        {
            ma = text;
        }
        private void HienThi()
        {
            txtMaHS.Text = ma;
            txtMaHS.Enabled = false;
            dgvXemDiem.DataSource = Bus.XemDiemHS("  SELECT TenHS,TenLop,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy,TrungBinh=((DiemMieng+Diem15ph+Diem1Tiet*2+DiemHocKy*3)/7) FROM dbo.HocSinh INNER JOIN dbo.Diem ON Diem.MaHS = HocSinh.MaHS INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop INNER JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon WHERE Diem.MaHS = '" + txtMaHS.Text.Trim() + "'");
            dgvXemDiem.AutoResizeColumns();
        }
        private void frmXemDiem_Load(object sender, EventArgs e)
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
    }
}
