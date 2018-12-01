﻿using BUS;
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
        DiemMonHoc d = new DiemMonHoc();
        List<LoaiKiemTra> kt = new List<LoaiKiemTra>();
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
             kt= init.InitLoaiKiemTra(cbLoaiKiemTra);
            var d = diem.First();
            txtHS.Text = d.TenHS;
            txtLop.Text = init.lop.First(x => x.MaLop == d.MaLop).TenLop;
            txtMon.Text = init.mon.First(x => x.IdMonHoc==d.MaMonHoc).TenMonHoc;
            dgrDiem.DataSource = diem.Select(x=>new { MaDiem = x.MaDiem, LoaiKiemTra = kt.First(i=>i.Id== x.LoaiKiemTra).Ten, Diem = x.Diem }).ToList();
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
            try
            {
            var idLoaiKiemTra = getId(int.Parse(cbLoaiKiemTra.SelectedValue.ToString()));
            if (idLoaiKiemTra < 0)
            {
                return;
            }
            Diem d = new Diem()
            {
                LoaiKiemTra = int.Parse(cbLoaiKiemTra.SelectedValue.ToString()),
                DiemMon = Convert.ToSingle(txtDiem.Text),
                MaDiemMon = diem.First().MaDiemMon,
                Id = idLoaiKiemTra
            };
            if(diemBUS.ThemDiem(d)>0)
            {
                MessageBox.Show("Đã thêm được điểm");
                diem.Add(new DiemMonHoc()
                {
                    Diem = d.DiemMon,
                    LoaiKiemTra = d.LoaiKiemTra
                });
                dgrDiem.DataSource = diem.Select(x => new{ MaDiem = x.MaDiem, LoaiKiemTra = kt.First(i => i.Id == x.LoaiKiemTra).Ten, Diem = x.Diem }).ToList();
                return;
            };
            MessageBox.Show("Chưa thêm điểm");
            }
            catch (Exception)
            {
                MessageBox.Show("Đã bị lỗi");
            }
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
            d= diem.First(x => x.MaDiem == madiem);
            if (d != null)
            {
                txtD.Text = d.Diem.ToString();
                var kt = init.InitLoaiKiemTra(cbLKT);
                cbLKT.Text = kt.First(x => x.Id == d.LoaiKiemTra).Ten;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (diemBUS.SuaDiem(new Diem()
                {
                    MaDiem = d.MaDiem,
                    MaDiemMon = d.MaDiemMon,
                    DiemMon = Convert.ToSingle(txtD.Text.ToString()),
                }) > 0)
                {
                    MessageBox.Show("Đã sửa điểm");
                    diem.ForEach(x => {
                    if (x.MaDiem == d.MaDiem)
                    {
                        x.Diem = Convert.ToSingle(txtD.Text.ToString());
                    }});
                    dgrDiem.DataSource = diem.Select(x => new { MaDiem = x.MaDiem, LoaiKiemTra = kt.First(i => i.Id == x.LoaiKiemTra).Ten, Diem = x.Diem }).ToList();
                    return;
                };
                MessageBox.Show("Chưa sửa điểm");
            }
            catch (Exception)
            {
                MessageBox.Show("Đã bị lỗi");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (diemBUS.XoaDiem(new Diem()
                {
                    MaDiem = d.MaDiem,
                    MaDiemMon = d.MaDiemMon,
                }) > 0)
                {
                    MessageBox.Show("Đã xóa điểm");
                    diem.Remove(d);
                    dgrDiem.DataSource = diem.Select(x => new { MaDiem = x.MaDiem, LoaiKiemTra = kt.First(i => i.Id == x.LoaiKiemTra).Ten, Diem = x.Diem }).ToList();
                    return;
                };
                MessageBox.Show("Chưa xóa điểm");
            }
            catch (Exception)
            {
                MessageBox.Show("Đã bị lỗi");
                return;
            }
        }
    }
}
