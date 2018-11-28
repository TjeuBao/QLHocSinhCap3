using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BCDSHocSinhBUS
    {
        BCDSHocSinhDAO bcdao = new BCDSHocSinhDAO();
        public BCDSHocSinhBUS() { }
        public DataSet TaoDanhSachHocSinh(List<SqlParameter> paras)
        {
            try
            {
                return bcdao.TaoDanhSachHocSinh(paras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
