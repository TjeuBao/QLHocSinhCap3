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
        DiemBUS diemBUS = new DiemBUS();
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
            dgrDiem.DataSource = listDiem.Select(x=>new { MaDiem = x.MaDiem, LoaiKiemTra = kt.First(i=>i.Id== x.LoaiKiemTra).Ten, Diem = x.Diem }).ToList();
        }
        private void frmDiem_Load(object sender, EventArgs e)
        {
            //dgrDiem.DataSource = diem.Select(x => new {MaDiem= x.MaDiem, TenHS = x.TenHS, LoaiKiemTra = x.LoaiKiemTra, Diem = x.Diem }).ToList();
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
            var i = getId(int.Parse(cbLoaiKiemTra.SelectedValue.ToString()));
            if (i < 0)
            {
                return;
            }
            Diem d = new Diem()
            {
                LoaiKiemTra = int.Parse(cbLoaiKiemTra.SelectedValue.ToString()),
                DiemMon = Convert.ToSingle(txtDiem.Text),
                MaDiemMon = diem.First().MaDiemMon,
                Id = i
            };
            diemBUS.ThemDiem(d);
        }
        private int getId(int loaikiemtra)
        {
            if(loaikiemtra==1|| loaikiemtra == 2)
            {
                return 1;
            }
            else if (loaikiemtra == 3)
            {
                return 2;
            }
            else if (loaikiemtra ==4)
            {
                return 3;
            }
            return -1;
        }

        private void dgrDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            var madiem = int.Parse(dgrDiem.Rows[numrow].Cells[0].Value.ToString());
            var d= diem.First(x => x.MaDiem == madiem);
            if (d != null)
            {
                txtD.Text = d.Diem.ToString();
                var kt = init.InitLoaiKiemTra(cbLKT);
                cbLKT.Text = kt.First(x => x.Id == d.LoaiKiemTra).Ten;
            }
        }
    }
}
