using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class HocSinhDAO : DataProvider
    {
        DataProvider dp;
        List<Lop> lop = new List<Lop>();
        public HocSinhDAO()
        {
            dp = new DataProvider();
        }

        public List<HocSinh> getStudents()
        {
            string sql = "SELECT hs.MaHS,hs.HoTen,hs.GioiTinh,hs.NgaySinh,hs.DiaChi,hs.SDT,hs.Email,hs.TinhTrang,hs.MaLop, l.TenLop from HocSinh hs, Lop l where hs.MaLop = l.MaLop";
            int maHS, maLop;
            DateTime ngaySinh;
            string hoTen, gioiTinh, diaChi, sdt, email, tenLop;
            bool tinhTrang;
            List<HocSinh> list = new List<HocSinh>();
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.myExecuteReader(sql);
                while (dr.Read())
                {
                    maHS = dr.GetInt32(0);
                    hoTen = dr.GetString(1);
                    gioiTinh = dr.GetString(2);
                    ngaySinh = dr.GetDateTime(3);
                    diaChi = dr.GetString(4);
                    sdt = dr.GetString(5);
                    email = dr.GetString(6);
                    tinhTrang = (bool)dr[7];
                    maLop = dr.GetInt32(8);
                    tenLop = dr.GetString(9);
                    HocSinh hs = new HocSinh(maHS, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email, tinhTrang, maLop, tenLop);

                    list.Add(hs);
                    list.ForEach(x =>
                    {
                        x.TinhTrangText = x.TinhTrang ? "Đang học" : "Thôi học";
                    });
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }

        public HocSinh getStudent(int id)
        {
            string sql = "SELECT * from HocSinh where MaSoHS = " + "'" + id + "'";
            int maHS, maLop;
            DateTime ngaySinh;
            string hoTen, gioiTinh, diaChi, sdt, email, tenLop;
            bool tinhTrang;
            HocSinh hocsinh = new HocSinh();
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.myExecuteReader(sql);
                while (dr.Read())
                {
                    maHS = dr.GetInt32(0);
                    hoTen = dr.GetString(1);
                    gioiTinh = dr.GetString(2);
                    ngaySinh = dr.GetDateTime(3);
                    diaChi = dr.GetString(4);
                    sdt = dr.GetString(5);
                    email = dr.GetString(6);
                    tinhTrang = (bool)dr[7];
                    maLop = dr.GetInt32(8);
                    tenLop = dr.GetString(9);
                    HocSinh hs = new HocSinh(maHS, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email, tinhTrang, maLop, tenLop);
                }
                dr.Close();
                return hocsinh;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }

        public List<HocSinh> getStudentsByLop(int malop)
        {
            string sql = "SELECT * from HocSinh where MaLop = " + malop;
            int maHS, maLop;
            DateTime ngaySinh;
            string hoTen, gioiTinh, diaChi, sdt, email, tenLop;
            bool tinhTrang;
            List<HocSinh> list = new List<HocSinh>();
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.myExecuteReader(sql);
                while (dr.Read())
                {
                    maHS = dr.GetInt32(0);
                    hoTen = dr.GetString(1);
                    gioiTinh = dr.GetString(2);
                    ngaySinh = dr.GetDateTime(3);
                    diaChi = dr.GetString(4);
                    sdt = dr.GetString(5);
                    email = dr.GetString(6);
                    tinhTrang = (bool)dr[7];
                    maLop = dr.GetInt32(8);
                    tenLop = dr.GetString(9);
                    HocSinh hs = new HocSinh(maHS, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email, tinhTrang, maLop, tenLop);
                    list.Add(hs);
                    list.ForEach(x =>
                    {
                        x.TinhTrangText = x.TinhTrang ? "Đang học" : "Thôi học";
                    });
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }

        public int ThemHocSinh(HocSinh hs)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@hoten", hs.HoTen));
            list.Add(new SqlParameter("@gioitinh", hs.GioiTinh));
            list.Add(new SqlParameter("@ngaysinh", hs.NgaySinh));
            list.Add(new SqlParameter("@diachi", hs.DiaChi));
            list.Add(new SqlParameter("@sdt", hs.SDT));
            list.Add(new SqlParameter("@email", hs.Email));
            list.Add(new SqlParameter("@tinhtrang", hs.TinhTrang));
            list.Add(new SqlParameter("@lophientai", hs.LopHienTai));
            return ExecProcedure("ThemHocSinh", System.Data.CommandType.StoredProcedure, list);
        }

        public int SuaHocSinh(HocSinh hs)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@mahs", hs.MaHS));
            list.Add(new SqlParameter("@hoten", hs.HoTen));
            list.Add(new SqlParameter("@gioitinh", hs.GioiTinh));
            list.Add(new SqlParameter("@ngaysinh", hs.NgaySinh));
            list.Add(new SqlParameter("@diachi", hs.DiaChi));
            list.Add(new SqlParameter("@sdt", hs.SDT));
            list.Add(new SqlParameter("@email", hs.Email));
            list.Add(new SqlParameter("@tinhtrang", hs.TinhTrang));
            list.Add(new SqlParameter("@lophientai", hs.LopHienTai));
            return ExecProcedure("SuaHocSinh", System.Data.CommandType.StoredProcedure, list);
        }

        public int XoaHocSinh(int mahs)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@mahs", mahs));
            return ExecProcedure("XoaHocSinh", System.Data.CommandType.StoredProcedure, list);
        }
    }
}
