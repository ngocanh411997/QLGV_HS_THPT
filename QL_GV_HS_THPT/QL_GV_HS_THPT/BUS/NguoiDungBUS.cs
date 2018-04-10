using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_GV_HS_THPT.Entity;
using QL_GV_HS_THPT.DAL;
using System.Data;


namespace QL_GV_HS_THPT.BUS
{
     public class NguoiDungBUS
    {
        NguoiDungDAL nddal = new NguoiDungDAL();
        public DataTable DangNhap(string TaiKhoan, string MatKhau)
        {
            return nddal.GetUser(TaiKhoan, MatKhau);
        }
    }
}
