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
    public partial class frmSuaKhoi : Form
    {
        string txtID = "";
        public frmSuaKhoi(Khoi khoi)
        {
            InitializeComponent();
            txtID = khoi.MaKhoi.ToString();
            txtTenKhoi.Text = khoi.TenKhoi.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maKhoi;
            int solop = 0;
            string tenKhoi;
            maKhoi = Int32.Parse(txtID);
            tenKhoi = txtTenKhoi.Text.Trim();
            Khoi khoi = new Khoi(maKhoi, tenKhoi, solop);
            try
            {
                int i = new KhoiBUS().SuaKhoi(khoi);
                if (i ==1)
                {
                    MessageBox.Show("Đã sữa khối");
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã bị lỗi");
            }
            Close();
        }
    }
}
