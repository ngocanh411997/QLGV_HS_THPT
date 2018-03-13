using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    class PhongHoc
    {
        public string MaPhong { get; set; }
        public int SoPhong { get; set; }
        public int SoChoToiDa { get; set; }

        public PhongHoc()
        {
            MaPhong = "";
            SoPhong = 0;
            SoChoToiDa = 0;
        }
        public PhongHoc(string _MaPhong, int _SoPhong, int _SoChoToiDa)
        {
            MaPhong = _MaPhong;
            SoPhong = _SoPhong;
            SoChoToiDa = _SoChoToiDa;
        }
    }
}
