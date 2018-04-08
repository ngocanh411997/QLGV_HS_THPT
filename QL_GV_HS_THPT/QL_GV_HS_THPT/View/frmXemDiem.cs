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
using QL_GV_HS_THPT.Entity;
namespace QL_GV_HS_THPT.View
{
    public partial class frmXemDiem : Form
    {
        Diem diem = new Diem();
        DiemBUS diembus = new DiemBUS();
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            dgvXemDiemHS.DataSource = diembus.XemDiemHS();
        }
    }
}
