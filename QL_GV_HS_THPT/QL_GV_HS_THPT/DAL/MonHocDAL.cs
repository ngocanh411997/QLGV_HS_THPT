using QL_GV_HS_THPT.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.DAL
{
    public class MonHocDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("MonHoc_SelectAll", null);
        }
        public int InsertData(MonHocEntity MH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMon",MH.MaMon),
                new SqlParameter("TenMon",MH.TenMon),
                new SqlParameter("Khoi",MH.Khoi)
               
        };
            return conn.ExcuteSQL("ThemMon ", para);
        }
        public int UpdateData(MonHocEntity MH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMon",MH.MaMon),
                new SqlParameter("TenMon",MH.TenMon),
                new SqlParameter("Khoi",MH.Khoi)
        };
            return conn.ExcuteSQL("SuaMon", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMon",ID)
        };
            return conn.ExcuteSQL("XoaMon", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From MonHoc", "MM");
        }
        public DataTable TimKiemMH(string TimKiem)
        {
            return conn.GetData(TimKiem);
        }
    }
}
