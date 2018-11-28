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
    public partial class frmThemKhoi : Form
    {
        public frmThemKhoi()
        {
            InitializeComponent();
            this.txtSoLop.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txtTenKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int makhoi, solop;
            string tenkhoi; 
            makhoi = 0;
            if (string.IsNullOrEmpty(txtSoLop.Text) || string.IsNullOrEmpty(txtTenKhoi.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            solop = Int32.Parse(txtSoLop.Text.Trim());
            tenkhoi = txtTenKhoi.Text.Trim();
            Khoi khoi = new Khoi(makhoi, tenkhoi, solop);
            try
            {
                int i = new KhoiBUS().ThemKhoi(khoi);
                if (i == -2)
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Thêm thành công");
            Close();
        }
    }
}
