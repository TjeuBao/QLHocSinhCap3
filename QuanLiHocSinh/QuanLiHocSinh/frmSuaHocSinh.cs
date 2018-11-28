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
    public partial class frmSuaHocSinh : Form
    {
        List<Lop> lop = new List<Lop>();
        List<Khoi> khoi = new List<Khoi>();
        
        public frmSuaHocSinh(HocSinh hs)
        {
            InitializeComponent();
            InitCombobox();
            InitKhoi();
            InitLop();

            txtMaHS.Text = hs.MaHS.ToString();
            txtHoTen.Text = hs.HoTen.ToString();
            cbGT.Text = hs.GioiTinh.ToString();
            txtNS.Value = hs.NgaySinh;
            txtDiaChi.Text = hs.DiaChi.ToString();
            txtSDT.Text = hs.SDT;
            txtEmail.Text = hs.Email.ToString();            
            cbTinhTrang.Text = hs.TinhTrang ? "Đang học" : "Thôi học";
            var lophientai = lop.First(x => x.MaLop == hs.LopHienTai);
            cbLop.SelectedValue = lophientai.TenLop;

            getcbKhoi(lophientai.TenKhoi, cbKhoaHoc.SelectedItem.ToString(), "");
            getcbLop(lophientai.TenKhoi, cbKhoaHoc.SelectedItem.ToString(), lophientai.TenLop);
        }
        private void InitCombobox()
        {
            // Tinh trang
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maHS;
            string maSoHS;
            DateTime ngaySinh;
            string hoTen, gioiTinh, diaChi, sdt, email, tenLop;
            bool tinhTrang; int lopHienTai;
            maHS = Int32.Parse(txtID.Text.ToString());
            maSoHS = txtMaHS.Text.Trim();
            hoTen = txtHoTen.Text.Trim();
            gioiTinh = cbGT.Text.Trim();
            sdt = txtSDT.Text.Trim();
            ngaySinh = txtNS.Value;
            diaChi = txtDiaChi.Text.Trim();
            email = txtEmail.Text.Trim();
            tinhTrang = int.Parse(cbTinhTrang.SelectedValue.ToString()) != (int)TinhTrang.DangHoc;
            lopHienTai = int.Parse(cbLop.SelectedValue.ToString().Trim());
            tenLop = cbLop.SelectedValue.ToString();
            HocSinh hs = new HocSinh(maHS, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email, tinhTrang, lopHienTai, tenLop);
            try
            {
                int i = new HocSinhBUS().SuaHocSinh(hs);
                if (i >= 1)
                {
                    MessageBox.Show("Sửa thành công");
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã bị lỗi");
                return;
            }

        }

        private void frmSuaHocSinh_Load(object sender, EventArgs e)
        {
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcbKhoaHoc("", cbKhoaHoc.SelectedItem.ToString(), "");
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

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
