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
    public partial class frmLop : Form
    {
        LopEntity lop = new LopEntity();
        LopBUS lop1 = new LopBUS();
        private int fluu = 1;
        public frmLop()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThoat.Enabled = !e;
            txtMalop.Enabled = e;
            txtTenlop.Enabled = e;
          
        }
        private void clearData()
        {
            txtMalop.Text = "";
            txtTenlop.Text = "";
            
        }
        private void HienThi()
        {
            dgvLop.DataSource = lop1.GetData();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                txtMalop.Text = Convert.ToString(dgvLop.CurrentRow.Cells["MaLop"].Value);
                txtTenlop.Text = Convert.ToString(dgvLop.CurrentRow.Cells["TenLop"].Value);
              
            
        }

        private void dgvLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLop.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMalop.Text = lop1.TangMa();
            DisEnl(true);
            txtMalop.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMalop.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    lop1.XoaLop(txtMalop.Text);
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
            lop.MaLop = txtMalop.Text;
            lop.TenLop = txtTenlop.Text;
           
            if (fluu == 0)
            {
                try
                {
                    lop1.ThemLop(lop);
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
                    lop1.SuaLop(lop);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

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
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cbType.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        { 
            if (cbType.Text == "Theo mã lớp")
            {
                dgvLop.DataSource = lop1.TimKiemLop("SELECT * FROM dbo.Lop where MaLop Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbType.Text == "Theo tên lớp")
            {
                dgvLop.DataSource = lop1.TimKiemLop("SELECT * FROM dbo.Lop where TenLop Like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }
    }
}
