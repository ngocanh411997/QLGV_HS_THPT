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
    public class LopBUS
    {
        LopDAL da = new LopDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public DataTable TimKiem(string str)
        {
            return da.TimKiem(str);
        }
        public DataTable GetDataID(string ID)
        {
            return da.GetDataID(ID);
        }
      
        public int ThemLop(LopEntity lop)
        {
            return da.ThemLop(lop);
        }
        public int SuaLop(LopEntity lop)
        {
            return da.SuaLop(lop);
        }
        public int XoaLop(string ID)
        {
            return da.Xoalop(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable TimKiemLop(string str)
        {
            return da.TimKiemLop(str);
        }
    }
}
