using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.Entity
{
    public class MonHocEntity
    {
        public string MaMon { get; set;}
        public string TenMon { get; set; }
        public string Khoi { get; set; }

        public MonHocEntity()
        {
            MaMon = "";
            TenMon = "";
            Khoi = "";
        }
        public MonHocEntity(string _MaMon, string _TenMon, string _Khoi)
        {
            MaMon = _MaMon;
            TenMon = _TenMon;
            Khoi = _Khoi;
        }
    }
}
