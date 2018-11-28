using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;

namespace DAO
{
    public class LoginDAO : DataProvider
    {
        public bool Login(Account acc)
        {
            string sql = "SELECT COUNT(Username) FROM Login WHERE Username = '" + acc.UserName + "' AND Password = '" + acc.Password + "'";
            try
            {
                int number = myExecuteScalar(sql);
                if (number > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
