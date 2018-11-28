using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class MonHocBUS
    {
        public MonHocBUS() { }
        MonHocDAO _monhocDAO = new MonHocDAO();
        public List<MonHoc> getMonHoc()
        {
            try
            {
                return _monhocDAO.getMonHoc();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ThemMonHoc(MonHoc monhoc)
        {
            try
            {
                return _monhocDAO.ThemMonHoc(monhoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SuaMonHoc(MonHoc monhoc)
        {
            try
            {
                return _monhocDAO.SuaMocHoc(monhoc);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int XoaMonHoc(int idmonhoc)
        {
            try
            {
                return _monhocDAO.XoaMonHoc(idmonhoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
