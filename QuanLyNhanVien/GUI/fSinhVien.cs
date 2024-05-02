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
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }




        private void fSinhVien_Load(object sender, EventArgs e)
        {
            if (HeThong.LOAITAIKHOAN != "Quản trị")
                btnQuanLy.Visible = false;
            else
                btnQuanLy.Visible = true;
            
            btnLamMoi.PerformClick();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhoa f = new fQuanLyKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyLop f = new fQuanLyLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quánLỷToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyCoVanHocTap f = new fQuanLyCoVanHocTap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyMonHoc f = new fQuanLyMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyDiem f = new fQuanLyDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fThongTinChiTiet().ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fDoiMatKhau().ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

       

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbTenCoVan.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbTenCoVan.ValueMember = "MaCVHT";
            cmbTenCoVan.DisplayMember = "TenCVHT";
            cmbTenKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbTenKhoa.ValueMember = "MaKhoa";
            cmbTenKhoa.DisplayMember = "TenKhoa"; 
            cmbTenLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbTenLop.ValueMember = "MaLop";
            cmbTenLop.DisplayMember = "TenLop"; 
        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSV = txbMaSV.Text;
            string TenSV = txbTenSV.Text;
            string NgaySinh = dtpkNgaySinh.Value.ToShortDateString();
            string GioiTinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string QueQuan = txbQueQuan.Text;
            string NgayNhapHoc = dtpkNhapHoc.Value.ToShortDateString();
            string TenLop = cmbTenLop.SelectedValue.ToString();
            string TenKhoa = cmbTenKhoa.SelectedValue.ToString();
            string TenCoVan = cmbTenCoVan.SelectedValue.ToString();

            if (BLL_SinhVien.Instance.Them(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, TenLop , TenKhoa, TenCoVan) == true)
                btnLamMoi.PerformClick();
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maSV = txbMaSV.Text;
            if (MessageBox.Show($"Bạn có muốn xóa môn học {maSV}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (BLL_SinhVien.Instance.Xoa(id) == true)
                    btnLamMoi.PerformClick();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = Int32.Parse(dgvSinhVien.CurrentRow.Cells[0].Value.ToString().Trim()) ;
            //// Call to DB to get detail of this Student
            //var sinhvienDetail = BLL_SinhVien.Instance.GetDetailStudent(id);

            //Binding value to UI
            //cmbTenLop.SelectedValue = sinhvienDetail.MaLop;
            //cmbTenKhoa.SelectedValue = sinhvienDetail.MaKhoa;
            //cmbTenCoVan.SelectedValue = sinhvienDetail.MaCVHT;


            txbID.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaSV.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenSV.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString().Trim();
            dtpkNgaySinh.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[3].Value;
            if (dgvSinhVien.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            dtpkNhapHoc.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[6].Value;
            txbQueQuan.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString().Trim();
            cmbTenLop.SelectedValue = dgvSinhVien.CurrentRow.Cells[7].Value.ToString().Trim();
            cmbTenKhoa.SelectedValue = dgvSinhVien.CurrentRow.Cells[8].Value.ToString().Trim();
            cmbTenCoVan.SelectedValue = dgvSinhVien.CurrentRow.Cells[9].Value.ToString().Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string MaSV = txbMaSV.Text;
            string TenSV = txbTenSV.Text;
            string NgaySinh = dtpkNgaySinh.Value.ToShortDateString();
            string GioiTinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string QueQuan = txbQueQuan.Text;
            string NgayNhapHoc = dtpkNhapHoc.Value.ToShortDateString();
            string MaLop  = cmbTenLop.SelectedValue.ToString();

            string MaKhoa = cmbTenKhoa.SelectedValue.ToString();
            string MaCVHT = cmbTenCoVan.SelectedValue.ToString();

            if (BLL_SinhVien.Instance.Sua(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT, id) == true)
                btnLamMoi.PerformClick();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}