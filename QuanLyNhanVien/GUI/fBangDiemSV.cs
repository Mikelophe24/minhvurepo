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
    public partial class fBangDiemSV : Form
    {
        public fBangDiemSV()
        {
            InitializeComponent();
        }

        private void fBangDiemSV_Load(object sender, EventArgs e)
        {
            
        }

        private void txtDiemThi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiemThi.Text))
            {
                if (int.TryParse(txtDiemLop.Text, out int score))
                {
                    if (score > 10)
                    {
                        MessageBox.Show("Điểm trên lớp phải nhỏ hơn 10, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDiemThi.Text = ""; // Clear the textbox if the input is invalid
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiemThi.Text = ""; // Clear the textbox if the input is not a valid integer
                }
            }
        }
    }
}
