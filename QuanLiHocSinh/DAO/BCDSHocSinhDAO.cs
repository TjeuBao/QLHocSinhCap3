using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

    public class BCDSHocSinhDAO : DataProvider
    {
        DataProvider dp;
        public BCDSHocSinhDAO()
        {
            dp = new DataProvider();
        }

        public DataSet TaoDanhSachHocSinh(List<SqlParameter> paras) 
        {
            DataSet ds = dp.ExecStoreProcedrure("DanhSachHocSinhTheoLop", System.Data.CommandType.StoredProcedure,paras);
            return ds;
        }
    }
}
