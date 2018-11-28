using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        public int IdMonHoc { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public MonHoc() { }
        public MonHoc(int idMonHoc, string maMonHoc, string tenMonHoc)
        {
            IdMonHoc = idMonHoc;
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;
        }
    }
}
