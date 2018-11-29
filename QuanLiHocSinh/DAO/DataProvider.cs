using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        SqlConnection cn;

        public DataProvider()
        {
            string cnStr = "Server = .; Database = HocSinhCap3; Integrated security = true;";
            cn = new SqlConnection(cnStr);
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public void DisConnect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        //update insert delete bằng câu truy vấn bt
        public int myExecuteScalar(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            Connect();
            try
            {
                int number = (int)cmd.ExecuteScalar();
                return number;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //data table sql
        public SqlDataReader myExecuteReader(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                return (cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // update insert delete sd storeprocedure
        public int ExecProcedure(string sql, CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cm.Parameters.Add(para);
                    }
                }
                return cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ExecStoreProcedrure(string storedprocedure_name, CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandText = storedprocedure_name;
                cm.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cm.Parameters.Add(para);
                    }
                }
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter(cm);
                adpt.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public SqlDataReader ExecProcedrure(string storedprocedure_name, CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandText = storedprocedure_name;
                cm.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cm.Parameters.Add(para);
                    }
                }
                return cm.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        //tra ve bang 
        public DataTable GetTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            int numberOfRows = da.Fill(dt);
            try
            {
                if (numberOfRows > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
