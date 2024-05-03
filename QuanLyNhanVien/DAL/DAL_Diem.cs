using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class DAL_Diem
    {
        private static DAL_Diem instance;

        public static DAL_Diem Instance
        {
            get { if (instance == null) instance = new DAL_Diem(); return instance; }
            private set => instance = value;
        }
        private DAL_Diem() { }
        public bool Them(string MaSV, string MaMH , int PhanTranTrenLop, int PhanTramThi, float DiemLop, float DiemThi, float DiemTB, string Loai )
        {
            string sql = "insert into Diem ( MaSV , MaMH , PhanTranTrenLop , PhanTramThi , DiemTrenLop , DiemThi , DiemTB , Loai ) values( @MaSV , @MaMH , @PhanTramTrenLop , @PhanTramThi , @DiemTrenLop , @DiemThi , @DiemTB , @Loai ) ";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTranTrenLop, PhanTramThi, DiemLop, DiemThi, DiemTB, Loai });
        }

        public bool Sua(string MaSV, string MaMH, int PhanTranTrenLop, int PhanTramThi, float DiemLop, float DiemThi, float DiemTB, string Loai, int id)
        {
            string sql = "update Diem set MaSV = @MaSV , MaMH = @MaMH , PhanTranTrenLop = @PhanTranTrenLop , PhanTramThi = @PhanTramThi , DiemTrenLop = @DiemTrenLop , DiemThi = @DiemThi , DiemTB = @DiemTB , Loai = @Loai  where  id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTranTrenLop, PhanTramThi, DiemLop, DiemThi, DiemTB, Loai, id });
        }

        public bool Xoa(int id)
        {
            string sql = " delete from Diem where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select Id, MaSV, MaMH , PhanTranTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB , Loai from Diem");
        }
    }
}
