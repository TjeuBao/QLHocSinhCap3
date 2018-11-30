using DTO;
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
    }
}
