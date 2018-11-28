using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KhoiBUS
    {
        public KhoiBUS() { }
        KhoiDAO _khoiDAO = new KhoiDAO();
        public List<Khoi> getKhoi()
        {
            try
            {
                return _khoiDAO.getKhoi();
            }
            catch (Exception)
            {                
                throw;
            }
        }
        
        public int ThemKhoi(Khoi khoi)
        {
            try
            {
                return _khoiDAO.ThemKhoi(khoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SuaKhoi(Khoi khoi)
        {
            try
            {
                return _khoiDAO.SuaKhoi(khoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int XoaKhoi(int makhoi,int solop)
        {
            try
            {
                return _khoiDAO.XoaKhoi(makhoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Khoi> GetTatCaKhoi()
        {
            try
            {
                return _khoiDAO.GetTatCaKhoi();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
