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
    class DiemDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_XemDiem", null);
        }
        public DataTable TimKiem(string str)
        {
            return conn.GetData(str);
        }
        public DataTable XemDiemHS(string str)
        {
            return conn.GetData(str);
        }
        public int ThemDiem(Diem diem)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHS",diem.MaHS),
                new SqlParameter("MaMon",diem.MaMon),
                new SqlParameter("DiemMieng",diem.DiemMieng),
                new SqlParameter("Diem15ph",diem.Diem15p),
                new SqlParameter("Diem1Tiet",diem.Diem1Tiet),
                new SqlParameter("DiemHocKy",diem.DiemHocKy),
        };
            return conn.ExcuteSQL("SP_ThemDiem ", para);
        }
        public int SuaDiem(Diem diem)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHS",diem.MaHS),
                new SqlParameter("MaMon",diem.MaMon),
                new SqlParameter("DiemMieng",diem.DiemMieng),
                new SqlParameter("Diem15ph",diem.Diem15p),
                new SqlParameter("Diem1Tiet",diem.Diem1Tiet),
                new SqlParameter("DiemHocKy",diem.DiemHocKy),
        };
            return conn.ExcuteSQL("SP_SuaDiem ", para);
        }
        public int XoaDiem(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHS",ID)
        };
            return conn.ExcuteSQL("SP_XoaDiem", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From Diem", "HS");
        }
    }
}
