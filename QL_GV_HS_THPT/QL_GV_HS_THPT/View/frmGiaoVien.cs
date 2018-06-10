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
using QL_GV_HS_THPT.DAL;
using QL_GV_HS_THPT.BUS;
namespace QL_GV_HS_THPT.View
{
    public partial class frmGiaoVien : Form
    {
        GiaoVienEntity gv = new GiaoVienEntity();
        GiaoVienBus Bus = new GiaoVienBus();
        private int fluu = 1;
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        public void ShowMH()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListMH();
            cmbMaMon.DataSource = dt;
            cmbMaMon.DisplayMember = "MaMon";
            cmbMaMon.ValueMember = "MaMon";

        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaGV.Enabled = e;
            txtTenGV.Enabled = e;
            txtDiaChi.Enabled = e;
            cmbMaMon.Enabled = e;
            txtSdt.Enabled = e;
            txtLuong.Enabled = e;
            cmbGioiTinh.Enabled = e;
            dpNgaySinh.Enabled = e;
        }
        private void clearData()
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            cmbMaMon.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            cmbGioiTinh.Text = "";
            dpNgaySinh.Text = "";
            txtLuong.Text = "";
        }

        private void HienThi()
        {
            dgvGiaoVien.DataSource = Bus.GetData();
            ShowMH();
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenGV.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["TenGV"].Value);
                txtDiaChi.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["DiaChi"].Value);
                txtSdt.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["SDT"].Value);
                cmbMaMon.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["MaMon"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["GioiTinh"].Value);
                dpNgaySinh.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["NgaySinh"].Value);
                txtLuong.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["Luong"].Value);
            }
            else
            {
                txtMaGV.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["MaGV"].Value);
                txtTenGV.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["TenGV"].Value);
                txtDiaChi.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["DiaChi"].Value);
                txtSdt.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["SDT"].Value);
                cmbMaMon.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["MaMon"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["GioiTinh"].Value);
                dpNgaySinh.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["NgaySinh"].Value);
                txtLuong.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells["Luong"].Value);
            }
        }

        private void dgvGiaoVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvGiaoVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaGV.Text = Bus.TangMa();
            DisEnl(true);
            txtMaGV.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaGV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaGV.Text);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == " " || txtLuong.Text == "" || txtSdt.Text == "" || txtTenGV.Text == "")
            {
                MessageBox.Show("Yêu Cầu Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gv.MaGV = txtMaGV.Text;
                gv.TenGV = txtTenGV.Text;
                gv.MaMon = cmbMaMon.Text;
                gv.GioiTinh = cmbGioiTinh.Text;
                gv.NgaySinh = dpNgaySinh.Text;
                gv.DiaChi = txtDiaChi.Text;
                gv.Sdt = txtSdt.Text;
                gv.Luong = int.Parse(txtLuong.Text.ToString());
                if (fluu == 0)
                {
                    try
                    {
                        Bus.InsertData(gv);
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                        clearData();
                        DisEnl(false);
                        fluu = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("loi" + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        Bus.UpdateData(gv);
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                        clearData();
                        DisEnl(false);
                        fluu = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("loi" + ex.Message);
                    }
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cmbTimKiem.Text = "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn kiểu tìm kiếm!", "Thông báo");
            }
            else if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa!", "Thông báo");
            }
            else
            {
                if (cmbTimKiem.Text == "Mã Giáo Viên")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE MaGV LIKE '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cmbTimKiem.Text == "Tên Giáo Viên")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE TenGV LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cmbTimKiem.Text == "Mã Môn Học")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE MaMon LIKE '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cmbTimKiem.Text == "Giới Tính")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE GioiTinh LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cmbTimKiem.Text == "Ngày Sinh")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE NgaySinh LIKE '%" + txtTimKiem.Text.Trim() + "%'");

                }
                if (cmbTimKiem.Text == "Địa Chỉ")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE DiaChi LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cmbTimKiem.Text == "SĐT")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE SDT LIKE '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cmbTimKiem.Text == "Lương")
                {
                    dgvGiaoVien.DataSource = Bus.TimKiemGV("SELECT * FROM dbo.GiaoVien WHERE Luong LIKE '%" + txtTimKiem.Text.Trim() + "%'");
                }
            }
           
        }

        private void btnXemDSCN_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giáo viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                frmDSChuNhiem frmDSCN = new frmDSChuNhiem(txtMaGV.Text);
                frmDSCN.ShowDialog();
                this.Show();
            }
            
        }
    }
}
