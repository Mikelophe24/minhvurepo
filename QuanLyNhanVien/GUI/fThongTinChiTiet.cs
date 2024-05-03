using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien.GUI
{
    public partial class fThongTinChiTiet : Form
    {
        public fThongTinChiTiet()
        {
            InitializeComponent();
        }

        private void fThongTinChiTiet_Load(object sender, EventArgs e)
        {
            txbDangNhap.Text = HeThong.TENDANGNHAP;
            txbMatKhau.Text = HeThong.MATKHAU;
            txbLoaiTaiKhoan.Text = HeThong.LOAITAIKHOAN;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
