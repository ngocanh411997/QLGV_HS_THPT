using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaoVien_HocSinh_THPT.Models
{
    class ChuNhiem
    {
        public string MaGV { get; set; }
        public string MaLop { get; set; }
        public string NamHoc { get; set; }

        public ChuNhiem()
        {
            MaGV = "";
            MaLop = "";
            NamHoc = "";
        }
        public ChuNhiem( string _MaGV, string _MaLop, string _NamHoc)
        {
            MaGV = _MaGV;
            MaLop = _MaLop;
            NamHoc = _NamHoc;
        }
    }
}
