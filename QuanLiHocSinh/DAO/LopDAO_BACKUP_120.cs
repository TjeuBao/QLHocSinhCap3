﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class LopDAO : DataProvider
    {
         DataProvider dp;
        public LopDAO()
        {
            dp = new DataProvider();
        }
        public List<Lop> getLop()
        {
            try
            {
                string sql = "select lop.MaLop,lop.TenLop,lop.SiSo, lop.NamHoc,Khoi.TenKhoi from dbo.Lop lop join Khoi on Lop.MaKhoi = Khoi.MaKhoi";
                SqlDataReader dr = dp.myExecuteReader(sql);
                List<Lop> list = new List<Lop>();
                int malop, siso, namhoc;
                string tenlop, tenkhoi;
                while (dr.Read())
                {

                    malop = dr.GetInt32(0);
                    tenlop = dr.GetString(1);
                    siso = dr.GetInt32(2);
////<<<<<<< HEAD
//                    namhoc = dr.GetInt32(3);
//                    makhoi = dr.GetInt32(4);
//                    Lop lop = new Lop(malop, tenlop, siso, namhoc, makhoi);

//=======
                    namhoc = Convert.ToInt32(dr.GetString(3));
                    tenkhoi = dr.GetString(4);
                    Lop lop = new Lop(malop, tenlop, siso, namhoc, tenkhoi);
//>>>>>>> origin/dev
                    list.Add(lop);
                }
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }
        public int ThemLop(Lop lop)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@tenlop", lop.TenLop));
            list.Add(new SqlParameter("@namhoc", lop.NamHoc));
            list.Add(new SqlParameter("@makhoi", lop.MaKhoi));
            try
            {
                dp.Connect();
                return ExecProcedure("ThemLop", System.Data.CommandType.StoredProcedure, list);
            }
            catch (SqlException ex)
            {
                dp.DisConnect();
                throw ex;
            }
        }

        public int SuaLop(Lop lop)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@tenlop", lop.TenLop));
            list.Add(new SqlParameter("@namhoc", lop.SiSo));
            list.Add(new SqlParameter("@khoahoc", lop.NamHoc));
            try
            {
                return ExecProcedure("SuaLop", System.Data.CommandType.StoredProcedure, list);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaLop(int malop)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@malop", malop));
            try
            {
                return ExecProcedure("XoaLop", System.Data.CommandType.StoredProcedure, list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}