using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_GV_HS_THPT.Entity;
using System.Data;
using System.Data.SqlClient;
namespace QL_GV_HS_THPT.DAL
{
    public class LopDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_Lop", null);
        }
        public DataTable TimKiem(string str)
        {
            return conn.GetData(str);
        }
        public DataTable GetDataID(string ID)
        {
            SqlParameter[] para = { new SqlParameter("MaLop", ID) };
            return conn.GetData("Xem_Lop_ID",para);
        }
   
     public int ThemLop(LopEntity lop)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLop",lop.MaLop),
                new SqlParameter("TenLop",lop.TenLop)
             
            };
            return conn.ExcuteSQL("Them_Lop", para);
        }
        public int SuaLop(LopEntity lop)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("MaLop",lop.MaLop),
                 new SqlParameter("TenLop", lop.TenLop)
               
        };
            return conn.ExcuteSQL("Sua_Lop", para);
        }
        public int Xoalop(string ID)
        {
            SqlParameter[] para = { new SqlParameter("@MaLop", ID) };
            return conn.ExcuteSQL("Xoa_Lop", para);
        }
        public string TangMa()
        {
            return conn.TangMa(" SELECT * FROM Lop", "ML");
        }
        public DataTable TimKiemLop(string str)
        {
            return conn.GetData(str);
        }

    }
}
