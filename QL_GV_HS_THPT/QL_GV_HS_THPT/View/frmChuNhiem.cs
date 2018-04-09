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
    public partial class frmChuNhiem : Form
    {
        ChuNhiemEntity obj = new ChuNhiemEntity();
        ChuNhiemBUS Bus = new ChuNhiemBUS();
        public frmChuNhiem()
        {
            InitializeComponent();
        }

        private void HienThi()
        {
            dgvCN.DataSource = Bus.GVCN();
        }
        private void frmChuNhiem_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
