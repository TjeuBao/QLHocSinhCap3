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
        Init init;
        List<DiemMonHoc> diem = new List<DiemMonHoc>();
        public frmDiem()
        {
            InitializeComponent();
        }
        public frmDiem(List<DiemMonHoc> listDiem)
        {
            init = new Init(null, null, null, null, null, null);
            LopBUS lopBUS = new LopBUS();
            init.lop = lopBUS.getLop();
            MonHocBUS monBus = new MonHocBUS();
            init.mon = monBus.getMonHoc();
            diem = listDiem;
            InitializeComponent();
            var kt= init.InitLoaiKiemTra(cbLoaiKiemTra);
            var d = diem.First();
            txtHS.Text = d.TenHS;
            txtLop.Text = init.lop.First(x => x.MaLop == d.MaLop).TenLop;
            txtMon.Text = init.mon.First(x => x.IdMonHoc==d.MaMonHoc).TenMonHoc;
            dgrDiem.DataSource = listDiem.Select(x=>new { LoaiKiemTra = kt.First(i=>i.Id== x.LoaiKiemTra).Ten, Diem = x.Diem }).ToList();
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

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            var loaikiemtra = cbLoaiKiemTra.SelectedValue;
        }
    }
}
