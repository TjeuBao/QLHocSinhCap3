using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LopBUS
    {
        public LopBUS() { }
        LopDAO _lopDAO = new LopDAO();
        public List<Lop> getLop()
        {
            try
            {
                return _lopDAO.getLop();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ThemLop(Lop lop)
        {
            try
            {
                if (_lopDAO.ThemLop(lop) == 1)
                {
                    return "Đã thêm lớp";
                }
                return "Chưa thêm lớp";
            }
            catch (Exception)
            {
                return "Đã bị lỗi";
            }
        }

        public int SuaLop(Lop lop)
        {
            try
            {
                return _lopDAO.SuaLop(lop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int XoaLop(int malop)
        {
            try
            {
                return _lopDAO.XoaLop(malop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
