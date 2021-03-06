﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_GV_HS_THPT.Entity;
using QL_GV_HS_THPT.DAL;
namespace QL_GV_HS_THPT.BUS
{
    public class ChuNhiemBUS
    {
        ChuNhiemDAL da = new ChuNhiemDAL();

        public DataTable GetData(string str)
        {
            return da.GetData(str);
        }
        public DataTable GetDaTaCN()
        {
            return da.GetDataCN();
        }

        public DataTable GetListMaLop()
        {
            return da.GetListMaLop();
        }
        public DataTable GVCN()
        {
            return da.GVCN();
        }
        public int InsertData(ChuNhiemEntity cn)
        {
            return da.InsertData(cn);
        }

        public int EditData(ChuNhiemEntity cn)
        {
            return da.EditData(cn);
        }

        public int DeleteData(string Ma)
        {
            return da.DeleteData(Ma);
        }
        public bool KiemTraTonTai(string Ma)
        {
            return da.KiemTraTonTai(Ma);
        }
        public DataTable DatCN()
        {
            return da.DatCN();
        }

    }
}
