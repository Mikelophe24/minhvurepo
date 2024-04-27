using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            fSinhVien f = new fSinhVien();
            this.Hide();
            f.ShowDialog();
            this.Show();


        }
    }
}
