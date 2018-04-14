using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_GV_HS_THPT.Entity;
using QL_GV_HS_THPT.DAL;
using System.Data;

namespace QL_GV_HS_THPT.BUS
{
    class DiemBUS
    {
        DiemDAL da = new DiemDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public DataTable TimKiem(string str)
        {
            return da.TimKiem(str);
        }
        public DataTable XemDiemHS(string str)
        {
            return da.XemDiemHS(str);
        }
        public int ThemDiem(Diem diem)
        {
            return da.ThemDiem(diem);
        }
        public int SuaDiem(Diem diem)
        {
            return da.SuaDiem(diem);
        }
        public int XoaDiem(String ID)
        {
            return da.XoaDiem(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
    }
}
