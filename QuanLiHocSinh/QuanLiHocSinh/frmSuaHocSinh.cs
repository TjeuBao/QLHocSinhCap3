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
        Init init;
        public frmSuaHocSinh(HocSinh hs)
        {
            InitializeComponent();
            init = new Init(cbKhoaHoc, cbKhoi, cbLop, cbTinhTrang,null,null);
            init.InitCombobox();
            init.InitKhoa();
            init.InitKhoi();
            init.InitLop();
            txtID.Text = hs.MaHS.ToString();
            txtHoTen.Text = hs.HoTen.ToString();
            cbGT.Text = hs.GioiTinh.ToString();
            txtNS.Value = hs.NgaySinh;
            txtSDT.Text = hs.SDT;
            txtEmail.Text = hs.Email.ToString();
            txtDiaChi.Text = hs.DiaChi.ToString();
            cbTinhTrang.Text = hs.TinhTrang ? "Đang học" : "Thôi học";
            var lophientai = init.lop.First(x => x.MaLop == hs.LopHienTai);
            cbKhoaHoc.Text = init.khoaHoc.First(x => x.NamHoc == lophientai.IdKhoaHoc).NamHoc.ToString();
            init.getcbKhoi(lophientai.TenKhoi, cbKhoaHoc.Text, lophientai.TenLop);
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
        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            init.getcbKhoaHoc("", init.khoaHoc[int.Parse(cbKhoaHoc.SelectedIndex.ToString())].NamHoc.ToString(), "");
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cbkv = 0;
            var cbkh = "";
            if (cbKhoaHoc.SelectedItem != null)
            {
                cbkh = init.khoaHoc[int.Parse(cbKhoaHoc.SelectedIndex.ToString())].NamHoc.ToString();
            }
            try
            {
                cbkv = int.Parse(cbKhoi.SelectedValue.ToString());
            }
            catch (Exception)
            {
            }
            init.getcbKhoi(cbkv != 0 ? init.khoi.First(x => x.MaKhoi == cbkv).TenKhoi : "", cbkh, "");
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
