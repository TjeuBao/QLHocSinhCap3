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
        Init init;
        public frmThemHocSinh()
        {
            InitializeComponent();
            init = new Init(cbKhoaHoc, cbKhoi, cbLop, cbTinhTrang,null,null);
            init.InitCombobox();
            init.InitKhoa();
            init.InitKhoi();
            init.InitLop();
        }
        private void btnThemHS_Click(object sender, EventArgs e)
        {
            int maHS = 1; int lopHienTai;
            DateTime ngaySinh;
            string hoTen, gioiTinh, diaChi, sdt, email, nienKhoa, tenLop;
            bool tinhTrang;
            hoTen = txtHoTen.Text.Trim();
            gioiTinh = cbGT.Text.Trim();
            sdt = txtSDT.Text.Trim();
            ngaySinh = txtNS.Value;
            diaChi = txtDiaChi.Text.Trim();
            //nienKhoa = cbKhoaHoc.SelectedItem.ToString();
            email = txtEmail.Text.Trim();
            tinhTrang = int.Parse(cbTinhTrang.SelectedValue.ToString()) != (int)TinhTrang.DangHoc;
            lopHienTai = int.Parse(cbLop.SelectedValue.ToString());
            tenLop = cbLop.SelectedValue.ToString();
            HocSinh hs = new HocSinh(maHS, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email, tinhTrang, lopHienTai, tenLop);
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
            init.InitCombobox();
            this.cbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbGT.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            init.getcbKhoaHoc("", init.khoaHoc[cbKhoaHoc.SelectedIndex].NamHoc.ToString(), "");
        }
    }
}
