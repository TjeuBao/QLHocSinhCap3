using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public bool TinhTrang { get; set; }
        public string TinhTrangText { get; set; }
        public int LopHienTai { get; set; }
        public string TenLop { get; set; }
        public HocSinh() { }

        public HocSinh(int maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt,
            string email, bool tinhTrang, int lopHienTai,string tenLop)
        {
            MaHS = maHS;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = sdt;
            Email = email;
            TinhTrang = tinhTrang;
            LopHienTai = lopHienTai;
            TenLop = tenLop;
        }        
    }
}
