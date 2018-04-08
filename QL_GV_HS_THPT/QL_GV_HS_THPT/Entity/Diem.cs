using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.Entity
{
    public class Diem
    {

        //diem
        public string MaHS { get; set; }
        public string MaMon { get; set; }
        public float DiemMieng { get; set; }
        public float Diem15p { get; set; }
        public float Diem1Tiet { get; set; }
        public float DiemHocKy { get; set; }

        public Diem()
        {
            MaHS = "";
            MaMon = "";
            DiemMieng = 0;
            Diem15p = 0;
            Diem1Tiet = 0;
            DiemHocKy = 0;

        }

        public Diem(string mahs, string mamon, float diemmieng, float diem15p, float diem1tiet, float diemhocky)
        {
            this.MaHS = mahs;
            this.MaMon = mamon;
            this.DiemMieng = diemmieng;
            this.Diem15p = diem15p;
            this.Diem1Tiet = diem1tiet;
            this.DiemHocKy = diemhocky;
        }




    }
}
