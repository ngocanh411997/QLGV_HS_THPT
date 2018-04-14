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
    class HocSinhDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("DSHS", null);
        }
        public int InsertData(HocSinhEntity HS)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHS",HS.MaHS),
                new SqlParameter("TenHS",HS.TenHS),
                new SqlParameter("GioiTinh",HS.GioiTinh),
                new SqlParameter("NgaySinh",HS.NgaySinh),
                new SqlParameter("DiaChi",HS.DiaChi),
                new SqlParameter("DanToc",HS.DanToc),
                new SqlParameter("TonGiao",HS.TonGiao),
                new SqlParameter("MaLop",HS.MaLop),
        };
            return conn.ExcuteSQL("ThemHS ", para);
        }
        public int UpdateData(HocSinhEntity HS)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHS",HS.MaHS),
                new SqlParameter("TenHS",HS.TenHS),
                new SqlParameter("GioiTinh",HS.GioiTinh),
                new SqlParameter("NgaySinh",HS.NgaySinh),
                new SqlParameter("DiaChi",HS.DiaChi),
                new SqlParameter("DanToc",HS.DanToc),
                new SqlParameter("TonGiao",HS.TonGiao),
                new SqlParameter("MaLop",HS.MaLop),
        };
            return conn.ExcuteSQL("SuaHS ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHS",ID)
        };
            return conn.ExcuteSQL("XoaHS", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From HocSinh", "HS");
        }
        public DataTable GetListLop()
        {
            return conn.GetData("Lop_SelectAll ", null);
        }
       public DataTable TimKiemHS(string TimKiem)
        {
            return conn.GetData(TimKiem);
        }
    }
}
