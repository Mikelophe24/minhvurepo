using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class DAL_TaiKhoan
    {

        private static DAL_TaiKhoan instance;

        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set => instance = value;
        }
        private DAL_TaiKhoan() { }
        public bool Them(string ten , string matkhau, string loai)
        {
            string sql = "insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan) values( @TenDangNhap , @MatKhau , @LoaiTaiKhoan )";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai });
        }

        public bool Sua(string ten, string matkhau, string loai, int id)
        {
            string sql = "update TaiKhoan set TenDangNhap= @TenDangNhap , MatKhau = @MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan where id= @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai, id });
        }

        public bool Xoa(int id)
        {
            string sql = " delete from TaiKhoan where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from TaiKhoan");
        }
    }
}
