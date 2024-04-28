using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DAL;

namespace QuanLyNhanVien.BLL
{
    public  class BLL__Lop
    {
        private static BLL__Lop instance;

        public static BLL__Lop Instance
        {
            get { if (instance == null) instance = new BLL__Lop(); return instance; }
            private set => instance = value;
        }
        private BLL__Lop() { }

        public DataTable DanhSach()
        {
            return DAL__Lop.Instance.DanhSach();
        }

        public bool Them(string malop, string tenlop , string soluong , string makhoa)
        {
            return DAL__Lop.Instance.Them(malop, tenlop , soluong , makhoa);
        }

        public bool Sua(string malop, string tenlop, string soluong, string makhoa, int id)
        {
            return DAL__Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id);
        }
        public bool Xoa(int id)
        {
            return DAL__Lop.Instance.Xoa(id);
        }
    }
}
