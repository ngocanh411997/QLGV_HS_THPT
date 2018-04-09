using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_GV_HS_THPT.Entity;
using QL_GV_HS_THPT.DAL;
namespace QL_GV_HS_THPT.BUS
{
    public class ChuNhiemBUS
    {
        ChuNhiemDAL da = new ChuNhiemDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }

        public DataTable GetListMaLop()
        {
            return da.GetListMaLop();
        }

        public int InsertData(ChuNhiemEntity cn)
        {
            return da.InsertData(cn);
        }
        public bool KiemTraTonTai(string Ma)
        {
            return da.KiemTraTonTai(Ma);
        }
    }
}
