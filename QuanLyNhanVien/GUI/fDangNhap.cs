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
            string tendangnhap = txbTenDangNhap1.Text;
            string matkhau = txbMatKhau1.Text;

            if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau) == true)
            {
                txbMatKhau1.Clear();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txbTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    // Chuyển focus tới TextBox mật khẩu
            //    txbMatKhau1.Focus();
            //}
        }

        private void Enter(object sender, KeyEventArgs e)
        {

        }

        private void txbTenDangNhap1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
