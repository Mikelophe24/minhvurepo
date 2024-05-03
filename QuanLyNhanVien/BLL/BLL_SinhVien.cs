using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DAL;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.BLL
{
    public class BLL_SinhVien
    {
        private static BLL_SinhVien instance;

        public static BLL_SinhVien Instance
        {
            get { if (instance == null) instance = new BLL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private BLL_SinhVien() { }

        public DataTable DanhSach()
        {
            var data = DAL_SinhVien.Instance.DanhSach();
            return data;
        }


        public bool Them(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string TenCVHT)
        {
            return DAL_SinhVien.Instance.Them(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, TenCVHT);
        }

        public bool Sua(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT, int id)
        {
            return DAL_SinhVien.Instance.Sua(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop,  MaKhoa, MaCVHT, id);
        }
        public bool Xoa(int id)
        {
            return DAL_SinhVien.Instance.Xoa(id);
        }
        //public 
            
        //    GetDetailStudent(int id)
        //{
        //    return DAL_SinhVien.Instance.GetDetailStudent( id);
        //}
    }
}
