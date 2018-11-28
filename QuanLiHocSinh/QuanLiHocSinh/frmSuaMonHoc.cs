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
    public partial class frmSuaMonHoc : Form
    {
        public frmSuaMonHoc(MonHoc mh)
        {
            InitializeComponent();
            txtID.Text = mh.IdMonHoc.ToString();
            txtMaMH.Text = mh.MaMonHoc.ToString();
            txtTenMH.Text = mh.TenMonHoc.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int id;
            string mamonhoc, tenmonhoc;
            id = Int32.Parse(txtID.Text.Trim());
            mamonhoc = txtMaMH.Text.Trim();
            tenmonhoc = txtTenMH.Text.Trim();
            MonHoc mh = new MonHoc(id, mamonhoc, tenmonhoc);
            try
            {
                int i = new MonHocBUS().SuaMonHoc(mh);
                if (i == -2)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Sửa thành công");
            Close();
        }
    }
}
