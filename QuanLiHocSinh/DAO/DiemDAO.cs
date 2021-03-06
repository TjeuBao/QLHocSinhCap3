﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DiemDAO: DataProvider
    {
        public List<DiemMonHoc> GetDiemMonHoc(int maLop, int mamonhoc, int mahocki)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("@malop", maLop));
            param.Add(new SqlParameter("@mamonhoc", mamonhoc));
            param.Add(new SqlParameter("@hocki", mahocki));
            try
            {
                var d = ExecProcedrure("dbo.LayDiemMon", System.Data.CommandType.StoredProcedure, param);
                var list = new List<DiemMonHoc>();
                while (d.Read())
                {
                    var diemmonhoc = new DiemMonHoc();
                    diemmonhoc.MaDiemMon = d.GetInt32(0);
                    diemmonhoc.MaMonHoc = d.GetInt32(1);
                    diemmonhoc.MaHS = d.GetInt32(2);
                    diemmonhoc.MaLop = d.GetInt32(3);
                    diemmonhoc.DTB =  d.GetFloat(4);
                    diemmonhoc.MaHocKi = d.GetString(5);
                    diemmonhoc.LoaiKiemTra = d.GetInt32(6);
                    diemmonhoc.Diem = d.GetFloat(7);
                    diemmonhoc.MaDiem = d.GetInt32(8);
                    diemmonhoc.TenHS = d.GetString(9);
                    list.Add(diemmonhoc);
                }
                DisConnect();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<DiemTrungBinh> GetDiemHK(int maLop, int mahocki)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("@malop", maLop));
            param.Add(new SqlParameter("@hocki", mahocki));
            try
            {
                var d = ExecProcedrure("dbo.LayDiemHocKi", System.Data.CommandType.StoredProcedure, param);
                var list = new List<DiemTrungBinh>();
                while (d.Read())
                {
                    var diemmonhoc = new DiemTrungBinh();
                    diemmonhoc.MaHS = d.GetInt32(0);
                    diemmonhoc.TenHS = d.GetString(1);
                    diemmonhoc.NgaySinh = d.GetDateTime(2);
                    diemmonhoc.GioiTinh = d.GetString(3);
                    diemmonhoc.IdMonHoc = d.GetInt32(4);
                    diemmonhoc.DTB = d.GetFloat(5);
                    list.Add(diemmonhoc);
                }
                DisConnect();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ThemDiem(Diem d)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("@loaikiemtra", d.LoaiKiemTra));
            param.Add(new SqlParameter("@madiemmon",d.MaDiemMon));
            param.Add(new SqlParameter("@diem", d.DiemMon));
            param.Add(new SqlParameter("@id", d.Id));
            try
            {
              return ExecProcedure("dbo.ThemDiem", System.Data.CommandType.StoredProcedure, param);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int SuaDiem(Diem d)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("@madiem", d.MaDiem));
            param.Add(new SqlParameter("@madiemmon", d.MaDiemMon));
            param.Add(new SqlParameter("@diem", d.DiemMon));
            try
            {
                return ExecProcedure("dbo.SuaDiem", System.Data.CommandType.StoredProcedure, param);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int XoaDiem(Diem d)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("@madiem", d.MaDiem));
            param.Add(new SqlParameter("@madiemmon", d.MaDiemMon));
            try
            {
                return ExecProcedure("dbo.XoaDiem", System.Data.CommandType.StoredProcedure, param);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<DiemMonHoc> GetDiem(int madiemmon)
        {
            try
            {
                var d = myExecuteReader("SELECT * FROM Diem WHERE MaDiemMon="+ madiemmon.ToString());
                var list = new List<DiemMonHoc>();
                while (d.Read())
                {
                    var diemmonhoc = new DiemMonHoc();
                    diemmonhoc.MaDiemMon = d.GetInt32(4);
                    diemmonhoc.LoaiKiemTra = d.GetInt32(1);
                    diemmonhoc.Diem = d.GetFloat(2);
                    diemmonhoc.MaDiem = d.GetInt32(0);
                    list.Add(diemmonhoc);
                }
                DisConnect();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
