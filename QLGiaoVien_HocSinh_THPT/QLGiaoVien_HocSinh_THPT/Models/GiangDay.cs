using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    class GiangDay
    {
        public string MaGV { get; set; }
        public string MaLop { get; set; }
        public string Thu { get; set; }
        public int TietDay { get; set; }

        public GiangDay()
        {
            MaGV = "";
            MaLop = "";
            Thu = "";
            TietDay = 0;
        }
        public GiangDay(string _MaGV, string _MaLop, string _Thu, int _TietDay)
        {
            MaGV = _MaGV;
            MaLop = _MaLop;
            Thu = _Thu;
            TietDay = _TietDay;
        }
    }
}
