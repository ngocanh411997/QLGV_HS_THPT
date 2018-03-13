using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    class Diem
    {
        public string MaHS { get; set; }
        public string MaMon { get; set; }
        public float DiemMieng { get; set; }
        public float Diem15ph { get; set; }
        public float Diem1Tiet { get; set; }
        public float DiemHocKy { get; set; }

        public Diem()
        {
            MaHS = "";
            MaMon = "";
            DiemMieng = 0;
            Diem15ph = 0;
            Diem1Tiet = 0;
            DiemHocKy = 0;
        }
        public Diem(string _MaHS, string _MaMon, float _DiemMieng, float _Diem15ph, float _Diem1Tiet, float _DiemHocKy)
        {
            MaHS = _MaHS;
            MaMon = _MaMon;
            DiemMieng = _DiemMieng;
            Diem15ph = _Diem15ph;
            Diem1Tiet = _Diem1Tiet;
            DiemHocKy = _DiemHocKy;
        }
    }
}
