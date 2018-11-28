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
    public partial class frmKhoi : Form
    {
        KhoiBUS khoibus = new KhoiBUS();

        public frmKhoi()
        {
            InitializeComponent();
            dgvKhoi.RowTemplate.Height = 35;
        }

        public List<Khoi> getKhoi()
        {
            try
            {
                var khoi = khoibus.getKhoi();
                var k1 = khoibus.GetTatCaKhoi();
                var k = k1.Select(x => x.MaKhoi).ToList();
                khoi.Select(x => x.MaKhoi).ToList().ForEach(x =>
                {
                    if (k.Contains(x))
                    {
                        k.Remove(x);
                    }
                });
                if (k.Count > 0)
                {
                    k.ForEach(x =>
                    {                       
                        khoi.Add(new Khoi()
                        {
                            MaKhoi = x,
                            TenKhoi = k1.First(i => i.MaKhoi == x).TenKhoi,
                            SoLop = 0,
                            NamHoc = 0
                        });
                    });
                }
                return khoi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemKhoi frm = new frmThemKhoi();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Khoi khoi = new Khoi()
                {
                    MaKhoi = Int32.Parse(txtMaKhoi.Text.ToString()),
                    TenKhoi = txtTenKhoi.Text.ToString(),
                    NamHoc = Int32.Parse(txtKhoaHoc.Text.ToString())
                };
                frmSuaKhoi frm = new frmSuaKhoi(khoi);
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn khối");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int makhoi,solop;
            if(string.IsNullOrEmpty(txtMaKhoi.Text)|| string.IsNullOrEmpty(txtSoLop.Text))
            {
                MessageBox.Show("Chưa chọn khối");
                return;
            }
            makhoi= int.Parse(txtMaKhoi.Text.Trim());
            solop = int.Parse(txtSoLop.Text.Trim());
            if(solop > 0)
            {
                MessageBox.Show("Không xóa được khối này");
                return;
            }
            try
            {
                int i = khoibus.XoaKhoi(makhoi, solop);
                if (i == 1)
                {
                    MessageBox.Show("Đã Xóa");
                    dgvKhoi.DataSource = getKhoi();
                    clear();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã bị lỗi");                
            }
        }
        private void clear()
        {
            dgvKhoi.DataSource = getKhoi();
            txtMaKhoi.Text = "";
            txtSoLop.Text = "";
            txtKhoaHoc.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvKhoi.DataSource = getKhoi();
            clear();
        }

        private void dgvKhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaKhoi.Text = dgvKhoi.Rows[numrow].Cells[0].Value.ToString();
                txtTenKhoi.Text = dgvKhoi.Rows[numrow].Cells[1].Value.ToString();
                txtSoLop.Text = dgvKhoi.Rows[numrow].Cells[2].Value.ToString();
                txtKhoaHoc.Text = dgvKhoi.Rows[numrow].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void frmKhoi_Load(object sender, EventArgs e)
        {
            dgvKhoi.DataSource = getKhoi();            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvKhoi.DataSource = khoibus.getKhoi().Where(x => (string.IsNullOrEmpty(txtTenKhoi.Text) || x.TenKhoi.Contains(txtTenKhoi.Text)) && (string.IsNullOrEmpty(txtKhoaHoc.Text) || x.NamHoc == int.Parse(txtKhoaHoc.Text))).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công");
        }
    }
}
