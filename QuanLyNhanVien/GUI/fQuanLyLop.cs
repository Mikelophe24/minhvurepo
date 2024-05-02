using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.BLL;

namespace QuanLyNhanVien.GUI
{
    public partial class fQuanLyLop : Form
    {
        public fQuanLyLop()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";

            if (BLL_Khoa.Instance.DanhSach().Rows.Count > 0)
                cmbMaKhoa.SelectedIndex = 0;

        }

        private void fQuanLyLop_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim();
            int soluong = (int)numSoLuong.Value;

            if (malop.Length > 0 && tenlop.Length > 0)
            {
                try
                {
                    if (BLL_Lop.Instance.Them(malop, tenlop, soluong, makhoa) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("mã lớp đã tồn tại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("vui lòng không bỏ trống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(txbID.Text, out id))
                {
                    MessageBox.Show("ID phải là một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string malop = txbMaLop.Text.Trim();
                string tenlop = txbTenLop.Text.Trim();
                string makhoa = cmbMaKhoa.SelectedValue?.ToString().Trim(); // Đảm bảo giá trị được chọn không rỗng
                int soluong = (int)numSoLuong.Value;

                if (string.IsNullOrWhiteSpace(malop) || string.IsNullOrWhiteSpace(tenlop) || string.IsNullOrWhiteSpace(makhoa))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (BLL_Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id))
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Mã lớp đang được sử dung!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Định dạng đầu vào không hợp lệ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string tenlop = txbTenLop.Text;

            if (MessageBox.Show("Bạn có muốn xóa lớp " + tenlop + " không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                    if (BLL_Lop.Instance.Xoa(id) == true)
                {
                    btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                       
                else
                {
                    MessageBox.Show("Mã lớp đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvLop.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoLuong.Value = (int)dgvLop.CurrentRow.Cells[3].Value;
            cmbMaKhoa.SelectedValue = dgvLop.CurrentRow.Cells[4].Value.ToString().Trim();
        }

       
    }
}
