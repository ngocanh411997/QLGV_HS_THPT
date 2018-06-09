using QL_GV_HS_THPT.BUS;
using QL_GV_HS_THPT.DAL;
using QL_GV_HS_THPT.Entity;
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
    public partial class frmHocSinh : Form
    {
        HocSinhEntity obj = new HocSinhEntity();
        HocSinhBUS Bus = new HocSinhBUS();
        private int fluu = 1;
        public frmHocSinh()
        {
            InitializeComponent();
        }
        public void ShowLop()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListLop();
            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLamMoi.Enabled = !e;
            btnClear.Enabled = !e;
            btnThoat.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            dtNgaySinh.Enabled = e;
            radNam.Enabled = e;
            radNu.Enabled = e;
            txtDanToc.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMaHS.Enabled = e;
            txtTenHS.Enabled = e;
            txtTonGiao.Enabled = e;
            cbMaLop.Enabled = e;            
        }
        private void clearData()
        {
            txtDanToc.Text = "";
            txtDiaChi.Text = "";
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtTonGiao.Text = "";
            cbMaLop.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
        }
        private void HienThi()
        {
            dgvHocSinh.DataSource = Bus.GetData();
            dgvHocSinh.AutoResizeColumns();
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
                if (cbType.Text == "Theo Mã HS")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop WHERE MaHS LIKE '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbType.Text == "Theo Tên HS")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("EXEC dbo.TKTenHS @Ten = N'" + txtTimKiem.Text + "'");
                }
                if (cbType.Text == "Theo Lớp")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop WHERE TenLop LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbType.Text == "Theo Giới Tính")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop WHERE GioiTinh LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbType.Text == "Theo Ngày Sinh(năm-tháng-ngày)")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop WHERE NgaySinh LIKE '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbType.Text == "Theo Dân Tộc")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop WHERE DanToc LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbType.Text == "Theo Tôn Giáo")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop WHERE TonGiao LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbType.Text == "Theo Địa Chỉ")
                {
                    dgvHocSinh.DataSource = Bus.TimKiemHS("EXEC dbo.TKDCHS @Ten = N'" + txtTimKiem.Text + "'");
                }
            }
          
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaHS.Text = Bus.TangMa();
            DisEnl(true);
            txtMaHS.Enabled = false;
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
                    Bus.DeleteData(txtMaHS.Text);
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
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenHS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lớp học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radNam.Checked == false && radNu.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính cho học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dân tộc học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tôn giáo học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaHS.Enabled = false;
            // xử lý
            obj.MaHS = txtMaHS.Text;
            obj.TenHS = txtTenHS.Text;
            obj.MaLop = cbMaLop.SelectedValue.ToString();
            obj.TonGiao = txtTonGiao.Text;
            obj.DanToc = txtDanToc.Text;
            obj.NgaySinh = dtNgaySinh.Value;
            obj.DiaChi = txtDiaChi.Text;

            string gt;
            if (radNam.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            obj.GioiTinh = gt;

            if (txtMaHS.Text != "" && txtTenHS.Text !="" && cbMaLop.SelectedValue.ToString() != "" && txtDanToc.Text !="" && txtTonGiao.Text !="" && txtDiaChi.Text !="" && (radNam.Checked == true || radNu.Checked==true) && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message);
                }
            }
            else if (txtMaHS.Text != "" && txtTenHS.Text != "" && cbMaLop.SelectedValue.ToString() != "" && txtDanToc.Text != "" && txtTonGiao.Text != "" && txtDiaChi.Text != "" && (radNam.Checked == true || radNu.Checked == true) && fluu !=0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa" + ex.Message);
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

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            ShowLop();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(fluu==0)
            {
                txtTenHS.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TenHS"].Value);
                cbMaLop.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TenLop"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["NgaySinh"].Value);
                txtDanToc.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["DanToc"].Value);
                txtTonGiao.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TonGiao"].Value);
                txtDiaChi.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["DiaChi"].Value);
                if (dgvHocSinh.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }else
            {
                txtMaHS.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["MaHS"].Value);
                txtTenHS.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TenHS"].Value);
                cbMaLop.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TenLop"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["NgaySinh"].Value);
                txtDanToc.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["DanToc"].Value);
                txtTonGiao.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TonGiao"].Value);
                txtDiaChi.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["DiaChi"].Value);
                if (dgvHocSinh.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
            
        }

        private void dgvHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHocSinh.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn học sinh! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                frmXemDiem xemdiem = new frmXemDiem(txtMaHS.Text);
                xemdiem.ShowDialog();
                this.Show();
            }
           
        }
    }
}
