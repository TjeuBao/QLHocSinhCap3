using BUS;
using DTO;
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
        Init init;
        List<DiemMonHoc> diem = new List<DiemMonHoc>();
        DiemBUS diemBUS = new DiemBUS();
        public frmTaoBangDiem()
        {
            InitializeComponent();
            init = new Init(cbKhoaHoc, cbKhoi, cbLop,null,cbMonHoc,cbHocKi);
            init.InitKhoa();
            init.InitKhoi();
            init.InitLop();
            init.InitMon();
            init.InitHocKi();
            cbKhoaHoc.Text = DateTime.Now.Year.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            init = new Init(cbKhoaHoc, cbKhoi, cbLop, null, cbMonHoc, cbHocKi);
            init.InitKhoa();
            init.InitKhoi();
            init.InitLop();
            init.InitMon();
            init.InitHocKi();
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

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
            var khoahoc = cbKhoaHoc.SelectedValue;
            var lop = cbLop.SelectedValue;
            var mon = cbMonHoc.SelectedValue;
            var hocki = cbHocKi.SelectedValue;

            diem = diemBUS.GetDiemMonHoc(int.Parse(lop.ToString()), int.Parse(mon.ToString()), int.Parse(hocki.ToString()));
            var diemmonhoclop = diem.GroupBy(x => x.MaHS).Select(x => new
            {
                MaHS = x.First().MaHS,
                TenHS = x.First().TenHS,
                DiemMieng = string.Join(",", x.Where(i => i.LoaiKiemTra == 1).Select(i => i.Diem).ToList()),
                Tiet = string.Join(",", x.Where(i => i.LoaiKiemTra == 3).Select(i => i.Diem).ToList()),
                CuoiKi = string.Join(",", x.Where(i => i.LoaiKiemTra == 4).Select(i => i.Diem).ToList()),
                Phut = string.Join(",", x.Where(i => i.LoaiKiemTra == 2).Select(i => i.Diem).ToList()),
                DTB = x.First().DTB.ToString()
            }).ToList();
            drgNhapDiem.DataSource = diemmonhoclop;
        }
        private void drgNhapDiem_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            var mahs = drgNhapDiem.Rows[numrow].Cells[0].Value.ToString();
            var listDiem = diem.Where(x => x.MaHS == int.Parse(mahs)).ToList();
            frmDiem frmDiem = new frmDiem(listDiem);
            frmDiem.ShowDialog();
            
        }

        private void drgNhapDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            var mahs = drgNhapDiem.Rows[numrow].Cells[0].Value.ToString();
            var listDiem = diem.Where(x => x.MaHS == int.Parse(mahs)).ToList();
            frmDiem frmDiem = new frmDiem(listDiem);
            frmDiem.ShowDialog();
        }

        private void frmTaoBangDiem_Load(object sender, EventArgs e)
        {
            cbHocKi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonHoc.SelectedIndex = 0;
            cbLop.SelectedValue = 0;
            cbKhoi.SelectedValue = 0;
            cbHocKi.SelectedValue = 1;
        }
    }
}
