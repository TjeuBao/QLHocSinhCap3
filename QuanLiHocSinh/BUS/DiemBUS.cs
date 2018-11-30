using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DiemBUS
    {
        DiemDAO diemDAO = new DiemDAO();
        public List<DiemMonHoc> GetDiemMonHoc(int malop,int mamonhoc,int mahocki)
        {
            try
            {
                return diemDAO.GetDiemMonHoc(malop, mamonhoc, mahocki);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ThemDiem(Diem d)
        {
            try
            {
                return diemDAO.ThemDiem(d);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int SuaDiem(Diem d)
        {
            try
            {
                return diemDAO.SuaDiem(d);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
