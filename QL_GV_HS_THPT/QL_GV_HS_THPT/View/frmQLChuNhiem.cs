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
    public partial class frmQLChuNhiem : Form
    {

        ChuNhiemEntity gv = new ChuNhiemEntity();
        ChuNhiemBUS Bus = new ChuNhiemBUS();
        private int fluu = 1;
        public frmQLChuNhiem()
        {
            InitializeComponent();
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            cbMaGV.Enabled = e;
            cbMaLop.Enabled = e;
            txtNamHoc.Enabled = e;
        }
        private void clearData()
        {
            cbMaGV.Text = "";
            txtNamHoc.Text = "";
            cbMaLop.Text = "";
        }


        public void ShowMaLop()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListMaLop();
            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";

        }

        public void ShowMaGV()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetDaTaCN();
            cbMaGV.DataSource = dt;
            cbMaGV.DisplayMember = "MaGV";
            cbMaGV.ValueMember = "MaGV";

        }
        private void HienThi()
        {
            this.ShowMaGV();
            this.ShowMaLop();
            dgvCN.DataSource = Bus.GVCN();
        }

        private void frmQLChuNhiem_Load(object sender, EventArgs e)
        {
            HienThi();
            //DisEnl(false);
        }

        private void dgvCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                // txtMaGV.Text = Convert.ToString(dgvCN.CurrentRow.Cells["MaGV"].Value);
                cbMaLop.Text = Convert.ToString(dgvCN.CurrentRow.Cells["TenLop"].Value);
                txtNamHoc.Text = Convert.ToString(dgvCN.CurrentRow.Cells["NamHoc"].Value);
            }
            else
            {
                cbMaGV.Text = Convert.ToString(dgvCN.CurrentRow.Cells["MaGV"].Value);
                cbMaLop.Text = Convert.ToString(dgvCN.CurrentRow.Cells["TenLop"].Value);
                txtNamHoc.Text = Convert.ToString(dgvCN.CurrentRow.Cells["NamHoc"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //string r = cbMaGV.Text;
                    Bus.DeleteData(cbMaGV.Text);
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

            gv.MaGV = cbMaGV.Text;
            gv.MaLop = cbMaLop.SelectedValue.ToString();
            gv.NamHoc = txtNamHoc.Text;
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
                    MessageBox.Show("Lỗi");
                }
            }
            else
            {
                try
                {
                    Bus.EditData(gv);
                    MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();            }
            else
                HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
        }

        private void dgvCN_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvCN.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}

