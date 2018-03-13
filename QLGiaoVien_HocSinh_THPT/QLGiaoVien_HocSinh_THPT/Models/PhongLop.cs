using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    class PhongLop
    {
        public string MaPhong { get; set; }
        public string MaLop { get; set; }
        public string HocKy_NamHoc { get; set; }
        public string KipHoc { get; set; }

        public PhongLop()
        {
            MaPhong = "";
            MaLop = "";
            HocKy_NamHoc = "";
            KipHoc = "";
        }
        public PhongLop(string _MaPhong, string _MaLop, string _HocKy_NamHoc, string _KipHoc)
        {
            MaPhong = _MaPhong;
            MaLop = _MaLop;
            HocKy_NamHoc = _HocKy_NamHoc;
            KipHoc = _KipHoc;
        }
    }
}
