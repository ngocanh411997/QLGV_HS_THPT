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
    public class ChuNhiemDAL
    {

        KetNoi conn = new KetNoi();
        public DataTable GetData(string str)
        {
            return conn.GetData(str);
        }
        public DataTable GetDataCN()
        {
            return conn.GetData("GV_SelectAll", null);
        }
        public DataTable GetListMaLop()
        {
            return conn.GetData("SP_SelectMaLop ", null);
        }
        public DataTable GVCN()
        {
            return conn.GetData("Xem_GVCN", null);
        }
        public int InsertData(ChuNhiemEntity cn)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaGV",cn.MaGV),
                new SqlParameter("MaLop",cn.MaLop),
                new SqlParameter("NamHoc",cn.NamHoc)
                
        };
            return conn.ExcuteSQL("SP_ThemChuNhiem ", para);
        }

        public int EditData(ChuNhiemEntity cn)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaGV",cn.MaGV),
                new SqlParameter("MaLop",cn.MaLop),
                new SqlParameter("NamHoc",cn.NamHoc)

        };
            return conn.ExcuteSQL("SP_SuaCN ", para);
        }


        public int DeleteData(string Ma)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaGV",Ma),
                

        };
            return conn.ExcuteSQL("SP_XoaCN ", para);
        }
        public bool KiemTraTonTai(string Ma)
        {
            return conn.KiemTraTonTai("Select MaGV from ChuNhiem ", Ma);
        }
    }
}
