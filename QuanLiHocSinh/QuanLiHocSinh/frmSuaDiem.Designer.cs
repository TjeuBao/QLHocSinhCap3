namespace QuanLiHocSinh
{
    partial class frmSuaDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiKiemTra = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại kiểm tra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbLoaiKiemTra
            // 
            this.cbLoaiKiemTra.FormattingEnabled = true;
            this.cbLoaiKiemTra.Location = new System.Drawing.Point(146, 28);
            this.cbLoaiKiemTra.Name = "cbLoaiKiemTra";
            this.cbLoaiKiemTra.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiKiemTra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(146, 77);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(93, 20);
            this.txtDiem.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(108, 132);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa điểm";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frmSuaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 212);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoaiKiemTra);
            this.Controls.Add(this.label1);
            this.Name = "frmSuaDiem";
            this.Text = "Sửa Điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiKiemTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnSua;
    }
}