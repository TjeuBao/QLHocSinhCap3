﻿using System;
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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QuanLiHocSinh
{
    public partial class frmXuatDanhSachLop : Form
    {
        LopBUS lopBUS = new LopBUS();
        KhoiBUS khoiBUS = new KhoiBUS();
        Lop lop = new Lop();
        NienKhoaBUS nienKhoaBUS;
        BCDSHocSinhBUS bcbus = new BCDSHocSinhBUS();
        public frmXuatDanhSachLop()
        {
            InitializeComponent();
            nienKhoaBUS = new NienKhoaBUS();
        }
        public frmXuatDanhSachLop(Lop l)
        {
            InitializeComponent();
            lop = l;
            var khoi = khoiBUS.GetTatCaKhoi();
            cbKhoi.DataSource = khoi.Select(x => new { Id = x.MaKhoi, Ten = x.TenKhoi }).ToList();
            cbKhoi.DisplayMember = "Ten";
            cbKhoi.ValueMember = "Id";
            cbKhoi.SelectedText = lop.TenKhoi;
            cbLop.Text = lop.TenLop;
            cbKhoaHoc.Text = lop.IdKhoaHoc.ToString();
            cbKhoi.Text = lop.TenKhoi;

            
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            DataSet ds;
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@malop",cbLop.SelectedValue));
            ds = bcbus.TaoDanhSachHocSinh(paras);
            repBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            repBaoCao.LocalReport.ReportPath = "DanhSachHocSinh.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsHocSinhTheoLop";
                rds.Value = ds.Tables[0];
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

        private void frmXuatDanhSachLop_Load(object sender, EventArgs e)
        {
            DataTable dt;
            DataTable dtLop;
            dt = nienKhoaBUS.GetTables("KhoaHoc");
            cbKhoaHoc.DataSource = dt;
            cbKhoaHoc.DisplayMember = "NamHoc";
            cbKhoaHoc.ValueMember = "IdKhoaHoc";
            //cbKhoaHoc.SelectedValue = 5;

            DataTable dtkhoi;

            dtkhoi = nienKhoaBUS.GetTables("Khoi");
            cbKhoi.DataSource = dtkhoi;
            cbKhoi.DisplayMember = "TenKhoi";
            cbKhoi.ValueMember = "MaKhoi";
            cbKhoi.SelectedValue = 1;
            dtLop = LoadClassByGrade("1");
            cbLop.DataSource = dtLop;
            cbLop.ValueMember = "MaLop";
            cbLop.DisplayMember = "TenLop";
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtLop;
            
            if (cbKhoi.SelectedValue.ToString() == "1")
            {
                dtLop = LoadClassByGrade("1");
            }
            else if (cbKhoi.SelectedValue.ToString() == "2")
            {
                dtLop = LoadClassByGrade("2");
            }
            else
            {
                dtLop = LoadClassByGrade("3");
            }
            if (dtLop.Rows.Count > 0)
            {
                cbLop.DataSource = dtLop;
                cbLop.ValueMember = "MaLop";
                cbLop.DisplayMember = "TenLop";
            }
            else
                cbLop.DataSource = new DataTable();
        }

        public DataTable LoadClassByGrade(string makhoi)
        {
            DataTable dtKhoi;
            dtKhoi = nienKhoaBUS.GetClassByYear(cbKhoaHoc.SelectedValue.ToString(), makhoi);
            return dtKhoi;
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtLop;
            //var test = cbKhoi.SelectedValue.ToString();
            cbKhoi.SelectedValue = 1;
            dtLop = LoadClassByGrade("1");
            if (dtLop.Rows.Count > 0)
            {
                cbLop.DataSource = dtLop;
                cbLop.ValueMember = "MaLop";
                cbLop.DisplayMember = "TenLop";
            }
            else
                cbLop.DataSource = new DataTable();
        }
    }
}
