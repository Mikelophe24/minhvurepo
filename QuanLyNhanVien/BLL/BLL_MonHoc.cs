using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DAL;

namespace QuanLyNhanVien.BLL
{
    public  class BLL_MonHoc
    {
        private static BLL_MonHoc instance;

        public static BLL_MonHoc Instance
        {
            get { if (instance == null) instance = new BLL_MonHoc(); return instance; }
            private set => instance = value;
        }
        private BLL_MonHoc() { }

        public DataTable DanhSach()
        {
            return DAL_MonHoc.Instance.DanhSach();
        }

        public bool Them(string MaMH, string TenMH, int SoTC, int TietLT, int TietTH)
        {
            return DAL_MonHoc.Instance.Them(MaMH, TenMH, SoTC, TietLT, TietTH);
        }

        public bool Sua(string mamonhoc, string tenmonhoc, int sotinchi, int tietlythuyet, int tietthuchanh, int id)
        {
            return DAL_MonHoc.Instance.Sua(mamonhoc, tenmonhoc, sotinchi, tietlythuyet, tietthuchanh, id);
        }
        public bool Xoa(int id)
        {
            return DAL_MonHoc.Instance.Xoa(id);
        }
    }
}
