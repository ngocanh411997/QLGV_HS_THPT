﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.Entity
{
    public class HocSinhEntity
    {
        public string MaHS { get; set; }
        public string TenHS { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string MaLop { get; set; }

        public string TenLop { get; set; }
        public HocSinhEntity()
        {
            MaHS = "";
            TenHS = "";
            GioiTinh = "";
            NgaySinh = DateTime.Parse("1/1/1997");
            DiaChi = "";
            DanToc = "";
            TonGiao = "";
            MaLop = "";
            TenLop = "";
        }
        public HocSinhEntity(string _MaHS, string _TenHS, string _GioiTinh, DateTime _NgaySinh, string _DiaChi, string _DanToc, string _TonGiao, string _MaLop,string _TenLop)
        {
            MaHS = _MaHS;
            TenHS = _TenHS;
            GioiTinh = _GioiTinh;
            NgaySinh = _NgaySinh;
            DiaChi = _DiaChi;
            DanToc = _DanToc;
            TonGiao = _TonGiao;
            MaLop = _MaLop;
            TenLop = _TenLop;
        }
    }
}
