using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NienKhoaDAO : DataProvider
    {
        public DataTable getTables(string tableName)
        {
            string sql = "SELECT * FROM " + tableName;
            return GetTable(sql);
        }
        public DataTable getClassByYear(string idYear, string maKhoi)
        {
            var dt = getTables("Lop");
            DataTable result = dt.Clone();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[2].ToString() == idYear && dr[3].ToString() == maKhoi)
                    {
                        result.ImportRow(dr);
                    }

                }
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }


        }
        public List<NienKhoa> GetKhoaHoc()
        {
            try
            {
                var d = myExecuteReader("SELECT * FROM KhoaHoc");
                var list = new List<NienKhoa>();
                while (d.Read())
                {
                    var khoaHoc = new NienKhoa();
                    khoaHoc.IdKhoaHoc = d.GetInt32(0);
                    khoaHoc.NamHoc = d.GetInt32(1);
                    list.Add(khoaHoc);
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
