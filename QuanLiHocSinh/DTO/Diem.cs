using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Diem
    {
        public int MaDiem { get; set; }
        public int LoaiKiemTra { get; set; }
        public float DiemMon { get; set; }
        public int MaDiemMon { get; set; }
        public int Id { get; set; }
    }
    public class DiemMonHoc
    {
        public int MaDiem { get; set; }
        public string MaHocKi { get; set; }
        public int MaDiemMon { get; set; }
        public int MaLop { get; set; }
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public int MaMonHoc { get; set; }
        public float Diem { get; set; }
        public int LoaiKiemTra { get; set; }
        public float DTB { get; set; }
        public DiemMonHoc() { }
    }
    public class DienMonHocLop
    {
        public int MaDiemMon { get; set; }
        public int MaLop { get; set; }
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public int MaMonHoc { get; set; }
        public string DiemMieng { get; set; }
        public string Tiet { get; set; }
        public string CuoiKi { get; set; }
        public float DTB { get; set; }
        public string Phut { get; set; }
        public DienMonHocLop() { }
    }
}
