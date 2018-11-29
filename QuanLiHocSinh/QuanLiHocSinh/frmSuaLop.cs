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
    public partial class frmSuaLop : Form
    {
        Init init;
        LopBUS lopBUS = new LopBUS();
        KhoiBUS khoiBUS = new KhoiBUS();
        Lop lop = new Lop();
        public frmSuaLop()
        {
            InitializeComponent();
            cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public frmSuaLop(Lop l)
        {
            InitializeComponent();
            lop = l;
            init = new Init(cbKhoaHoc, cbKhoi, null, null, null, null);
            init.InitKhoa();
            init.InitKhoi();
            cbKhoi.Text = lop.TenKhoi;
            txtTenLop.Text = lop.TenLop;
            cbKhoaHoc.Text = lop.IdKhoaHoc.ToString();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                var tenLop = txtTenLop.Text;
                var idKhoaHoc = init.khoaHoc[cbKhoaHoc.SelectedIndex].NamHoc;
                var maKhoi = Convert.ToInt32(cbKhoi.SelectedValue);
                if (init.lop.Where(x => x.TenLop.Contains(tenLop) && x.TenKhoi.Contains(init.khoi.First(i => i.MaKhoi == maKhoi).TenKhoi) && x.IdKhoaHoc == idKhoaHoc).Count() > 0)
                {
                    MessageBox.Show("Đã có lớp này");
                    return;
                }
                if (lopBUS.SuaLop(new Lop()
                {
                    MaLop = lop.MaLop,
                    TenLop = tenLop,
                    IdKhoaHoc = init.khoaHoc[cbKhoaHoc.SelectedIndex].IdKhoaHoc,
                    MaKhoi = maKhoi
                })==1)
                {
                    MessageBox.Show("Đã sửa lớp");
                    Close();
                    return;
                };
                MessageBox.Show("Không sửa được lớp");
            }
            catch (Exception) 
            {
                MessageBox.Show("Đã bị lỗi");
            }
        }
    }
}
