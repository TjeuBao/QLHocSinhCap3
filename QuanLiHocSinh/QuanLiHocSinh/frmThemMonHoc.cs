using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLiHocSinh
{
    public partial class frmThemMonHoc : Form
    {
        public frmThemMonHoc()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int id;
            string mamonhoc, tenmonhoc;
            id = 1;
            mamonhoc = txtMaMH.Text.Trim();
            tenmonhoc = txtTenMH.Text.Trim();
            if (string.IsNullOrEmpty(txtMaMH.Text) || string.IsNullOrEmpty(txtTenMH.Text))
            {
                MessageBox.Show("Nhập sai thông tin");
                return;
            }
            MonHoc mh = new MonHoc(id, mamonhoc, tenmonhoc);
            try
            {
                int i = new MonHocBUS().ThemMonHoc(mh);
                if (i > -1)
                {
                    MessageBox.Show("Thêm thành công");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
