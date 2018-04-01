using QL_GV_HS_THPT.DAL;
using QL_GV_HS_THPT.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.BUS
{
    class HocSinhBUS
    {
        HocSinhDAL da = new HocSinhDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(HocSinhEntity HS)
        {
            return da.InsertData(HS);
        }
        public int UpdateData(HocSinhEntity HS)
        {
            return da.UpdateData(HS);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
    }
}
