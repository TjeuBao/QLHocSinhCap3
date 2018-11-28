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
using System.Data.SqlClient;

namespace QuanLiHocSinh
{
    public partial class frmMonHoc : Form
    {
        MonHocBUS mhbus = new MonHocBUS();
        public frmMonHoc()
        {
            InitializeComponent();
            dgrMonHoc.RowTemplate.Height = 35;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemMonHoc frm = new frmThemMonHoc();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MonHoc mh = new MonHoc()
                {
                    IdMonHoc = int.Parse(txtID.Text.ToString()),
                    MaMonHoc = txtMaMH.Text.ToString(),
                    TenMonHoc = txtTenMH.Text.ToString()
                };
                frmSuaMonHoc frm = new frmSuaMonHoc(mh);
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn môn học");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idmonhoc;
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Chưa chọn môn học");
                return;
            }
            idmonhoc = int.Parse(txtID.Text.Trim());
            try
            {
                int i = new MonHocBUS().XoaMonHoc(idmonhoc);
                if (i == -2)
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Xóa thành công");
            dgrMonHoc.DataSource = mhbus.getMonHoc();
            clear();
        }
        private void clear()
        {
            dgrMonHoc.DataSource = mhbus.getMonHoc();
            txtID.Text = "";
            txtMaMH.Text = "";
            txtTenMH.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgrMonHoc.DataSource = mhbus.getMonHoc();
            clear();
        }

        private void dgrMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtID.Text = dgrMonHoc.Rows[numrow].Cells[0].Value.ToString();
                txtMaMH.Text = dgrMonHoc.Rows[numrow].Cells[1].Value.ToString();
                txtTenMH.Text = dgrMonHoc.Rows[numrow].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dgrMonHoc.DataSource = mhbus.getMonHoc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgrMonHoc.DataSource = mhbus.getMonHoc().Where(x => (string.IsNullOrEmpty(txtMaMH.Text) || x.MaMonHoc.Contains(txtMaMH.Text))
                && (string.IsNullOrEmpty(txtTenMH.Text) || x.TenMonHoc.Contains(txtTenMH.Text))).ToList();
        }
    }
}
