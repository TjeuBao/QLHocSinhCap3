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
    public partial class frmLop : Form
    {
        string txtKhoi = "";
        public frmLop()
        {
            InitializeComponent();
            dgrLopHoc.RowTemplate.Height = 35;
        }

        public List<Lop> getLop()
        {
            try
            {
                LopBUS lop = new LopBUS();
                HocSinhBUS hsBus = new HocSinhBUS();
                var lops = lop.getLop();
                var hss = hsBus.getStudents();

                lops.ForEach(x =>
                {
                    x.hs = hss.Where(d => d.LopHienTai == x.MaLop).ToList();
                });

                return lop.getLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemLop frm = new frmThemLop();

            frm.ShowDialog();
            if (frm.IsDisposed)
            {
                dgrLopHoc.DataSource = getLop();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Lop lop = new Lop()
                {
                    MaLop = int.Parse(txtMaLop.Text.ToString()),
                    TenLop = txtTenLop.Text,
                    IdKhoaHoc = int.Parse(txtKhoaHoc.Text.ToString()),
                    TenKhoi = txtKhoi,
                };
                frmSuaLop frm = new frmSuaLop(lop);
                dgrLopHoc.DataSource = getLop();
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn lớp");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int malop;
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Chưa chọn lớp");
                return;
            }
            malop = int.Parse(txtMaLop.Text.Trim());
            try
            {
                int i = new LopBUS().XoaLop(malop);
                if (i == 1)
                {
                    MessageBox.Show("Đã xóa lớp");
                    clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã bị lỗi");
                return;
            }
        }
        private void clear()
        {
            dgrLopHoc.DataSource = getLop();
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoaHoc.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            clear();
            this.dgrLopHoc.Columns["MaKhoi"].Visible = false;
        }

        private void dgrLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaLop.Text = dgrLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLop.Text = dgrLopHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtKhoaHoc.Text = dgrLopHoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtKhoi = dgrLopHoc.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgrLopHoc.DataSource = getLop().Where(x => (string.IsNullOrEmpty(txtTenLop.Text) || x.TenLop.Contains(txtTenLop.Text)) && (string.IsNullOrEmpty(txtKhoaHoc.Text) || x.IdKhoaHoc == int.Parse(txtKhoaHoc.Text))).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công");
        }
    }
}
