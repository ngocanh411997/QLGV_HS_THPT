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

namespace QL_GV_HS_THPT
{
    public partial class frmDiem : Form
    {
        Diem diem = new Diem();
        DiemBUS diembus = new DiemBUS();
        private int fluu = 1;
        public frmDiem()
        {
            InitializeComponent();

        }
        public void ShowMon()
        {
            DataTable dt = new DataTable();
            dt = diembus.GetListMon();
            cmbMaMon.DataSource = dt;
            cmbMaMon.DisplayMember = "TenMon";
            cmbMaMon.ValueMember = "MaMon";

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnThoat.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            cmbMaHS.Enabled = e;
            cmbMaMon.Enabled = e;
            txtDiemMieng.Enabled = e;
            txtDiem15p.Enabled = e;
            txtDiem1Tiet.Enabled = e;
            txtDiemHocKy.Enabled = e;
            // txtTimKiem.Enabled = e;
        }
        private void clearData()
        {
            cmbMaHS.Text = "";
            cmbMaMon.Text = "";
            txtDiemMieng.Text = "";
            txtDiem15p.Text = "";
            txtDiem1Tiet.Text = "";
            txtDiem15p.Text = "";
            txtDiemHocKy.Text = "";
            txtTimKiem.Text = "";
        }
        private void HienThi()
        {
            // ShowMon();
            dgvDiem.DataSource = diembus.GetData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    diembus.XoaDiem(cmbMaHS.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbMaHS.Text == "" || cmbMaMon.Text == "" || txtDiemMieng.Text == "" || txtDiem15p.Text == "" || txtDiem1Tiet.Text == "" || txtDiemHocKy.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float a;
            if (!float.TryParse(txtDiemMieng.Text, out a) || !float.TryParse(txtDiem15p.Text, out a) || !float.TryParse(txtDiem1Tiet.Text, out a) || !float.TryParse(txtDiemHocKy.Text, out a))
            {
                MessageBox.Show("Nhập điểm không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            diem.MaHS = cmbMaHS.Text;
            diem.MaMon = cmbMaMon.Text;
            diem.DiemMieng = float.Parse(txtDiemMieng.Text);
            diem.Diem15p = float.Parse(txtDiem15p.Text);
            diem.Diem1Tiet = float.Parse(txtDiem1Tiet.Text);
            diem.DiemHocKy = float.Parse(txtDiemHocKy.Text);
            if (diem.DiemMieng < 0 || diem.DiemMieng > 11 || diem.Diem15p < 0 || diem.Diem15p > 11 || diem.Diem1Tiet < 0 || diem.Diem1Tiet > 11 || diem.DiemHocKy < 0 || diem.DiemHocKy > 11)
            {
                MessageBox.Show("Nhập điểm không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (fluu == 0)
            {
                try
                {
                    diembus.ThemDiem(diem);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thêm được, học sinh này đã có điểm");
                }
            }
            else
            {
                try
                {
                    diembus.SuaDiem(diem);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            cmbMaHS.DataSource = diembus.GetMonHoc("  SELECT * FROM HocSinh");
            cmbMaHS.DisplayMember = "MaHS";
            cmbMaMon.DataSource = diembus.GetMonHoc(" SELECT * FROM dbo.MonHoc");
            cmbMaMon.DisplayMember = "MaMon";
        }

        private void dgvDiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            dgvDiem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                cmbMaMon.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["MaMon"].Value);
                txtTenMon.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["TenMon"].Value);
                txtDiemMieng.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["DiemMieng"].Value);
                txtDiem15p.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["Diem15ph"].Value);
                txtDiem1Tiet.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["Diem1Tiet"].Value);
                txtDiemHocKy.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["DiemHocKy"].Value);
            }
            else
            {
                cmbMaHS.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["MaHS"].Value);
                cmbMaMon.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["MaMon"].Value);
                txtTenMon.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["TenMon"].Value);
                txtDiemMieng.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["DiemMieng"].Value);
                txtDiem15p.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["Diem15ph"].Value);
                txtDiem1Tiet.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["Diem1Tiet"].Value);
                txtDiemHocKy.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["DiemHocKy"].Value);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn kiểu tìm kiếm!", "Thông báo");
            }
            else if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa!", "Thông báo");
            }
            else
            {
                if (cbType.Text == "Theo Mã Học Sinh")
                {
                    dgvDiem.DataSource = diembus.TimKiem("SELECT Diem.MaHS,TenHS,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS where HocSinh.MaHS like '%" + txtTimKiem.Text + "%'");
                }
                if (cbType.Text == "Theo Tên Học Sinh")
                {
                    dgvDiem.DataSource = diembus.TimKiem("SELECT Diem.MaHS,TenHS,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS where HocSinh.TenHS like N'%" + txtTimKiem.Text + "%'");
                }
                if (cbType.Text == "Theo Điểm Miệng")
                {
                    dgvDiem.DataSource = diembus.TimKiem("SELECT Diem.MaHS,TenHS,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS where Diem.DiemMieng like '%" + txtTimKiem.Text + "%'");
                }
                if (cbType.Text == "Theo Điểm 15 phút")
                {
                    dgvDiem.DataSource = diembus.TimKiem("SELECT Diem.MaHS,TenHS,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS where Diem.Diem15ph like '%" + txtTimKiem.Text + "%'");
                }
                if (cbType.Text == "Theo Điểm 1 Tiết")
                {
                    dgvDiem.DataSource = diembus.TimKiem("SELECT Diem.MaHS,TenHS,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS where Diem.Diem1Tiet like '%" + txtTimKiem.Text + "%'");
                }
                if (cbType.Text == "Theo Điểm Học Kỳ")
                {
                    dgvDiem.DataSource = diembus.TimKiem("SELECT Diem.MaHS,TenHS,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS where Diem.DiemHocKy like '%" + txtTimKiem.Text + "%'");
                }
            }

           
        }

        private void cmbMaHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)cmbMaHS.SelectedItem;
            txtTenHS.Text = dr.Row["TenHS"].ToString();
        }

        private void cmbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)cmbMaMon.SelectedItem;
            txtTenMon.Text = dr.Row["TenMon"].ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
