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
                new SqlParameter("TenLop",lop.TenLop),
                new SqlParameter("MaGVCN",lop.MaGVCN)
            };
            return conn.ExcuteSQL("Them_Lop", para);
        }
        public int SuaLop(LopEntity lop)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("MaLop",lop.MaLop),
                 new SqlParameter("TenLop", lop.TenLop),
                 new SqlParameter("MaGVCN", lop.MaGVCN)
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
            return conn.TangMa(" SELECT * FROM Lop", "MaLop");
        }
        public static List<LopEntity> TimKiem(int type, string TuKhoa)
        {
            string query = "";
            KetNoi conn = new KetNoi();
            switch (type)
            {
                case 0:
                    query = string.Format("SELECT * FROM dbo.Lop WHERE MaLop LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<LopEntity>(conn.GetData(query));
                case 1:

                    query = string.Format("SELECT * FROM dbo.Lop WHERE TenLop LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<LopEntity>(conn.GetData(query));
             
            }
            return Helper.ToListof<LopEntity>(conn.GetData("SELECT * from dbo.Lop"));
        }

    }
}
