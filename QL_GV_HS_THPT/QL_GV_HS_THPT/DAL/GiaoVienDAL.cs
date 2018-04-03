using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_GV_HS_THPT.Entity;

namespace QL_GV_HS_THPT.DAL
{   
    public class GiaoVienDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("GV_SelectAll", null);
        }
        public DataTable GetDataByID(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("GV_SelectByID", para);
        }
        public int InsertData(GiaoVienEntity gv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaGV",gv.MaGV),
                new SqlParameter("TenGV",gv.TenGV),
                new SqlParameter("MaMon",gv.MaMon),
                new SqlParameter("GioiTinh",gv.GioiTinh),
                new SqlParameter("NgaySinh",gv.NgaySinh),
                new SqlParameter("DiaChi",gv.DiaChi),
                new SqlParameter ("Sdt",gv.Sdt),
                new SqlParameter("Luong",gv.Luong)
            };
            return conn.ExcuteSQL("Them_GV ", para);
        }
        public int UpdateData(GiaoVienEntity gv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaGV",gv.MaGV),
                new SqlParameter("TenGV",gv.TenGV),
                new SqlParameter("MaMon",gv.MaMon),
                new SqlParameter("GioiTinh",gv.GioiTinh),
                new SqlParameter("NgaySinh",gv.NgaySinh),
                new SqlParameter("DiaChi",gv.DiaChi),
                new SqlParameter ("Sdt",gv.Sdt),
                new SqlParameter("Luong",gv.Luong)
        };
            return conn.ExcuteSQL("Sua_GV ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
        };
            return conn.ExcuteSQL("Xoa_GV", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From GiaoVien", "GV");
        }
    }
}
