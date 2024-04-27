using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using QuanLyNhanVien.BLL;

namespace QuanLyNhanVien.GUI
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();
               
                if( tendangnhap.Length > 0 && matkhau.Length >= 6 && loaiTK.Length > 0)
                {
               
                       if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loaiTK) == true)

                            btnLamMoi.PerformClick();//bấm lại nút làm mới     
                }
                else
                {
                    MessageBox.Show("Mật khẩu không được dưới 6 ký tự ", "thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }

           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

      

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            txbMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbLoaiTaiKhoan.SelectedValue= dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();

        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();
        }



        //    private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        //  {
        //btnLamMoi.PerformClick();//bấm lại nút làm mới
        //      cmbLoaiTaiKhoan.SelectedIndex = 0;
    //}
    }
}
