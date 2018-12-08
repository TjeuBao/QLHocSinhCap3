using BUS;
using DTO;
using QuanLiHocSinh.UtilitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    public class Init
    {
        public List<Lop> lop = new List<Lop>();
        public List<Khoi> khoi = new List<Khoi>();
        public List<NienKhoa> khoaHoc = new List<NienKhoa>();
        public List<MonHoc> mon = new List<MonHoc>();
        ComboBox cbKhoaHoc;
        ComboBox cbKhoi;
        ComboBox cbLop;
        ComboBox cbTinhTrang;
        ComboBox cbMonHoc;
        ComboBox cbHocKi;
        public Init() { }
        public Init(ComboBox khoaHoc, ComboBox Khoi, ComboBox Lop, ComboBox TinhTrang, ComboBox MonHoc, ComboBox HocKi)
        {
            cbKhoaHoc = khoaHoc;
            cbKhoi = Khoi;
            cbLop = Lop;
            cbTinhTrang = TinhTrang;
            cbMonHoc = MonHoc;
            cbHocKi = HocKi;
        }
        public void InitCombobox()
        {
            // combobox Tinh trang
            List<UtilitiesDropdown> tinhTrangs = new List<UtilitiesDropdown>();
            tinhTrangs.Add(new UtilitiesDropdown
            {
                Id = 1,
                Value = "Đang học"
            });

            tinhTrangs.Add(new UtilitiesDropdown
            {
                Id = 0,
                Value = "Thôi học"
            });

            cbTinhTrang.DataSource = tinhTrangs;
            cbTinhTrang.ValueMember = "Id";
            cbTinhTrang.DisplayMember = "Value";
        }

        public void InitLop()
        {
            LopBUS lopBUS = new LopBUS();
            lop = lopBUS.getLop();
            var cbl = new List<object>() { new { Id = 0, Ten = "Chọn lớp" } };
            cbLop.DataSource = cbl;
            cbLop.ValueMember = "Id";
            cbLop.DisplayMember = "Ten";
        }
        public void InitKhoi()
        {
            KhoiBUS khoiBUS = new KhoiBUS();
            khoi = khoiBUS.GetTatCaKhoi();
            var cbk = khoi.Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbk.Insert(0, new { Id = 0, Ten = "Chọn khối" });
            cbKhoi.DataSource = cbk;
            cbKhoi.ValueMember = "Id";
            cbKhoi.DisplayMember = "Ten";
        }
        public void InitKhoa()
        {
            NienKhoaBUS khoaHocBUS = new NienKhoaBUS();
            khoaHoc = khoaHocBUS.GetKhoaHoc();
            var cbkh = khoaHoc.Select(x => new { Id = x.IdKhoaHoc, Ten = x.NamHoc.ToString() }).ToList();
            cbKhoaHoc.DataSource = cbkh;
            cbKhoaHoc.ValueMember = "Id";
            cbKhoaHoc.DisplayMember = "Ten";
        }
        public void InitMon()
        {
            MonHocBUS monBus = new MonHocBUS();
            mon = monBus.getMonHoc();
            var cbm = mon.Select(x => new { Id = x.IdMonHoc, Ten = x.TenMonHoc }).ToList();
            cbm.Insert(0, new { Id = 0, Ten = "Chọn môn học" });
            cbMonHoc.DataSource = cbm;
            cbMonHoc.ValueMember = "Id";
            cbMonHoc.DisplayMember = "Ten";
        }
        public void InitHocKi()
        {
            var cbhk = new List<object>()
                {
                    new { Id = 1, Ten = "Học kì 1" },
                    new { Id = 2, Ten = "Học kì 2" },
                };
            cbHocKi.DataSource = cbhk;
            cbHocKi.ValueMember = "Id";
            cbHocKi.DisplayMember = "Ten";
        }
        public List<LoaiKiemTra> InitLoaiKiemTra(ComboBox cbLoaiKiemTra)
        {
            var cblkt = new List<LoaiKiemTra>()
            {
                new LoaiKiemTra(){ Id = 1, Ten = "Điểm miệng" },
                new LoaiKiemTra(){ Id = 2, Ten = "15 phút" },
                new LoaiKiemTra(){ Id = 3, Ten = "1 tiết" },
                new LoaiKiemTra(){ Id = 4, Ten = "Cuối kì" },
            };
            cbLoaiKiemTra.DataSource = cblkt;
            cbLoaiKiemTra.ValueMember = "Id";
            cbLoaiKiemTra.DisplayMember = "Ten";
            return cblkt;
        }
        public void getcbLop(string k, string n, string l)
        {
            var cbl = lop.Where(x => (string.IsNullOrEmpty(k) || x.TenKhoi.Contains(k)) && x.IdKhoaHoc == int.Parse(!string.IsNullOrEmpty(n) ? n : "0")).Select(x => new { Id = x.MaLop, Ten = x.TenLop }).ToList();
            cbl.Insert(0, new { Id = 0, Ten = "Chọn lớp" });
            cbLop.DataSource = cbl;
            cbLop.ValueMember = "Id";
            cbLop.DisplayMember = "Ten";
            cbLop.Text = l;
        }
        public void getcbKhoi(string k, string n, string l)
        {
            var cbk = khoi.Where(x => (string.IsNullOrEmpty(k) || x.TenKhoi.Contains(k))).Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbk.Insert(0, new { Id = 0, Ten = "Chọn khối" });
            cbKhoi.Text = k;
            getcbLop(k, n, l);
        }
        public void getcbKhoaHoc(string k, string n, string l)
        {
            cbKhoaHoc.Text = n;
            getcbKhoi(k, n, l);
        }
    }
    public class LoaiKiemTra
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
}
