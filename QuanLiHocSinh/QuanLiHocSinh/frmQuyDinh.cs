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


namespace QuanLiHocSinh
{
    public partial class frmQuyDinh : Form
    {
        QuyDinhBUS qdbus = new QuyDinhBUS();
        public frmQuyDinh()
        {
            InitializeComponent();
            dgrQuyDinh.RowTemplate.Height = 35;
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            dgrQuyDinh.DataSource = qdbus.getQuyDinh();
        }

        private void dgrQuyDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtID.Text = dgrQuyDinh.Rows[numrow].Cells[0].Value.ToString();
                txtMaQD.Text = dgrQuyDinh.Rows[numrow].Cells[1].Value.ToString();
                txtNoiDung.Text = dgrQuyDinh.Rows[numrow].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Chưa chọn quy định");
                return;
            }
            string maquydinh, noidung;
            id = Int32.Parse(txtID.Text.Trim());
            maquydinh = txtMaQD.Text.Trim();
            noidung = txtNoiDung.Text.Trim();
            QuyDinh qd = new QuyDinh(id, maquydinh, noidung);
            try
            {
                int i = new QuyDinhBUS().ThayDoiQuyDinh(qd);
                if (i == -2)
                {
                    MessageBox.Show("Chưa chọn thông tin");
                }
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Thay đổi thành công");
            dgrQuyDinh.DataSource = qdbus.getQuyDinh();
        }
    }
}
