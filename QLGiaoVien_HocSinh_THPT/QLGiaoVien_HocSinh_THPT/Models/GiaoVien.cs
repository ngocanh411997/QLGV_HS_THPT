using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    public class GiaoVien
    {
        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public long Luong { get; set; }
        public string MaMon { get; set; }

        public GiaoVien()
        {
            MaGV = "";
            TenGV = "";
            GioiTinh = true;
            NgaySinh = DateTime.Parse("1/1/1997");
            SDT = "";
            Luong = 0;
            MaMon = "";
        }
        public GiaoVien(string _MaGV, string _TenGV, bool _GT, DateTime _NgaySinh, string _SDT, string _DiaChi, long _Luong, string _MaMon)
        {
            MaGV = _MaGV;
            TenGV = _TenGV;
            GioiTinh = _GT;
            NgaySinh = _NgaySinh;
            SDT = _SDT;
            Luong = _Luong;
            MaMon = _MaMon;
        }
    }
}
