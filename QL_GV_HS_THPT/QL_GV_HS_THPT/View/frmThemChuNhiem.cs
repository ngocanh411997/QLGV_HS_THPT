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
using QL_GV_HS_THPT.Entity;
using QL_GV_HS_THPT.DAL;
using QL_GV_HS_THPT.BUS;

namespace QL_GV_HS_THPT.View
{
    public partial class frmThemChuNhiem : Form
    {
        ChuNhiemEntity obj = new ChuNhiemEntity();
        ChuNhiemBUS busCN = new ChuNhiemBUS();
        GiaoVienBus busGV = new GiaoVienBus();
        public frmThemChuNhiem()
        {
            InitializeComponent();
        }

        public void ShowMaLop()
        {
            DataTable dt = new DataTable();
            dt = busCN.GetListMaLop();
            cbMaLop.DataSource = dt.Copy();
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.ValueMember = "MaLop";

        }

        public void ShowMaGV()
        {
            DataTable dt = new DataTable();
            dt = busGV.GetData();
            cbMaGV.DataSource = dt;
            cbMaGV.DisplayMember = "MaGV";
            cbMaGV.ValueMember = "MaGV";

        }
        private void HienThi()
        {
            this.ShowMaGV();
            this.ShowMaLop();
        }
        private void frmThemChuNhiem_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThemCN_Click(object sender, EventArgs e)
        {
            if(txtNamHoc.Text =="")
            {
                MessageBox.Show("Thông tin chưa được nhập đầy đủ !");
            }
            else{
                if (busCN.KiemTraTonTai(cbMaGV.Text) == true)
                {
                    MessageBox.Show("Giao vien nay da la chu nhiem ");
                }
                else
                {
                    obj.MaGV = cbMaGV.Text;
                    obj.MaLop = cbMaLop.Text;
                    obj.NamHoc = txtNamHoc.Text;
                    try
                    {
                        busCN.InsertData(obj);
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi!" + ex);
                    }
                }
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

        private void cbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView d = (DataRowView)cbMaGV.SelectedItem;

            txtTenGV.Text = d.Row["TenGV"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
