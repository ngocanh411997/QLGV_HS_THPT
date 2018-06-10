using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.Entity
{
    public class GiaoVienEntity
    {
        private string sdt;
        private int  luong;
        private string maGV;
        private string tenGV;
        private string maMon;
        private string gioiTinh;
        private string ngaySinh;
        private string diaChi;

        public string MaGV
        {
            get
            {
                return maGV;
            }

            set
            {
                maGV = value;
            }
        }

        public string TenGV
        {
            get
            {
                return tenGV;
            }

            set
            {
                tenGV = value;
            }
        }

        public string MaMon
        {
            get
            {
                return maMon;
            }

            set
            {
                maMon = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public int Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
            }
        }
    }
}
