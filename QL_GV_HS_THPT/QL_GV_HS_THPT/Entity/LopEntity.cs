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
        
      

        public LopEntity()
        {
            MaLop = "";
            TenLop = "";
         
        }
        public LopEntity(string _MaLop, string _TenLop)
        {
            MaLop = _MaLop;
            TenLop = _TenLop;
         
        }

    }
}
