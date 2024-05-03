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
    public partial class fQuanLyCoVanHocTap : Form
    {
        public fQuanLyCoVanHocTap()
        {
            InitializeComponent();
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvCoVanHocTap.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
        }


        private void fCoVanHocTap_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa =cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();

            if (BLL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop) == true)
                btnLamMoi.PerformClick();
        }

        private void dgvCoVanHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvCoVanHocTap.CurrentRow.Cells[0].Value.ToString();
            txbMaCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[1].Value.ToString();
            txbTenCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvCoVanHocTap.CurrentRow.Cells[3].Value;
            if (dgvCoVanHocTap.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            cmbMaKhoa.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[5].Value.ToString();
            cmbMaLop.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maCoVan = txbMaCoVan.Text;
           if(MessageBox.Show($"Bạn có muốn xóa cố vấn {maCoVan} ?" ,"thong bao", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(BLL_CoVanHocTap.Instance.Xoa(id))
                    btnLamMoi.PerformClick();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            int id = int.Parse((txbID.Text).Trim());
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();

            if (BLL_CoVanHocTap.Instance.Sua(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id) == true)
                btnLamMoi.PerformClick();
            else
            {
                MessageBox.Show("Ma co van học tập đang được sử dụng , vui lòng thử lại sau!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
