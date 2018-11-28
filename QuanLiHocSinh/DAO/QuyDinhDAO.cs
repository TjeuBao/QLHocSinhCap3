using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class QuyDinhDAO : DataProvider
    {
        DataProvider dp;
        public QuyDinhDAO()
        {
            dp = new DataProvider();
        }

        public List<QuyDinh> getQuyDinh()
        {
            try
            {
                string sql = "select * from QuyDinh";
                SqlDataReader dr = dp.myExecuteReader(sql);
                List<QuyDinh> list = new List<QuyDinh>();
                string maQuyDinh, thongTin;
                int id;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    maQuyDinh = dr.GetString(1);
                    thongTin = dr.GetString(2);
                    QuyDinh qd = new QuyDinh(id, maQuyDinh, thongTin);
                    list.Add(qd);
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
        public int ThayDoiQuyDinh(QuyDinh qd)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@id", qd.Id));
            list.Add(new SqlParameter("@maquydinh", qd.MaQuyDinh));
            list.Add(new SqlParameter("@thongtin", qd.ThongTin));
            try
            {
                return ExecProcedure("ThayDoiQuyDinh", System.Data.CommandType.StoredProcedure, list);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
