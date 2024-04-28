﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DAL;

namespace QuanLyNhanVien.BLL
{
    public class BLL_TaiKhoan
    {

        private static BLL_TaiKhoan instance;

        public static BLL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new BLL_TaiKhoan(); return instance; }
            private set => instance = value;
        }
        private BLL_TaiKhoan() { }

        public DataTable DanhSach()
        {
            return DAL_TaiKhoan.Instance.DanhSach();
        }

        public bool Them(string ten, string matkhau, string loai)
        {
            matkhau = HeThong.Hash(matkhau);
            return DAL_TaiKhoan.Instance.Them(ten, matkhau, loai);
        }

        public bool SuaHet(string ten, string matkhau, string loai, int id)
        {
            matkhau = HeThong.Hash(matkhau);
            return DAL_TaiKhoan.Instance.Sua_Het(ten, matkhau, loai, id);
        }

        public bool KhongSuaMatKhau(string ten, string loai, int id)
        {
            return DAL_TaiKhoan.Instance.Khong_Sua_Mat_Khau(ten, loai, id);
        }

        public bool Xoa( int id)
        {
            return DAL_TaiKhoan.Instance.Xoa(id);
        }

        public bool DangNhap(string ten, string matkhau)
        {
            matkhau = HeThong.Hash(matkhau);

            DataTable dulieu = DAL_TaiKhoan.Instance.DangNhap(ten, matkhau);

            if (dulieu.Rows.Count > 0)
            {
                HeThong.TENDANGNHAP = ten;
                HeThong.LOAITAIKHOAN = dulieu.Rows[0]["LoaiTaiKhoan"].ToString().Trim();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DoiMatKhau(string tendangnhap, string matkhaumoi, string matkhaucu)
        {
            matkhaucu = HeThong.Hash(matkhaucu);
            matkhaumoi = HeThong.Hash(matkhaumoi);
            return DAL_TaiKhoan.Instance.DoiMatKhau(tendangnhap, matkhaumoi, matkhaucu);
        }

    }
}
