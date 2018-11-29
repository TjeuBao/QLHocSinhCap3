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
    public partial class frmQLHocSinh : Form
    {
        HocSinhBUS hsbus = new HocSinhBUS();
        List<Lop> lop = new List<Lop>();
        List<Khoi> khoi = new List<Khoi>();
        NienKhoaBUS nienKhoaBUS;
        LopBUS lopBUS;
        public frmQLHocSinh()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 35;
            InitKhoi();
            InitLop();
            nienKhoaBUS = new NienKhoaBUS();
            lopBUS = new LopBUS();
            lop = lopBUS.getLop();
            
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Show();
            frmLogin frm = new frmLogin();
            DialogResult resutl = frm.ShowDialog();
            if (resutl == DialogResult.OK)
            {
                this.Enabled = true;
            }

            cbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            
            DataTable dt;

            dt = nienKhoaBUS.GetTables("KhoaHoc");
            cbKhoaHoc.DataSource = dt;
            cbKhoaHoc.DisplayMember = "NamHoc";
            cbKhoaHoc.ValueMember = "IdKhoaHoc";
            
            // Load lớp theo khối
            LoadClassByGrade();
            cbKhoaHoc.SelectedValue = 5;
        }

        private void frmQLHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmQLHocSinh frm = new frmQLHocSinh();
                frm.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void đăngXuấtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            frmLogin frm = new frmLogin();
            Properties.Settings.Default.Reset();
            DialogResult resutl = frm.ShowDialog();
            if (resutl == DialogResult.OK)
                this.Enabled = true;
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinh Viên Thực Hiện : Triệu Văn Bảo"
                + "\n \t \t      Hồ Chung Bảo"
                + "\n \t \t      Danh Ngọc Quyên"
                + "\n \t \t      Đặng Ngọc Linh"
                , "Trình Quản Lí Thông Tin Học Sinh Cấp 3");
        }

        private void họcSinhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.ShowDialog();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.ShowDialog();
        }

        private void họcSinhToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.ShowDialog();
        }

        private void nhậpBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoBangDiem frm = new frmTaoBangDiem();
            frm.ShowDialog();
        }

        private void lậpBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatBangDiem frm = new frmXuatBangDiem();
            frm.ShowDialog();
        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            frm.ShowDialog();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoi frm = new frmKhoi();
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaHS.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                cbGT.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
                txtNS.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
                cbLop.Text = dataGridView1.Rows[numrow].Cells[10].Value.ToString();

            }
            catch (Exception)
            {
                return;
            }
        }

        private void làmMớToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hsbus.getStudents();
            this.dataGridView1.Columns["TinhTrang"].Visible = false;
            this.dataGridView1.Columns["LopHienTai"].Visible = false;
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            cbGT.Text = "";
            txtNS.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            cbLop.SelectedIndex = 0;
            cbKhoi.SelectedIndex = 0;
        }

        private void hồSơLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hsbus.getStudents();
            this.dataGridView1.Columns["TinhTrang"].Visible = false;
            this.dataGridView1.Columns["LopHienTai"].Visible = false;
        }

        private void inDanhSáchLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmXuatDanhSachLop frm = new frmXuatDanhSachLop();
            frm.ShowDialog();
        }


        private void timKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = hsbus.getStudents().Where(x => (string.IsNullOrEmpty(txtHoTen.Text) || x.HoTen.Contains(txtHoTen.Text))).ToList();
                this.dataGridView1.Columns["TinhTrang"].Visible = false;
                this.dataGridView1.Columns["LopHienTai"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập thông tin");
            }
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

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcbKhoaHoc("", cbKhoaHoc.SelectedItem.ToString(), "");
            removeAllNode();
            string idYear = cbKhoaHoc.SelectedValue.ToString();
            var dtKhoi10 = nienKhoaBUS.GetClassByYear(idYear, "1");
            addRowsToNode(dtKhoi10, 0);
            //Khoi 11
            var dtKhoi11 = nienKhoaBUS.GetClassByYear(idYear, "2");
            addRowsToNode(dtKhoi11, 1);
            //Khoi 12
            var dtKhoi12 = nienKhoaBUS.GetClassByYear(idYear, "3");
            addRowsToNode(dtKhoi12, 2);
            tvDanhSachLop.ExpandAll(); 
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
        private void getcbKhoi(string k, string n, string l)
        {
            var cbk = khoi.Where(x => (string.IsNullOrEmpty(k) || x.TenKhoi.Equals(k))).Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbk.Insert(0, new { Id = 0, Ten = "Chọn khối" });
            cbKhoi.Text = !string.IsNullOrEmpty(k) ? k : cbk.First().Ten;
        }
        private void getcbKhoaHoc(string k, string n, string l)
        {
            getcbKhoi(k, n, l);
        }
        public void LoadClassByGrade()
        {
            /* Xu ly load Khoi Lop theo nien khoa */
            // Khoi 10
            var dtKhoi10 = nienKhoaBUS.GetClassByYear(cbKhoaHoc.SelectedValue.ToString(), "1");
            foreach (DataRow dr in dtKhoi10.Rows)
            {
                tvDanhSachLop.Nodes[0].Nodes[0].Nodes.Add(dr["TenLop"].ToString());

            }
            //Khoi 11
            var dtKhoi11 = nienKhoaBUS.GetClassByYear(cbKhoaHoc.SelectedValue.ToString(), "2");
            foreach (DataRow dr in dtKhoi11.Rows)
            {
                tvDanhSachLop.Nodes[0].Nodes[1].Nodes.Add(dr["TenLop"].ToString());

            }
            //Khoi 12
            var dtKhoi12 = nienKhoaBUS.GetClassByYear(cbKhoaHoc.SelectedValue.ToString(), "3");
            foreach (DataRow dr in dtKhoi12.Rows)
            {
                tvDanhSachLop.Nodes[0].Nodes[2].Nodes.Add(dr["TenLop"].ToString());

            }
            tvDanhSachLop.ExpandAll();
        }

        // Them lop vao theo tung khoi
        public void addRowsToNode(DataTable dt, int khoi)
        {
            foreach (DataRow dr in dt.Rows)
            {
                tvDanhSachLop.Nodes[0].Nodes[khoi].Nodes.Add(dr["TenLop"].ToString());
            }
        }
        // Loai bo cac lop de load lai 
        public void removeAllNode()
        {
            tvDanhSachLop.Nodes[0].Nodes[0].Nodes.Clear();
            tvDanhSachLop.Nodes[0].Nodes[1].Nodes.Clear();
            tvDanhSachLop.Nodes[0].Nodes[2].Nodes.Clear();
        }

        private void tvDanhSachLop_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentNode = e.Node;
            List<HocSinh> listHS = hsbus.getStudents();
            List<Lop> listLop = lopBUS.getLop();
            var nodeKhoi10 = tvDanhSachLop.Nodes[0].Nodes[0];
            var nodeKhoi11 = tvDanhSachLop.Nodes[0].Nodes[1];
            var nodeKhoi12 = tvDanhSachLop.Nodes[0].Nodes[2];
            var parentNode = currentNode.Parent;
            if (parentNode == nodeKhoi10 || parentNode == nodeKhoi11 || parentNode == nodeKhoi12)
            {
                var resultLop = lop.Where(x => x.TenLop == currentNode.Text).ToList();
                List<HocSinh> listResult = new List<HocSinh>();
                foreach (var x in listHS)
                {
                    foreach (var y in resultLop)
                    {
                        if (x.LopHienTai == y.MaLop)
                        {
                            listResult.Add(x);
                        }
                    }

                }
                dataGridView1.DataSource = listResult;
                this.dataGridView1.Columns[9].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;

            }
        }
    }
}
