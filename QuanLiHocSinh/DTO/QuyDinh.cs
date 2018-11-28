using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyDinh
    {
        public int Id { get; set; }
        public string MaQuyDinh { get; set; }
        public string ThongTin { get; set; }

        public QuyDinh() { }
        public QuyDinh(int id, string maQuyDinh, string thongTin)
        {
            Id = id;
            MaQuyDinh = maQuyDinh;
            ThongTin = thongTin;
        }
    }
}
