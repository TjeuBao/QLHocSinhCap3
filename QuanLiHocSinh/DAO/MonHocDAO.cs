using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class MonHocDAO : DataProvider
    {
        DataProvider dp;
        public MonHocDAO()
        {
            dp = new DataProvider();
        }
        public List<MonHoc> getMonHoc()
        {
            try
            {
                string sql = "SELECT * from MonHoc";
                SqlDataReader dr = dp.myExecuteReader(sql);
                List<MonHoc> list = new List<MonHoc>();
                string maMonHoc, tenMonHoc;
                int idMonHoc;
                while (dr.Read())
                {
                    idMonHoc = dr.GetInt32(0);
                    maMonHoc = dr.GetString(1);
                    tenMonHoc = dr.GetString(2);
                    MonHoc monhoc = new MonHoc(idMonHoc, maMonHoc, tenMonHoc);
                    list.Add(monhoc);
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
        public int ThemMonHoc(MonHoc monhoc)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@mamonhoc", monhoc.MaMonHoc));
            list.Add(new SqlParameter("@tenmonhoc", monhoc.TenMonHoc));
            try
            {
                return ExecProcedure("ThemMonHoc", System.Data.CommandType.StoredProcedure, list);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int SuaMocHoc(MonHoc monhoc)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@idmonhoc", monhoc.IdMonHoc));
            list.Add(new SqlParameter("@mamonhoc", monhoc.MaMonHoc));
            list.Add(new SqlParameter("@tenmonhoc", monhoc.TenMonHoc));
            try
            {
                return ExecProcedure("SuaMonHoc", System.Data.CommandType.StoredProcedure, list);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaMonHoc(int idmonhoc)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@idmonhoc", idmonhoc));
            try
            {
                return ExecProcedure("XoaMonHoc", System.Data.CommandType.StoredProcedure, list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
