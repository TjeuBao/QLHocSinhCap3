using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLiHocSinh
{
    public partial class frmXepLoaiHocSinh : Form
    {
        Init init;
        DiemBUS diembus;
        public frmXepLoaiHocSinh()
        {
            InitializeComponent();
            init = new Init(cbKhoaHoc, cbKhoi, cbLop, null, null, cbHocKi);
            init.InitKhoa();
            init.InitKhoi();
            init.InitLop();
            init.InitHocKi();
            cbKhoaHoc.Text = DateTime.Now.Year.ToString();
            diembus = new DiemBUS();
            cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHocKi.DropDownStyle = ComboBoxStyle.DropDownList;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            var listdiem = diembus.GetDiemHK(int.Parse(cbLop.SelectedValue.ToString()),
                int.Parse(cbHocKi.SelectedValue.ToString())).GroupBy(x => x.MaHS).Select(x => 
            new
            {
                TenHS = x.First().TenHS,
                NgaySinh = x.First().NgaySinh,
                DTB = Math.Round(x.Sum(i => i.DTB) / x.Count(),2),
                XepLoai = (x.Sum(i => i.DTB) / x.Count()) >= 8 ? "Giỏi" : (x.Sum(i => i.DTB) / x.Count()) >= 6.5 && (x.Sum(i => i.DTB) / x.Count()) < 8 ? "Khá" : (x.Sum(i => i.DTB) / x.Count()) >= 5 && (x.Sum(i => i.DTB) / x.Count()) < 6.5 ? "Trung Bình" : "Yếu",
            }).OrderByDescending(x => x.DTB).ToList();         

            drgXepLoaiHS.DataSource = listdiem;
            for (int i = 0; i < listdiem.Count; i++)
            {
                drgXepLoaiHS.Rows[i].Cells[0].Value = (i + 1);
            }
        }
    }
}
