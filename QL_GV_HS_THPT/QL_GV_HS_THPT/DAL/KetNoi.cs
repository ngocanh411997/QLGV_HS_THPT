﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GV_HS_THPT.DAL
{
    public class KetNoi
    {
        private SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLGV_HS_THPT;Integrated Security=True");
        }
        public DataTable GetData(string strSql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public string TangMa(String sql, string Ma)
        {
            SqlCommand cm = new SqlCommand(sql, conn);      // bắt đầu truy vấn
            cm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cm);     //vận chuyển dữ liệu về
            DataTable dt = new DataTable();                 //tạo 1 kho ảo để chứa dữ liệu
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                Ma = Ma + "01";
            }
            else
            {
                int k;
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                {
                    Ma = Ma + "0";
                }
                else if (k < 100)
                {
                    Ma = Ma + "";
                }
                Ma = Ma + k.ToString();
            }
            return Ma;
        }
        public DataTable GetData(string NameProc, SqlParameter[] para)
        {

            SqlCommand cmd = new SqlCommand(NameProc, conn);
            // cmd.CommandText = NameProc;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            //cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int ExcuteSQL(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
        public int ExcuteSQL(string NameProc, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = NameProc;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.Connection = conn;
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public bool KiemTraTonTai(string querySQL, string Ma)
        {
            bool b = false;
            SqlCommand cmd = new SqlCommand(querySQL, conn);
            conn.Open();
            SqlDataReader adt = cmd.ExecuteReader();
            while (adt.Read())
            {
                if (Ma == adt[0].ToString())
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                    break;
                }
            }
            conn.Close();
            return b;
        }
    }
}
