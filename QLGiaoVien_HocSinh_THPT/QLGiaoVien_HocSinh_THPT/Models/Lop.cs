using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; } 
        public string MaGVCN { get; set; }

        public Lop()
        {
            MaLop = "";
            TenLop = "";
            MaGVCN = "";
        }
        public Lop(string _MaLop, string _TenLop, string _MaGVCN)
        {
            MaLop = _MaLop;
            TenLop = _TenLop;
            MaGVCN = _MaGVCN;
        }
    }

}
