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
using QuanLiHocSinh.UtilitiesClass;

namespace QuanLiHocSinh
{
    public partial class frmHocSinh : Form
    {
        Init init;
        HocSinhBUS hsbus = new HocSinhBUS();
        public frmHocSinh()
        {
            InitializeComponent();
            drgHocSinh.RowTemplate.Height = 35;
            init = new Init(cbKhoaHoc, cbKhoi, cbLop, cbTinhTrang, null, null);
            init.InitCombobox();

            init.InitKhoa();
            init.InitKhoi();
            init.InitLop();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemHocSinh frm = new frmThemHocSinh();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hs = new HocSinh()
                {
                    MaHS = Int32.Parse(txtID.Text.ToString()),
                    HoTen = txtHoTen.Text.ToString(),
                    GioiTinh = cbGT.Text.ToString(),
                    NgaySinh = txtNS.Value,
                    DiaChi = txtDiaChi.Text.ToString(),
                    SDT = txtSDT.Text.ToString(),
                    Email = txtEmail.Text.ToString(),
                    TinhTrang = int.Parse(cbTinhTrang.SelectedValue.ToString()) != (int)TinhTrang.DangHoc,
                    LopHienTai = Int32.Parse(cbLop.SelectedValue.ToString())
                };
                frmSuaHocSinh frm = new frmSuaHocSinh(hs);
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn học sinh");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int mahs;
            if (string.IsNullOrEmpty(txtID.Text) || txtID.Text == "0")
            {
                MessageBox.Show("Chưa chọn học sinh");
                return;
            }
            mahs = int.Parse(txtID.Text.Trim());
            try
            {
                int i = hsbus.XoaHocSinh(mahs);
                if (i == -2)
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception)
            {
                if (mahs == 0)
                {
                    MessageBox.Show("Chưa chọn học sinh");
                    return;
                }
            }
            MessageBox.Show("Xóa thành công");
            drgHocSinh.DataSource = hsbus.getStudents();
        }


        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            drgHocSinh.DataSource = hsbus.getStudents();
            cbGT.SelectedText = "Chọn";
            this.drgHocSinh.Columns["TinhTrang"].Visible = false;
            this.drgHocSinh.Columns["LopHienTai"].Visible = false;

        }

        private void drgHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtID.Text = drgHocSinh.Rows[numrow].Cells[0].Value.ToString();
                txtHoTen.Text = drgHocSinh.Rows[numrow].Cells[1].Value.ToString();
                cbGT.Text = drgHocSinh.Rows[numrow].Cells[2].Value.ToString();
                txtNS.Text = drgHocSinh.Rows[numrow].Cells[3].Value.ToString();
                txtDiaChi.Text = drgHocSinh.Rows[numrow].Cells[4].Value.ToString();
                txtSDT.Text = drgHocSinh.Rows[numrow].Cells[5].Value.ToString();
                txtEmail.Text = drgHocSinh.Rows[numrow].Cells[6].Value.ToString();
                cbTinhTrang.Text = drgHocSinh.Rows[numrow].Cells[8].Value.ToString();

                var lophientai = init.lop.First(x => x.TenLop.Contains(drgHocSinh.Rows[numrow].Cells[10].Value.ToString()));
                init.getcbKhoaHoc(lophientai.TenKhoi, init.khoaHoc.First(x => x.NamHoc == lophientai.IdKhoaHoc).NamHoc.ToString(), lophientai.TenLop);
            }
            catch (Exception)
            {
                return;
            }

        }

        private void clear()
        {
            drgHocSinh.DataSource = hsbus.getStudents();
            txtID.Text = "0";
            txtHoTen.Text = "";
            cbGT.Text = "";
            txtNS.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            cbKhoaHoc.Text = DateTime.Now.Year.ToString();
            cbTinhTrang.Text = "";
            cbLop.SelectedIndex = 0;
            cbKhoi.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            drgHocSinh.DataSource = hsbus.getStudents();
            clear();
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            init.getcbKhoaHoc("", init.khoaHoc[cbKhoaHoc.SelectedIndex].NamHoc.ToString(), "");
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cbkv = 0;
            var cbkh = "";
            cbkh = init.khoaHoc[cbKhoaHoc.SelectedIndex].NamHoc.ToString();
            try
            {
                cbkv = int.Parse(cbKhoi.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
            init.getcbKhoi(cbkv != 0 ? init.khoi.First(x => x.MaKhoi == cbkv).TenKhoi : "", cbkh, "");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmXuatDanhSachLop frm = new frmXuatDanhSachLop();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            drgHocSinh.DataSource = hsbus.getStudents().Where(x => (string.IsNullOrEmpty(txtHoTen.Text) || x.HoTen.Contains(txtHoTen.Text))).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công");
        }
    }
}
