using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public  class DAL__Lop
    {
        private static DAL__Lop instance;

        public static DAL__Lop Instance
        {
            get { if (instance == null) instance = new DAL__Lop(); return instance; }
            private set => instance = value;
        }
        private DAL__Lop() { }
        public bool Them(string malop, string tenlop, string soluong, string makhoa)
        {
            string sql = "insert into Lop(Malop,TenLop,SoLuong,MaKhoa) values( @Malop , @TenLop, @SoLuong , @Makhoa ) ";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { makhoa, tenlop, soluong, makhoa });
        }

        public bool Sua(string malop, string tenlop, string soluong, string makhoa, int  id)
        {
            string sql = "update Lop set Malop = @Malop , TenLop = @TenLop, SoLuong = @SoLuong, MaKhoa = @MaKhoa where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { makhoa, tenlop, soluong, makhoa , id});
        }

        public bool Xoa(int id)
        {
            string sql = " delete from Khoa where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from Lop");
        }


    }
}
