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
        KhoiBUS khoiBUS = new KhoiBUS();
        LopBUS lopBUS = new LopBUS();
        public frmThemLop()
        {
            InitializeComponent();
            //Lấy khối 
            var khoi = khoiBUS.GetTatCaKhoi();
            cbKhoi.DataSource = khoi.Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbKhoi.DisplayMember = "Ten";
            cbKhoi.ValueMember = "Id";

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Lop lop = new Lop()
                {
                    TenLop = txtTenLop.Text,
                    IdKhoaHoc = Convert.ToInt32(cbKhoaHoc.SelectedValue),
                    MaKhoi = Convert.ToInt32(cbKhoi.SelectedValue),                    
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
