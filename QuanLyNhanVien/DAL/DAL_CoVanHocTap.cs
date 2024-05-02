using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public  class DAL_CoVanHocTap
    {
        private static DAL_CoVanHocTap instance;

        public static DAL_CoVanHocTap Instance
        {
            get { if (instance == null) instance = new DAL_CoVanHocTap(); return instance; }
            private set => instance = value;
        }
        private DAL_CoVanHocTap() { }
        public bool Them(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string malop)
        {
            string sql = "insert into CoVanHocTap (MaCVHT, TenCVHT, NgaySinh, GioiTinh, Makhoa, MaLop) values( @MaCVHT , @TenCVHT , @NgaySinh ,  @GioiTinh , @Makhoa , @MaLop ) ";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { macovan , tencovan, ngaysinh, gioitinh, makhoa, malop });
        }

        public bool Sua(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string malop, int id)
        {
            string sql = "update CoVanHocTap set MaCVHT = @MaCVHT , TenCVHT = @TenCVHT , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , MaKhoa = @MaKhoa , MaLop = @MaLop where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id });
        }

        public bool Xoa(int id)
        {
            string sql = " delete from CoVanHocTap where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from CoVanHocTap");
        }

    }
}
