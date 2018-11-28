using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class KhoiDAO : DataProvider
    {
        DataProvider dp;
        public KhoiDAO()
        {
            dp = new DataProvider();
        }
        public List<Khoi> getKhoi()
        {
            try
            {
                string sql = "SELECT k.MaKhoi, k.TenKhoi,COUNT(k.TenKhoi) as SoLop, hk.NamHoc "
                            + "FROM Lop l join Khoi k on l.MaKhoi= k.MaKhoi "
		                    + "join KhoaHoc hk on l.IdKhoaHoc = hk.IdKhoaHoc "
                            + "GROUP BY k.MaKhoi, k.TenKhoi, hk.NamHoc";
                SqlDataReader dr = dp.myExecuteReader(sql);
                List<Khoi> list = new List<Khoi>();
                int  maKhoi, soLop,namhoc;
                string tenKhoi;
                while (dr.Read())
                {
                    maKhoi = dr.GetInt32(0);
                    tenKhoi = dr.GetString(1);
                    soLop = dr.GetInt32(2);
                    namhoc = dr.GetInt32(3);
                    Khoi khoi = new Khoi(maKhoi, tenKhoi, soLop, namhoc);
                    list.Add(khoi);                    
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
        
       
        public List<Khoi> GetTatCaKhoi()
        {
            try
            {
                string sql = "SELECT * FROM Khoi";
                SqlDataReader dr = dp.myExecuteReader(sql);
                List<Khoi> list = new List<Khoi>();
                int maKhoi, soLop;
                string tenKhoi;
                while (dr.Read())
                {
                    maKhoi = dr.GetInt32(0);
                    tenKhoi = dr.GetString(1);
                    soLop = dr.GetInt32(2);
                    Khoi khoi = new Khoi(maKhoi, tenKhoi, soLop);
                    list.Add(khoi);
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

        public int ThemKhoi(Khoi khoi)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@tenkhoi", khoi.TenKhoi));
            list.Add(new SqlParameter("@solop", khoi.SoLop));
            try
            {
                return ExecProcedure("ThemKhoi", System.Data.CommandType.StoredProcedure, list);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int SuaKhoi(Khoi khoi)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@makhoi", khoi.MaKhoi));
            list.Add(new SqlParameter("@tenkhoi", khoi.TenKhoi));
            list.Add(new SqlParameter("@solop", khoi.SoLop));
            try
            {
                return ExecProcedure("SuaKhoi", System.Data.CommandType.StoredProcedure, list);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaKhoi(int makhoi)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@makhoi", makhoi));
            try
            {
                return ExecProcedure("XoaKhoi", System.Data.CommandType.StoredProcedure, list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
    }
}
