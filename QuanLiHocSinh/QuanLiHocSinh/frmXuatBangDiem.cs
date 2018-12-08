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
        DiemBUS diembus = new DiemBUS();
        public frmXuatBangDiem()
        {
            InitializeComponent();
        }

        private void btTaoReport_Click(object sender, EventArgs e)
        {

        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

            this.repBaoCao.RefreshReport();

            try
            {
                var listDTB = diembus.GetDiemHK(6, 1).GroupBy(x => x.MaHS).Select(x => new DiemTrungBinhMon()
                {
                    TenHS = x.First().TenHS,
                    NgaySinh = x.First().NgaySinh,
                    GioiTinh = x.First().GioiTinh,
                    SinhHoc = x.First(i => i.IdMonHoc == 1).DTB.ToString(),
                    HoaHoc = x.First(i => i.IdMonHoc == 2).DTB.ToString(),
                    TiengAnh = x.First(i => i.IdMonHoc == 3).DTB.ToString(),
                    DiaLi = x.First(i => i.IdMonHoc == 4).DTB.ToString(),
                    LichSu = x.First(i => i.IdMonHoc == 5).DTB.ToString(),
                    NguVan = x.First(i => i.IdMonHoc == 6).DTB.ToString(),
                    Toan = x.First(i => i.IdMonHoc == 7).DTB.ToString(),
                    VatLi = x.First(i => i.IdMonHoc == 8).DTB.ToString(),
                    DTB = x.Sum(i => i.DTB) / x.Count(),
                    TenLop = "12A1"//cbLop.SelectedText.ToString()
                }).ToList();
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
    }
}
