using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    class MonHoc
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public string Khoi { get; set; }

        public MonHoc()
        {
            MaMon = "";
            TenMon = "";
            Khoi = "";

        }
        public MonHoc( string _MaMon, string _TenMon, string _Khoi)
        {
            MaMon = _MaMon;
            TenMon = _TenMon;
            Khoi = _Khoi;
        }
    }
}
