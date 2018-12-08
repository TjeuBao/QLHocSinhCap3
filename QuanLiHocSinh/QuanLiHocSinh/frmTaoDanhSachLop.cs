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
    public partial class frmTaoDanhSachLop : Form
    {
        List<Lop> lop = new List<Lop>();
        List<Khoi> khoi = new List<Khoi>();
        HocSinhBUS hsbus = new HocSinhBUS();
        LopBUS lopBUS = new LopBUS();
        public frmTaoDanhSachLop()
        {
            InitializeComponent();
            dgrDanhSachLop.RowTemplate.Height = 35;
            InitKhoi();
            InitLop();
            cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cbKhoi.Text = !string.IsNullOrEmpty(k) ? k : cbk.First().Ten;
            getcbLop(k, n, l);
        }
        private void getcbKhoaHoc(string k, string n, string l)
        {
            getcbKhoi(k, n, l);
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            
            try
            {
                frmXuatDanhSachLop frm = new frmXuatDanhSachLop();
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn lớp");
                return;
            }
        }

        private void frmTaoDanhSachLop_Load(object sender, EventArgs e)
        {
            cbKhoaHoc.SelectedText = "2018";
            this.cbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgrDanhSachLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgrDanhSachLop.DataSource = lopBUS.getLop().Where(x => (string.IsNullOrEmpty(cbLop.Text) || x.TenLop.Contains(cbLop.Text)) && (string.IsNullOrEmpty(cbKhoaHoc.Text) || x.IdKhoaHoc == int.Parse(cbKhoaHoc.Text))).ToList();
                this.dgrDanhSachLop.Columns["TinhTrang"].Visible = false;
                this.dgrDanhSachLop.Columns["LopHienTai"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn lớp");
            }
        }
    }
}
