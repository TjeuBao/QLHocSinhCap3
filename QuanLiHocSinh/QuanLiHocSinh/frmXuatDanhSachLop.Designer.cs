namespace QuanLiHocSinh
{
    partial class frmXuatDanhSachLop
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DanhSachHocSinhTheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HocSinhCap3DataSet1 = new QuanLiHocSinh.HocSinhCap3DataSet1();
            this.repBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhSachHocSinhTheoLopTableAdapter = new QuanLiHocSinh.HocSinhCap3DataSet1TableAdapters.DanhSachHocSinhTheoLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachHocSinhTheoLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhCap3DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DanhSachHocSinhTheoLopBindingSource
            // 
            this.DanhSachHocSinhTheoLopBindingSource.DataMember = "DanhSachHocSinhTheoLop";
            this.DanhSachHocSinhTheoLopBindingSource.DataSource = this.HocSinhCap3DataSet1;
            // 
            // HocSinhCap3DataSet1
            // 
            this.HocSinhCap3DataSet1.DataSetName = "HocSinhCap3DataSet1";
            this.HocSinhCap3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repBaoCao
            // 
            this.repBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHocSinhTheoLop";
            reportDataSource1.Value = this.DanhSachHocSinhTheoLopBindingSource;
            this.repBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.repBaoCao.LocalReport.ReportEmbeddedResource = "QuanLiHocSinh.DanhSachHocSinh.rdlc";
            this.repBaoCao.Location = new System.Drawing.Point(0, 0);
            this.repBaoCao.Name = "repBaoCao";
            this.repBaoCao.Size = new System.Drawing.Size(984, 590);
            this.repBaoCao.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cbKhoaHoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbKhoi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btReport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 681);
            this.panel1.TabIndex = 1;
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(160, 34);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(121, 24);
            this.cbKhoaHoc.TabIndex = 14;
            this.cbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbKhoaHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Khóa Học :";
            // 
            // cbKhoi
            // 
            this.cbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbKhoi.Location = new System.Drawing.Point(384, 34);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 24);
            this.cbKhoi.TabIndex = 12;
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chọn Khối :";
            // 
            // btReport
            // 
            this.btReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.Location = new System.Drawing.Point(763, 30);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(133, 30);
            this.btReport.TabIndex = 2;
            this.btReport.Text = "In Danh Sách Lớp";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.repBaoCao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 590);
            this.panel2.TabIndex = 10;
            // 
            // cbLop
            // 
            this.cbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(606, 34);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 24);
            this.cbLop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Lớp :";
            // 
            // DanhSachHocSinhTheoLopTableAdapter
            // 
            this.DanhSachHocSinhTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // frmXuatDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 720);
            this.Name = "frmXuatDanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "In Danh Sách  Lớp";
            this.Load += new System.EventHandler(this.frmXuatDanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachHocSinhTheoLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhCap3DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repBaoCao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource DanhSachHocSinhTheoLopBindingSource;
        private HocSinhCap3DataSet1 HocSinhCap3DataSet1;
        private HocSinhCap3DataSet1TableAdapters.DanhSachHocSinhTheoLopTableAdapter DanhSachHocSinhTheoLopTableAdapter;
    }
}