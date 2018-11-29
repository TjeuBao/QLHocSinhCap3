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
    public partial class frmThemLop : Form
    {
        Init init;
        KhoiBUS khoiBUS = new KhoiBUS();
        LopBUS lopBUS = new LopBUS();
        public frmThemLop()
        {
            InitializeComponent();
            init = new Init(cbKhoaHoc, cbKhoi, null, null, null, null);
            init.InitKhoa();
            init.InitKhoi();
            init.lop = lopBUS.getLop();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                var tenLop = txtTenLop.Text;
                var idKhoaHoc = init.khoaHoc[cbKhoaHoc.SelectedIndex].NamHoc;
                var maKhoi = Convert.ToInt32(cbKhoi.SelectedValue);
                if (init.lop.Where(x => x.TenLop.Contains(tenLop) && x.TenKhoi.Contains(init.khoi.First(i=>i.MaKhoi==maKhoi).TenKhoi) && x.IdKhoaHoc == idKhoaHoc).Count() > 0)
                {
                    MessageBox.Show("Đã có lớp này");
                    return;
                }
                Lop lop = new Lop()
                {
                    TenLop = tenLop,
                    IdKhoaHoc = idKhoaHoc,
                    MaKhoi = maKhoi,                    
                    SiSo = 0
                };
                MessageBox.Show(lopBUS.ThemLop(lop));
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
        }
    }
}
