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
    public partial class frmXuatBangDiem : Form
    {
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
        }
    }
}
