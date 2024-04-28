using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.BLL;
using QuanLyNhanVien.GUI;

namespace QuanLyNhanVien
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }





        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text;
            string matkhau = txbMatKhau.Text;

            if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau) == true)
            {
                txbMatKhau.Clear();
                fSinhVien f = new fSinhVien();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("ten dang nhap hoac mat khau khong dung...", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
