using QL_GV_HS_THPT.BUS;
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
    public partial class frmMonHoc: Form
    {
        MonHocEntity obj = new MonHocEntity();
        MonHocBUS Bus = new MonHocBUS();
        private int fluu = 1;
        public frmMonHoc()
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
            txtMaMon.Enabled = e;
            txtTenMon.Enabled = e;         
            cbKhoi.Enabled = e;
        }
        private void clearData()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            cbKhoi.Text = "";
        }
        private void HienThi()
        {
            dgvMonHoc.DataSource = Bus.GetData();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Theo Mã Môn")
            {
                dgvMonHoc.DataSource = Bus.TimKiemMH("SELECT * FROM MonHoc WHERE MaMon LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbType.Text == "Theo Tên Môn")
            {
                dgvMonHoc.DataSource = Bus.TimKiemMH("SELECT * FROM MonHoc WHERE TenMon LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbType.Text == "Theo Khối")
            {
                dgvMonHoc.DataSource = Bus.TimKiemMH("SELECT * FROM MonHoc WHERE Khoi LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaMon.Text = Bus.TangMa();
            DisEnl(true);
            txtMaMon.Enabled = false;
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
                    Bus.DeleteData(txtMaMon.Text);
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
            txtMaMon.Enabled = false;
            // xử lý
            obj.MaMon = txtMaMon.Text;
            obj.TenMon = txtTenMon.Text;
            obj.Khoi = cbKhoi.Text;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenMon.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["TenMon"].Value);
                cbKhoi.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["Khoi"].Value);              
            }
            else
            {
                txtMaMon.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["MaMon"].Value);
                txtTenMon.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["TenMon"].Value);
                cbKhoi.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["Khoi"].Value);
            }

        }

        private void dgvMonHoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvMonHoc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }
    }
}
