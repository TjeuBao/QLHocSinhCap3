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
        List<Lop> lop = new List<Lop>();
        List<Khoi> khoi = new List<Khoi>();
        HocSinhBUS hsbus = new HocSinhBUS();
        public frmHocSinh()
        {
            InitializeComponent();
            drgHocSinh.RowTemplate.Height = 35;
            InitCombobox();
            InitKhoi();
            InitLop();
        }

        private void InitCombobox()
        {
            // combobox Tinh trang
            List<UtilitiesDropdown> tinhTrangs = new List<UtilitiesDropdown>();
            tinhTrangs.Add(new UtilitiesDropdown
            {
                Id = 1,
                Value = "Đang học"
            });

            tinhTrangs.Add(new UtilitiesDropdown
            {
                Id = 0,
                Value = "Thôi học"
            });

            cbTinhTrang.DataSource = tinhTrangs;
            cbTinhTrang.ValueMember = "Id";
            cbTinhTrang.DisplayMember = "Value";
        }

        private void InitLop()
        {
            LopBUS lopBUS = new LopBUS();
            lop = lopBUS.getLop();
            var cbl = lop.Select(x => new { Id = x.MaLop, Ten = x.TenLop }).ToList();
            cbl.Insert(0, new { Id = 0, Ten = "Chọn lớp" });
            cbLop.DataSource = cbl;
            cbLop.ValueMember = "Id";
            cbLop.DisplayMember = "Ten";
        }
        private void InitKhoi()
        {
            KhoiBUS khoiBUS = new KhoiBUS();
            khoi = khoiBUS.GetTatCaKhoi();
            var cbk = khoi.Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbk.Insert(0, new { Id = 0, Ten = "Chọn khối" });
            cbKhoi.DataSource = cbk;
            cbKhoi.ValueMember = "Id";
            cbKhoi.DisplayMember = "Ten";
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
            cbKhoaHoc.SelectedText = "2018";
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
                cbLop.Text = drgHocSinh.Rows[numrow].Cells[10].Value.ToString();
                cbTinhTrang.Text = drgHocSinh.Rows[numrow].Cells[8].Value.ToString();

                //var lophientai = lop.First(x => x.MaLop == int.Parse(drgHocSinh.Rows[numrow].Cells[11].Value.ToString()));
                //cbLop.Text = lophientai.TenLop;
                //getcbKhoi(lophientai.TenKhoi, cbKhoaHoc.SelectedItem.ToString(), "");
                //getcbLop(lophientai.TenKhoi, cbKhoaHoc.SelectedItem.ToString(), lophientai.TenLop);
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
            //cbLop.DataSource = lop.Where(x => x.TenKhoi.Equals(khoi.First(i => i.MaKhoi == int.Parse(cbKhoi.SelectedValue.ToString())).TenKhoi) && x.NamHoc == int.Parse(cbKhoaHoc.Items[cbKhoaHoc.SelectedIndex].ToString())).Select(x => new { Id = x.MaLop, Ten = x.TenLop }).ToList();
            //cbLop.ValueMember = "Id";
            //cbLop.DisplayMember = "Ten";
            getcbKhoaHoc("", cbKhoaHoc.SelectedItem.ToString(), "");
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbKhoi.DataSource = lop.Where(x => x.TenKhoi.Equals(cbKhoi.SelectedText) && x.NamHoc == int.Parse(cbKhoaHoc.SelectedText.ToString())).Select(x => new { Id = x.MaLop, Ten = x.TenLop }).ToList();
            //cbKhoi.ValueMember = "Id";
            //cbKhoi.DisplayMember = "Ten";
            int cbkv = 0;
            var cbkh = "";
            if (cbKhoaHoc.SelectedItem != null)
            {
                cbkh = cbKhoaHoc.SelectedItem.ToString();
            }
            try
            {
                cbkv = int.Parse(cbKhoi.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
            getcbKhoi(cbkv != 0 ? khoi.First(x => x.MaKhoi == cbkv).TenKhoi : "", cbkh, "");
        }
        private void getcbLop(string k, string n, string l)
        {
            var cbl = lop.Where(x => (string.IsNullOrEmpty(k) || x.TenKhoi.Equals(k)) && x.IdKhoaHoc == int.Parse(!string.IsNullOrEmpty(n) ? n : "0")).Select(x => new { Id = x.MaLop, Ten = x.TenLop }).ToList();
            cbl.Insert(0, new { Id = 0, Ten = "Chọn lớp" });
            cbLop.DataSource = cbl;
            cbLop.ValueMember = "Id";
            cbLop.DisplayMember = "Ten";
            cbLop.Text = !string.IsNullOrEmpty(l) ? l : cbl.First().Ten;
        }
        private void getcbKhoi(string k, string n, string l)
        {
            var cbk = khoi.Where(x => (string.IsNullOrEmpty(k) || x.TenKhoi.Equals(k))).Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbk.Insert(0, new { Id = 0, Ten = "Chọn khối" });
            //cbKhoi.DataSource = cbk;
            //cbKhoi.ValueMember = "Id";
            //cbKhoi.DisplayMember = "Ten";
            cbKhoi.Text = !string.IsNullOrEmpty(k) ? k : cbk.First().Ten;
            getcbLop(k, n, l);
        }
        private void getcbKhoaHoc(string k, string n, string l)
        {
            //cbKhoaHoc.Text = n;
            getcbKhoi(k, n, l);
            //getcbLop(k, n, l);
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
