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
    public partial class frmTaoBangDiem : Form
    {
        public frmTaoBangDiem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbKhoi.Text = "";
            cbLop.Text = "";
            cbHocKi.Text = "";
            cbMonHoc.Text = "";
            txt15Phut.Text = "";
            txt1Tiet.Text = "";
            txtCuoiKi.Text = "";
        }
    }
}
