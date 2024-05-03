using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.DAL
{
    public  class DAL_SinhVien
    {
        private static DAL_SinhVien instance;

        public static DAL_SinhVien Instance
        {
            get { if (instance == null) instance = new DAL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private DAL_SinhVien() { }
        public bool Them(string MaSV, string TenSV, string NgaySinh , string GioiTinh , string QueQuan , string NgayNhapHoc, string MaLop, string MaKHoa, string MaCVHT )
        {
            string sql = "insert into SinhVien ( MaSV , TenSV , NgaySinh , GioiTinh , QueQuan , NgayNhapHoc , MaLop , MaKhoa, MaCVHT ) values ( @MaSV , @TenSV , @NgaySinh , @GioiTinh , @QueQuan , @NgayNhapHoc , @MaLop , @MaKhoa , @MaCVHT ) ";
            bool a = KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKHoa, MaCVHT });
            return a;

        }

        public bool Sua(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT, int id)
        {
            string sql = "update SinhVien set MaSV= @MaSV , TenSV = @TenSV , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , QueQuan = @QueQuan , NgayNhapHoc = @N" +
                "gayNhapHoc , MaLop = @MaLop , MaKhoa = @MaKhoa , MaCVHT = @MaCVHT where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT, id });
        }

        public bool Xoa(int id)
        {
            string sql = " delete from SinhVien where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            //return KetNoi.Instance.ExcuteQuery("select * from SinhVien");
            return KetNoi.Instance.ExcuteQuery(" select * from [ds_QLSV].[dbo].[SinhVien];");
        }

        public DataTable ListStudentJoinedOtherTables()
        {
            var data = KetNoi.Instance.ExcuteQuery("SELECT  sv.Id,\r\n        sv.MaSV,\r\n        sv.TenSV,\r\n        sv.NgaySinh,\r\n        sv.GioiTinh,\r\n        sv.QueQuan,\r\n        sv.NgayNhapHoc,\r\n        l.TenLop,\r\n        k.TenKhoa,\r\n        cv.TenCVHT\r\nFROM ds_QLSV.dbo.SinhVien as sv\r\nLEFT JOIN ds_QLSV.dbo.Lop as l ON l.MaLop = sv.MaLop \r\nLEFT JOIN ds_QLSV.dbo.Khoa as k ON k.Makhoa = sv.MaKhoa\r\nLEFT JOIN ds_QLSV.dbo.CoVanHocTap as cv ON cv.MaCVHT = sv.MaCVHT;");
            return data;
        }

        //internal Student GetDetailStudent(int id)
        //{
        //    return new Student
        //    {
        //        Id = id,
        //        MaSV = "SVTest",
        //        TenSV= "Vu Tri Test"
        //    }
        //}
    }
}
