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
    public partial class frmLogin : Form
    {
        LoginBUS loginBUS;

        public frmLogin()
        {
            InitializeComponent();
            loginBUS = new LoginBUS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            bool b = false;

            try
            {
                Account acc = new Account(user, pass);
                b = loginBUS.Login(acc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (b)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (user == "" && pass == "")
                {
                    MessageBox.Show("Chưa nhập thông tin", "Đăng nhập lại !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Nhập sai thông tin tài khoản hoặc mật khẩu !", "Đăng nhập lại",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtUsername.Focus();
                    }
                }
            }
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.userName = txtUsername.Text;
                Properties.Settings.Default.passUser = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            if (Properties.Settings.Default.userName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.userName;
                txtPassword.Text = Properties.Settings.Default.passUser;
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
