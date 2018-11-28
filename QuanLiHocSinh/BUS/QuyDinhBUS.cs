using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QuyDinhBUS
    {
        public QuyDinhBUS() { }
        QuyDinhDAO _qdDAO = new QuyDinhDAO();
        public List<QuyDinh> getQuyDinh()
        {
            try
            {
                return _qdDAO.getQuyDinh();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ThayDoiQuyDinh(QuyDinh qd)
        {
            try
            {
                return _qdDAO.ThayDoiQuyDinh(qd);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
