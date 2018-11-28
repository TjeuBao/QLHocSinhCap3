using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class HocSinhBUS
    {
        private readonly HocSinhDAO _hsDAO;
        public HocSinhBUS()
        {
            _hsDAO = new HocSinhDAO();
        }

        public List<HocSinh> getStudents()
        {
            try
            {
                return _hsDAO.getStudents();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //public HocSinh getStudent(int mahs)
        //{
        //    try
        //    {
        //        return _hsDAO.getStudent(mahs);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public List<HocSinh> getStudentsByLop(int maLop)
        //{
        //    try
        //    {
        //        return _hsDAO.getStudentsByLop(mahs);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int ThemHocSinh(HocSinh hs)
        {
            try
            {
                return _hsDAO.ThemHocSinh(hs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SuaHocSinh(HocSinh hs)
        {
            try
            {
                return _hsDAO.SuaHocSinh(hs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int XoaHocSinh(int mahs)
        {
            try
            {
                return _hsDAO.XoaHocSinh(mahs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
