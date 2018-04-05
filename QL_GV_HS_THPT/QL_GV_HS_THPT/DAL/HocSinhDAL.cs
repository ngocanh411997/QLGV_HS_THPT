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
        public static List<HocSinhEntity> TimKiem(int type, string TuKhoa)
        {
            string query = "";
            KetNoi conn = new KetNoi();
            switch (type)
            {
                case 0:
                    query = string.Format("SELECT * FROM dbo.HocSinh WHERE MaHS LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<HocSinhEntity>(conn.GetData(query));
                case 1:

                    query = string.Format("SELECT * FROM dbo.HocSinh WHERE TenHS LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<HocSinhEntity>(conn.GetData(query));
                case 2:
                    query = string.Format(" SELECT * FROM dbo.HocSinh HS, dbo.Lop L WHERE HS.MaLop = L.MaLop AND L.TenLop LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<HocSinhEntity>(conn.GetData(query));
                case 3:
                    query = string.Format("SELECT * FROM dbo.HocSinh WHERE DiaChi LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<HocSinhEntity>(conn.GetData(query));
            }
            return Helper.ToListof<HocSinhEntity>(conn.GetData("SELECT MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop"));
        }
    }
}
