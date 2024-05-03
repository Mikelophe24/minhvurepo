using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.BLL;

namespace QuanLyNhanVien.GUI
{
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem()
        {
            InitializeComponent();
        }

      
        private void btnThem_Click(object sender, EventArgs e)
        {
            string masv = cmbMaSinhVien.SelectedValue.ToString();
            string mamh = cmbMaMonHoc.SelectedValue.ToString();
            int phantramlop = (int)numPhanTramLop.Value;
            int phantramthi = (int)numPhanTramThi.Value;
            float diemlop = float.Parse(txbDiemLop.Text);
            float diemthi = float.Parse(txbDiemThi.Text);
            float diemtb = (((phantramlop) * diemlop ) + ( (phantramthi ) * diemthi ))/100f;
            diemtb = (float)Math.Round(diemtb, 2);
            string loai;
            if (diemtb >= 8.5)
                loai = "A";
            else if (diemtb >= 7.0)
                loai = "B";
            else if (diemtb >= 5.5)
                loai = "C";
            else if (diemtb >= 4.0)
                loai = "D";
            else
                loai = "F";
           // int nam = DateTime.Now.Year;

            if (BLL_Diem.Instance.Them(masv, mamh, phantramlop, phantramthi, diemlop, diemthi, diemtb, loai)) ;
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            dgvDiem.DataSource = BLL_Diem.Instance.DanhSach();
            cmbMaSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaSinhVien.DisplayMember = "TenSV";
            cmbMaSinhVien.ValueMember = "MaSV";
            cmbMaMonHoc.DataSource = BLL_MonHoc.Instance.DanhSach();
            cmbMaMonHoc.DisplayMember = "TenMH";
            cmbMaMonHoc.ValueMember = "MaMH";
        }

        private void fQuanLyDiem_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {   
            int id = int.Parse(txbID.Text); 
            string masv = cmbMaSinhVien.SelectedValue.ToString();
            string mamh = cmbMaMonHoc.SelectedValue.ToString();
            int phantramlop = (int)numPhanTramLop.Value;
            int phantramthi = (int)numPhanTramThi.Value;
            float diemlop = float.Parse(txbDiemLop.Text);
            float diemthi = float.Parse(txbDiemThi.Text);
            float diemtb = (((phantramlop) * diemlop) + ((phantramthi) * diemthi)) / 100f;
            diemtb = (float)Math.Round(diemtb, 2);
            string loai;
            if (diemtb >= 8.5)
                loai = "A";
            else if (diemtb >= 7.0)
                loai = "B";
            else if (diemtb >= 5.5)
                loai = "C";
            else if (diemtb >= 4.0)
                loai = "D";
            else
                loai = "F";
            //  int nam = DateTime.Now.Year;

            if (BLL_Diem.Instance.Sua(masv, mamh, phantramlop, phantramthi, diemlop, diemthi, diemtb, loai, id)) ;
            else
            {
                MessageBox.Show("Ma Sinhvien học tập đang được sử dụng , vui lòng thử lại sau!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnLamMoi.PerformClick();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            
            if (MessageBox.Show($"Bạn có muốn xóa điểm có id : {id} ?", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (BLL_Diem.Instance.Xoa(id))
                    btnLamMoi.PerformClick();
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            cmbMaSinhVien.SelectedValue = dgvDiem.CurrentRow.Cells[1].Value.ToString();
            cmbMaMonHoc.SelectedValue = dgvDiem.CurrentRow.Cells[2].Value.ToString();
            numPhanTramLop.Value = int.Parse(dgvDiem.CurrentRow.Cells[3].Value.ToString());
            numPhanTramThi.Value = int.Parse(dgvDiem.CurrentRow.Cells[4].Value.ToString());
            txbDiemLop.Text = dgvDiem.CurrentRow.Cells[5].Value.ToString();
            txbDiemThi.Text = dgvDiem.CurrentRow.Cells[6].Value.ToString();
            txbDiemTB.Text = dgvDiem.CurrentRow.Cells[7].Value.ToString();
            
            cmbLoai.SelectedItem = dgvDiem.CurrentRow.Cells[8].Value.ToString().Trim();
        }

        private void txbDiemLop_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbDiemLop.Text))
            {
                if (int.TryParse(txbDiemLop.Text, out int score))
                {
                    if (score > 10)
                    {
                        MessageBox.Show("Điểm trên lớp phải nhỏ hơn 10, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbDiemLop.Text = ""; // Clear the textbox if the input is invalid
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbDiemLop.Text = ""; // Clear the textbox if the input is not a valid integer
                }
            }
        }

        private void txbDiemThi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbDiemThi.Text))
            {
                if (int.TryParse(txbDiemThi.Text, out int score))
                {
                    if (score > 10)
                    {
                        MessageBox.Show("Điểm thi phải nhỏ hơn 10, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbDiemThi.Text = ""; // Clear the textbox if the input is invalid
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbDiemThi.Text = ""; // Clear the textbox if the input is not a valid integer
                }
            }
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numPhanTramThi_ValueChanged(object sender, EventArgs e)
        {
            numPhanTramThi.Value = 100 - numPhanTramLop.Value;

        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
