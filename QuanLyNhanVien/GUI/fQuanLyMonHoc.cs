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
    public partial class fQuanLyMonHoc : Form
    {
        public fQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                string mamonhoc = txbMaMonHoc.Text;
                string tenmonhoc = txbTenMonHoc.Text;
                int sotinchi = (int)numSoTinChi.Value;
                int tietlythuyet = (int)numTietLyThuyet.Value;
                int tietthuchanh = (int)numTietThucHanh.Value;

            if (BLL_MonHoc.Instance.Them(mamonhoc, tenmonhoc, sotinchi, tietlythuyet, tietthuchanh) == true)
                btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = BLL_MonHoc.Instance.DanhSach
                ();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             txbID.Text = dgvMonHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaMonHoc.Text = dgvMonHoc.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenMonHoc.Text = dgvMonHoc.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoTinChi.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[3].Value.ToString().Trim());  
            numTietLyThuyet.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[4].Value.ToString().Trim());
            numTietThucHanh.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[5].Value.ToString().Trim());

        }

        private void fQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string mamonhoc = txbMaMonHoc.Text;
            string tenmonhoc = txbTenMonHoc.Text;
            int sotinchi = (int)numSoTinChi.Value;
            int tietlythuyet = (int)numTietLyThuyet.Value;
            int tietthuchanh = (int)numTietThucHanh.Value;

            if (BLL_MonHoc.Instance.Sua(mamonhoc, tenmonhoc, sotinchi, tietlythuyet, tietthuchanh, id) == true)
                btnLamMoi.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaMonHoc.Text;
            if (MessageBox.Show($"Bạn có muốn xóa môn học {maMH}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (BLL_MonHoc.Instance.Xoa(id) == true)
                    btnLamMoi.PerformClick();
        }
    }
    
}
