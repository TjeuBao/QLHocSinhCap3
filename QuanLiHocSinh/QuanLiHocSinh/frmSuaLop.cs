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
            var khoi = khoiBUS.GetTatCaKhoi();
            cbKhoi.DataSource = khoi.Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbKhoi.DisplayMember = "Ten";
            cbKhoi.ValueMember = "Id";
            cbKhoi.SelectedText = lop.TenKhoi;
            txtTenLop.Text = lop.TenLop;
            cbKhoaHoc.Text = lop.IdKhoaHoc.ToString();
            cbKhoi.Text = lop.TenKhoi;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (lopBUS.SuaLop(new Lop()
                {
                    MaLop = lop.MaLop,
                    TenLop = txtTenLop.Text,
                    IdKhoaHoc = int.Parse(cbKhoaHoc.Text),
                    MaKhoi = int.Parse(cbKhoi.SelectedValue.ToString())
                })==1)
                {
                    MessageBox.Show("Đã sửa lớp");
                    Close();
                };
                MessageBox.Show("Không sửa được lớp");
                return;
            }
            catch (Exception) 
            {
                MessageBox.Show("Đã bị lỗi");
            }
        }
    }
}
