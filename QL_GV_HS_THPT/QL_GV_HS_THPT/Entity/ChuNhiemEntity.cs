using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.Entity
{
   public class ChuNhiemEntity
    {
        private string maGV;
        private string maLop;
        private string namHoc;
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

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }

        public string NamHoc
        {
            get
            {
                return namHoc;
            }

            set
            {
                namHoc = value;
            }
        }
    }
}
