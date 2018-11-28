using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public int IdKhoaHoc { get; set; }
        public int MaKhoi { get; set; }
        public string TenKhoi { get; set; }
        public List<HocSinh> hs { get; set; }

        public Lop(){}
        public Lop(int maLop, string tenLop, int siSo, int khoaHoc, int maKhoi)
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            IdKhoaHoc = khoaHoc;
            MaKhoi = maKhoi;
        }
        public Lop(int maLop, string tenLop, int siSo, int khoaHoc, string tenkhoi)
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            IdKhoaHoc = khoaHoc;
            TenKhoi = tenkhoi;
        }
    }
}
