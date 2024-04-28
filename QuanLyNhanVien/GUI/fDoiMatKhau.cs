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

namespace QuanLyNhanVien.GUI
{
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string matkhau_cu = txbMatKhauCu.Text;
            string matkhua_moi = txbMatKhauMoi.Text;

            if(matkhau_cu.Length == 0 && matkhua_moi.Length==0)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (BLL_TaiKhoan.Instance.DoiMatKhau(HeThong.TENDANGNHAP, matkhua_moi, matkhau_cu) == true)
                    MessageBox.Show("Đổi mật khẩu thành công  ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đổi mật khẩu thât bại! ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
