namespace QuanLiHocSinh
{
    partial class frmQLHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Khối 10");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khối 11");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Khối 12");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Danh Sách Lớp", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHocSinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNS = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tvDanhSachLop = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcSinhToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.họcSinhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDanhSáchLớpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNameUser = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 609);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtNS);
            this.panel3.Controls.Add(this.cbLop);
            this.panel3.Controls.Add(this.cbKhoi);
            this.panel3.Controls.Add(this.cbGT);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.txtHoTen);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtMaHS);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(189, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 574);
            this.panel3.TabIndex = 1;
            // 
            // txtNS
            // 
            this.txtNS.Enabled = false;
            this.txtNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNS.Location = new System.Drawing.Point(366, 26);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(121, 22);
            this.txtNS.TabIndex = 3;
            this.txtNS.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbLop
            // 
            this.cbLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLop.Enabled = false;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(626, 124);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 8;
            // 
            // cbKhoi
            // 
            this.cbKhoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKhoi.Enabled = false;
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbKhoi.Location = new System.Drawing.Point(367, 124);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 21);
            this.cbKhoi.TabIndex = 5;
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // cbGT
            // 
            this.cbGT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGT.Enabled = false;
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(116, 124);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(121, 21);
            this.cbGT.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Enabled = false;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(626, 76);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(120, 22);
            this.txtSDT.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(626, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(558, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lớp :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SĐT :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khối :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(556, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Email :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới Tính :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(368, 76);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(120, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(116, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(120, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(291, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Địa Chỉ :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Họ Tên :";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHS.Enabled = false;
            this.txtMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS.Location = new System.Drawing.Point(116, 28);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(120, 22);
            this.txtMaHS.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ngày Sinh :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column13});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 187);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(793, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(793, 385);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHS";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoTen";
            this.Column3.HeaderText = "Họ Tên";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GioiTinh";
            this.Column5.HeaderText = "Giới Tính";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgaySinh";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "DiaChi";
            this.Column7.HeaderText = "Địa Chỉ";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SDT";
            this.Column9.HeaderText = "SĐT";
            this.Column9.Name = "Column9";
            this.Column9.Width = 85;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Email";
            this.Column10.HeaderText = "Email";
            this.Column10.Name = "Column10";
            this.Column10.Width = 85;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TinhTrangText";
            this.Column12.HeaderText = "Tình Trạng";
            this.Column12.Name = "Column12";
            this.Column12.Width = 80;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "TenLop";
            this.Column13.HeaderText = "Lớp Học";
            this.Column13.Name = "Column13";
            this.Column13.Width = 60;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã HS :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbKhoaHoc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tvDanhSachLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 574);
            this.panel2.TabIndex = 1;
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(34, 86);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(113, 24);
            this.cbKhoaHoc.TabIndex = 40;
            this.cbKhoaHoc.Text = "2018";
            this.cbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbKhoaHoc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Khóa Học";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sơ Đồ Lớp Học";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvDanhSachLop
            // 
            this.tvDanhSachLop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tvDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvDanhSachLop.Location = new System.Drawing.Point(-1, 128);
            this.tvDanhSachLop.Name = "tvDanhSachLop";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Khối 10";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Khối 11";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Khối 12";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Danh Sách Lớp";
            this.tvDanhSachLop.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvDanhSachLop.Size = new System.Drawing.Size(186, 444);
            this.tvDanhSachLop.TabIndex = 0;
            this.tvDanhSachLop.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDanhSachLop_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtNameUser,
            this.thôngTinToolStripMenuItem,
            this.côngCụToolStripMenuItem,
            this.thôngTinToolStripMenuItem1,
            this.timKiếmToolStripMenuItem,
            this.làmMớToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Size = new System.Drawing.Size(984, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.AutoSize = false;
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họcSinhToolStripMenuItem2,
            this.họcSinhToolStripMenuItem1,
            this.lớpHọcToolStripMenuItem,
            this.mônHọcToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Image = global::QuanLiHocSinh.Properties.Resources.education;
            this.thôngTinToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.thôngTinToolStripMenuItem.Text = "Quản Lí";
            // 
            // họcSinhToolStripMenuItem2
            // 
            this.họcSinhToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.họcSinhToolStripMenuItem2.Name = "họcSinhToolStripMenuItem2";
            this.họcSinhToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.họcSinhToolStripMenuItem2.Text = "Học Sinh";
            this.họcSinhToolStripMenuItem2.Click += new System.EventHandler(this.họcSinhToolStripMenuItem2_Click);
            // 
            // họcSinhToolStripMenuItem1
            // 
            this.họcSinhToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.họcSinhToolStripMenuItem1.Name = "họcSinhToolStripMenuItem1";
            this.họcSinhToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.họcSinhToolStripMenuItem1.Text = "Lớp Học";
            this.họcSinhToolStripMenuItem1.Click += new System.EventHandler(this.họcSinhToolStripMenuItem1_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lớpHọcToolStripMenuItem.Text = "Khối";
            this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mônHọcToolStripMenuItem.Text = "Môn Học";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpBảngĐiểmToolStripMenuItem,
            this.lậpBáoCáoToolStripMenuItem,
            this.inDanhSáchLớpToolStripMenuItem1,
            this.xếpLoạiToolStripMenuItem});
            this.côngCụToolStripMenuItem.Image = global::QuanLiHocSinh.Properties.Resources.layers;
            this.côngCụToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.côngCụToolStripMenuItem.Text = "Công Cụ";
            // 
            // nhậpBảngĐiểmToolStripMenuItem
            // 
            this.nhậpBảngĐiểmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpBảngĐiểmToolStripMenuItem.Name = "nhậpBảngĐiểmToolStripMenuItem";
            this.nhậpBảngĐiểmToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nhậpBảngĐiểmToolStripMenuItem.Text = "Nhập Bảng Điểm";
            this.nhậpBảngĐiểmToolStripMenuItem.Click += new System.EventHandler(this.nhậpBảngĐiểmToolStripMenuItem_Click);
            // 
            // lậpBáoCáoToolStripMenuItem
            // 
            this.lậpBáoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lậpBáoCáoToolStripMenuItem.Name = "lậpBáoCáoToolStripMenuItem";
            this.lậpBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.lậpBáoCáoToolStripMenuItem.Text = "In Bảng Điểm";
            this.lậpBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.lậpBáoCáoToolStripMenuItem_Click);
            // 
            // inDanhSáchLớpToolStripMenuItem1
            // 
            this.inDanhSáchLớpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDanhSáchLớpToolStripMenuItem1.Name = "inDanhSáchLớpToolStripMenuItem1";
            this.inDanhSáchLớpToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.inDanhSáchLớpToolStripMenuItem1.Text = "In Danh Sách Lớp";
            this.inDanhSáchLớpToolStripMenuItem1.Click += new System.EventHandler(this.inDanhSáchLớpToolStripMenuItem1_Click);
            // 
            // xếpLoạiToolStripMenuItem
            // 
            this.xếpLoạiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xếpLoạiToolStripMenuItem.Name = "xếpLoạiToolStripMenuItem";
            this.xếpLoạiToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.xếpLoạiToolStripMenuItem.Text = "Xếp Loại";
            this.xếpLoạiToolStripMenuItem.Click += new System.EventHandler(this.xếpLoạiToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem1
            // 
            this.thôngTinToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quyĐịnhToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.thôngTinToolStripMenuItem1.Image = global::QuanLiHocSinh.Properties.Resources.info;
            this.thôngTinToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
            this.thôngTinToolStripMenuItem1.Size = new System.Drawing.Size(107, 25);
            this.thôngTinToolStripMenuItem1.Text = "Thông Tin";
            // 
            // quyĐịnhToolStripMenuItem
            // 
            this.quyĐịnhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyĐịnhToolStripMenuItem.Name = "quyĐịnhToolStripMenuItem";
            this.quyĐịnhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quyĐịnhToolStripMenuItem.Text = "Quy Định";
            this.quyĐịnhToolStripMenuItem.Click += new System.EventHandler(this.quyĐịnhToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // timKiếmToolStripMenuItem
            // 
            this.timKiếmToolStripMenuItem.Image = global::QuanLiHocSinh.Properties.Resources.sear;
            this.timKiếmToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.timKiếmToolStripMenuItem.Name = "timKiếmToolStripMenuItem";
            this.timKiếmToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.timKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            this.timKiếmToolStripMenuItem.Click += new System.EventHandler(this.timKiếmToolStripMenuItem_Click);
            // 
            // làmMớToolStripMenuItem
            // 
            this.làmMớToolStripMenuItem.Image = global::QuanLiHocSinh.Properties.Resources.reset;
            this.làmMớToolStripMenuItem.Name = "làmMớToolStripMenuItem";
            this.làmMớToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.làmMớToolStripMenuItem.Text = "Làm Mới";
            this.làmMớToolStripMenuItem.Click += new System.EventHandler(this.làmMớToolStripMenuItem_Click);
            // 
            // txtNameUser
            // 
            this.txtNameUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.txtNameUser.Image = global::QuanLiHocSinh.Properties.Resources.graduate;
            this.txtNameUser.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNameUser.Size = new System.Drawing.Size(84, 25);
            this.txtNameUser.Text = "Admin";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmQLHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 609);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Học Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLHocSinh_FormClosing);
            this.Load += new System.EventHandler(this.frmQLHocSinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem côngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtNameUser;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpBáoCáoToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvDanhSachLop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcSinhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quyĐịnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcSinhToolStripMenuItem2;
        private System.Windows.Forms.DateTimePicker txtNS;
        private System.Windows.Forms.ToolStripMenuItem timKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem inDanhSáchLớpToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpLoạiToolStripMenuItem;
    }
}