using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NienKhoaBUS
    {
        NienKhoaDAO nienKhoaDAO = new NienKhoaDAO();
        public DataTable GetTables(string tableName)
        {
            return nienKhoaDAO.getTables(tableName);
        }
        public DataTable GetClassByYear(string idYear, string maKhoi)
        {
            return nienKhoaDAO.getClassByYear(idYear, maKhoi);
        }
        public List<NienKhoa> GetKhoaHoc()
        {
            try
            {
                return nienKhoaDAO.GetKhoaHoc();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
