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
using QuanLiHocSinh.UtilitiesClass;

namespace QuanLiHocSinh
{
    public partial class frmThemHocSinh : Form
    {
        List<Lop> lop = new List<Lop>();
        List<Khoi> khoi = new List<Khoi>();
        public frmThemHocSinh()
        {
            InitializeComponent();
            InitCombobox();
            InitKhoi();
            InitLop();
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
        private void btnThemHS_Click(object sender, EventArgs e)
        {
            int maHS = 1; int lopHienTai;
            DateTime ngaySinh;
            string hoTen, gioiTinh, diaChi, sdt, email, nienKhoa,tenLop;
            bool tinhTrang;
            hoTen = txtHoTen.Text.Trim();
            gioiTinh = cbGT.Text.Trim();
            sdt = txtSDT.Text.Trim();
            ngaySinh = txtNS.Value;
            diaChi = txtDiaChi.Text.Trim();
            nienKhoa = cbKhoaHoc.SelectedItem.ToString();
            email = txtEmail.Text.Trim();
            tinhTrang = int.Parse(cbTinhTrang.SelectedValue.ToString()) != (int)TinhTrang.DangHoc;
            lopHienTai = int.Parse(cbLop.SelectedValue.ToString());
            tenLop = cbLop.SelectedValue.ToString();
            HocSinh hs = new HocSinh(maHS, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email,tinhTrang, lopHienTai, tenLop);
            try
            {
                int i = new HocSinhBUS().ThemHocSinh(hs);
                if (i > -1)
                {
                    MessageBox.Show("Thêm thành công");
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai thông tin");
                return;
            }
            
        }

        private void frmThemHocSinh_Load(object sender, EventArgs e)
        {
            InitCombobox();
            this.cbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbGT.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void InitCombobox()
        {
            // Tinh trang
            List<UtilitiesDropdown> tinhTrangs = new List<UtilitiesDropdown>();
            tinhTrangs.Add(new UtilitiesDropdown
            {
                Id = 1,
                Value = "Còn học"
            });

            tinhTrangs.Add(new UtilitiesDropdown
            {
                Id = 0,
                Value = "Thôi học"
            });

            cbTinhTrang.DataSource = tinhTrangs;
            cbTinhTrang.ValueMember = "Id";
            cbTinhTrang.DisplayMember = "Value";

            List<UtilitiesDropdown> gioiTinh = new List<UtilitiesDropdown>();
            gioiTinh.Add(new UtilitiesDropdown
            {
                Id = 1,
                Value = "Nam"
            });

            gioiTinh.Add(new UtilitiesDropdown
            {
                Id = 0,
                Value = "Nữ"
            });

            cbGT.DataSource = gioiTinh;
            cbGT.ValueMember = "Id";
            cbGT.DisplayMember = "Value";
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcbKhoaHoc("", cbKhoaHoc.SelectedItem.ToString(), "");
        }

        private void getcbLop(string k, string n, string l)
        {
            var cbl = lop.Where(x => (string.IsNullOrEmpty(k) || x.TenKhoi.Equals(k)) && x.IdKhoaHoc == int.Parse(n)).Select(x => new { Id = x.MaLop, Ten = x.TenLop }).ToList();
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
    }
}
