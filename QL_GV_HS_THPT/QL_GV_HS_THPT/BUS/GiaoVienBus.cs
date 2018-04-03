using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_GV_HS_THPT.Entity;
using QL_GV_HS_THPT.DAL;

namespace QL_GV_HS_THPT.BUS
{
    public class GiaoVienBus
    {
        GiaoVienDAL da = new GiaoVienDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public DataTable GetDataByID(string ID)
        {
            return da.GetDataByID(ID);
        }
        public int InsertData(GiaoVienEntity gv)
        {
            return da.InsertData(gv);
        }
        public int UpdateData(GiaoVienEntity gv)
        {
            return da.UpdateData(gv);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
    }
}
