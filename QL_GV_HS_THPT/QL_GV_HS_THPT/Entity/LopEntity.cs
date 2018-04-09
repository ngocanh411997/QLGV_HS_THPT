using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.Entity
{
    public class LopEntity
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaGVCN { get; set; }

        public LopEntity()
        {
            MaLop = "";
            TenLop = "";
            MaGVCN = "";
        }
        public LopEntity(string _MaLop, string _TenLop, string _MaGVCN)
        {
            MaLop = _MaLop;
            TenLop = _TenLop;
            MaGVCN = _MaGVCN;
        }

    }
}
