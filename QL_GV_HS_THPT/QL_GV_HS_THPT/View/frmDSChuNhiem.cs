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
using QL_GV_HS_THPT.BUS;
using QL_GV_HS_THPT.DAL;
using QL_GV_HS_THPT.Entity;

namespace QL_GV_HS_THPT.View
{
    public partial class frmDSChuNhiem : Form
    {

        ChuNhiemEntity obj = new ChuNhiemEntity();
        ChuNhiemBUS Bus = new ChuNhiemBUS();
        public frmDSChuNhiem()
        {
            InitializeComponent();
        }

        private void HienThi()
        {
            dgvDSCN.DataSource = Bus.GetData();
        }
        private void frmDSChuNhiem_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
