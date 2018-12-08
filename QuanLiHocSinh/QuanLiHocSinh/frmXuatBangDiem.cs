using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLiHocSinh
{
    public partial class frmXuatBangDiem : Form
    {
        Init init;
        DiemBUS diembus = new DiemBUS();
        public frmXuatBangDiem()
        {
            InitializeComponent();
            init = new Init(cbKhoaHoc, cbKhoi, cbLop, null, null, cbHocKi);
            init.InitKhoa();
            init.InitKhoi();
            init.InitLop();
            init.InitHocKi();
            cbKhoaHoc.Text = DateTime.Now.Year.ToString();
        }

        private void btTaoReport_Click(object sender, EventArgs e)
        {
            this.repBaoCao.RefreshReport();

            try
            {
                var listDTB = diembus.GetDiemHK(int.Parse(cbLop.SelectedValue.ToString()), int.Parse(cbHocKi.SelectedValue.ToString())).GroupBy(x => x.MaHS).Select(x => new DiemTrungBinhMon()
                {
                    TenHS = x.First().TenHS,
                    NgaySinh = x.First().NgaySinh,
                    GioiTinh = x.First().GioiTinh,
                    SinhHoc = (x.Where(i => i.IdMonHoc == 1).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 1).Count()).ToString(),
                    HoaHoc = (x.Where(i => i.IdMonHoc == 2).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 2).Count()).ToString(),
                    TiengAnh = (x.Where(i => i.IdMonHoc == 3).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 3).Count()).ToString(),
                    DiaLi = (x.Where(i => i.IdMonHoc == 4).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 4).Count()).ToString(),
                    LichSu = (x.Where(i => i.IdMonHoc == 5).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 5).Count()).ToString(),
                    NguVan = (x.Where(i => i.IdMonHoc == 6).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 6).Count()).ToString(),
                    Toan = (x.Where(i => i.IdMonHoc == 7).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 7).Count()).ToString(),
                    VatLi = (x.Where(i => i.IdMonHoc == 8).Sum(j => j.DTB) / x.Where(i => i.IdMonHoc == 8).Count()).ToString(),
                    DTB = x.Sum(i => i.DTB) / x.Count(),
                    TenLop = "12A1"//cbLop.SelectedText.ToString()
                }).ToList();
                //diembus.GetDiemHK(int.Parse(cbLop.SelectedValue.ToString()), int.Parse(cbHocKi.SelectedValue.ToString())).GroupBy(x => x.MaHS).Select(x => new
                //{
                //    TenHS = x.First().TenHS,
                //    NgaySinh = x.First().NgaySinh,
                //    DTB = x.Sum(i => i.DTB) / x.Count(),
                //    XepHang= (x.Sum(i => i.DTB) / x.Count())>=8? "Giỏi": (x.Sum(i => i.DTB) / x.Count())>=6.5|| (x.Sum(i => i.DTB) / x.Count())<8? "Khá" : (x.Sum(i => i.DTB) / x.Count()) >= 5 || (x.Sum(i => i.DTB) / x.Count()) < 6.5 ? "Trung Bình": "Yếu",
                //    TenLop = "12A1"//cbLop.SelectedText.ToString()
                //}).ToList();
                DataTable dt = ConvertToDataTable(listDTB);
                repBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                repBaoCao.LocalReport.ReportPath = "DiemTongKet.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1TongDiem";
                rds.Value = dt;
                if (dt.Rows.Count > 0)
                {
                    repBaoCao.LocalReport.DataSources.Clear();
                    repBaoCao.LocalReport.DataSources.Add(rds);
                    repBaoCao.RefreshReport();
                }
                else
                {
                    repBaoCao.LocalReport.DataSources.Clear();
                    repBaoCao.RefreshReport();
                    MessageBox.Show("Không có học sinh");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn lớp");
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
        }
        public DataTable ConvertToDataTable(List<DiemTrungBinhMon> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(DiemTrungBinhMon));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (object item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

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

        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
