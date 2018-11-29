using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    public partial class frmDiem : Form
    {

        List<DiemMonHoc> diem = new List<DiemMonHoc>();
        List<Lop> lop = new List<Lop>();
        List<Khoi> khoi = new List<Khoi>();
        List<MonHoc> mon = new List<MonHoc>();
        public frmDiem()
        {
            InitializeComponent();
        }
        public frmDiem(List<DiemMonHoc> listDiem)
        {
            InitLoaiKiemTra();
            LopBUS lopBUS = new LopBUS();
            lop = lopBUS.getLop();
            MonHocBUS monBus = new MonHocBUS();
            mon = monBus.getMonHoc();
            diem = listDiem;
            InitializeComponent();
            var d = diem.First();
            txtHS.Text = d.TenHS;
            txtLop.Text = lop.First(x => x.MaLop == d.MaLop).TenLop;
            txtMon.Text = mon.First(x => x.MaMonHoc == d.MaMonHoc.ToString()).TenMonHoc;
        }
        private void InitLoaiKiemTra()
        {
            var cblkt = new List<object>()
            {
                new { Id = 1, Ten = "Điểm miệng" },
                new { Id = 2, Ten = "15 phút" },
                new { Id = 3, Ten = "1 tiết" },
                new { Id = 4, Ten = "Cuối kì" },
            };
            cbLoaiKiemTra.DataSource = cblkt;
            cbLoaiKiemTra.ValueMember = "Id";
            cbLoaiKiemTra.DisplayMember = "Ten";
        }
        private void frmDiem_Load(object sender, EventArgs e)
        {
            dgrDiem.DataSource = diem.Select(x => new { TenHS = x.TenHS, LoaiKiemTra = x.LoaiKiemTra, Diem = x.Diem }).ToList();
        }

        private void dgrDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            cbLoaiKiemTra.Text = dgrDiem.Rows[numrow].Cells[0].Value.ToString();
            txtDiem.Text = dgrDiem.Rows[numrow].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Diem d = new Diem()
            {
                LoaiKiemTra = int.Parse(cbLoaiKiemTra.SelectedValue.ToString()),
                DiemMon = txtDiem.Text,
                MaDiemMon = diem.First().MaDiemMon
            };
        }
    }
}
