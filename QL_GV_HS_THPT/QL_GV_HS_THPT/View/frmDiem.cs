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
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnThoat.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaHS.Enabled = e;
            txtMaMon.Enabled = e;
            txtDiemMieng.Enabled = e;
            txtDiem15p.Enabled = e;
            txtDiem1Tiet.Enabled = e;
            txtDiemHocKy.Enabled = e;
           // txtTimKiem.Enabled = e;
        }
        private void clearData()
        {
            txtMaMon.Text = "";
            txtDiemMieng.Text = "";
            txtDiem15p.Text = "";
            txtDiem1Tiet.Text = "";
            txtDiem15p.Text = "";
            txtDiemHocKy.Text = "";
            txtTimKiem.Text = "";
        }
        private void HienThi()
        {
            dgvDiem.DataSource = diembus.GetData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
           
            DisEnl(true);
         
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
                    diembus.XoaDiem(txtMaHS.Text);
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
            diem.MaHS = txtMaHS.Text;
            diem.MaMon = txtMaMon.Text;
            diem.DiemMieng =float.Parse(txtDiemMieng.Text);
            diem.Diem15p = float.Parse(txtDiem15p.Text);
            diem.Diem1Tiet = float.Parse(txtDiem1Tiet.Text);
            diem.DiemHocKy = float.Parse(txtDiemHocKy.Text);

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
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!");
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
            cbType.Text = "Theo Mã Học Sinh";
            HienThi();
            DisEnl(false);
        }

        private void dgvDiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            dgvDiem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHS.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["MaHS"].Value);
            txtMaMon.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["MaMon"].Value);
            txtDiemMieng.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["DiemMieng"].Value);
            txtDiem15p.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["Diem15ph"].Value);
            txtDiem1Tiet.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["Diem1Tiet"].Value);
            txtDiemHocKy.Text = Convert.ToString(dgvDiem.CurrentRow.Cells["DiemHocKy"].Value);
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbType.Text=="Theo Mã Học Sinh")
            {
                dgvDiem.DataSource = diembus.TimKiem("select * from diem where MaHS like '%" + txtTimKiem.Text + "%'");
            }
            if (cbType.Text == "Theo Mã Môn")
            {
                dgvDiem.DataSource = diembus.TimKiem("select * from diem where MaMon like '%" + txtTimKiem.Text + "%'");
            }
            if (cbType.Text == "Theo Điểm Miệng")
            {
                dgvDiem.DataSource = diembus.TimKiem("select * from diem where DiemMieng like '%" + txtTimKiem.Text + "%'");
            }
            if (cbType.Text == "Theo Điểm 15 phút")
            {
                dgvDiem.DataSource = diembus.TimKiem("select * from diem where Diem15ph like '%" + txtTimKiem.Text + "%'");
            }
            if (cbType.Text == "Theo Điểm 1 Tiết")
            {
                dgvDiem.DataSource = diembus.TimKiem("select * from diem where Diem1Tiet like '%" + txtTimKiem.Text + "%'");
            }
            if (cbType.Text == "Theo Điểm Học Kỳ")
            {
                dgvDiem.DataSource = diembus.TimKiem("select * from diem where DiemHocKy like '%" + txtTimKiem.Text + "%'");
            }
        }
    }
}
