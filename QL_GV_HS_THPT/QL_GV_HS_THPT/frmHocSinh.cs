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

enum GioiTinh1
{
    Nam,Nu
}
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
            txtTimKiem.Enabled = e;
            cbType.Enabled = e;
        }
        private void clearData()
        {
            txtDanToc.Text = "";
            txtDiaChi.Text = "";
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtTonGiao.Text = "";
            cbMaLop.Text = "";
        }
        private void HienThi()
        {
            dgvHocSinh.DataSource = Bus.GetData();         
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            cbType.Enabled = true;
            if (txtTimKiem.Text.Trim() == "" || txtTimKiem.Text.Trim().Length > 50)
            {
                MessageBox.Show("Lỗi Từ khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvHocSinh.Refresh();
            dgvHocSinh.DataSource = HocSinhDAL.TimKiem(cbType.SelectedIndex, txtTimKiem.Text.Trim());

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = false;
            cbType.Enabled = false;
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaHS.Text = Bus.TangMa();
            txtMaHS.Enabled = false;
            DisEnl(true);
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
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             txtMaHS.Enabled = false;
            // xử lý
            obj.MaHS = txtMaHS.Text;
            obj.TenHS = txtTenHS.Text;
            obj.MaLop = cbMaLop.Text;
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

            if (fluu == 0)
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
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            else
            {
                try
                {
                    Bus.UpdateData(obj);
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
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHS.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["MaHS"].Value);
            txtTenHS.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TenHS"].Value);
            cbMaLop.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["MaLop"].Value);
            dtNgaySinh.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["NgaySinh"].Value);
            txtDanToc.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["DanToc"].Value);
            txtTonGiao.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["TonGiao"].Value);
            txtDiaChi.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells["DiaChi"].Value);
            if (dgvHocSinh.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
            else radNu.Checked = true;         
        }

        private void dgvHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHocSinh.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        
    }
}
