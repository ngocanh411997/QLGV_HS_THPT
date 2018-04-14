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
    public class MonHocBUS
    {
        MonHocDAL da = new MonHocDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(MonHocEntity MH)
        {
            return da.InsertData(MH);
        }
        public int UpdateData(MonHocEntity MH)
        {
            return da.UpdateData(MH);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemMH(string TimKiem)
        {
            return da.TimKiemMH(TimKiem);
        }
    }
}
