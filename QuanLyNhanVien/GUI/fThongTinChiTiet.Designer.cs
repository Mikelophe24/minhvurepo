namespace QuanLyNhanVien.GUI
{
    partial class fThongTinChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Enabled = false;
            this.txbTenDangNhap.Location = new System.Drawing.Point(36, 47);
            this.txbTenDangNhap.MaxLength = 255;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(189, 26);
            this.txbTenDangNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đâng nhập";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Enabled = false;
            this.txbMatKhau.Location = new System.Drawing.Point(36, 108);
            this.txbMatKhau.MaxLength = 255;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(191, 26);
            this.txbMatKhau.TabIndex = 1;
            this.txbMatKhau.TextChanged += new System.EventHandler(this.txbMatKhau_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txbLoaiTaiKhoan
            // 
            this.txbLoaiTaiKhoan.Enabled = false;
            this.txbLoaiTaiKhoan.Location = new System.Drawing.Point(36, 175);
            this.txbLoaiTaiKhoan.MaxLength = 255;
            this.txbLoaiTaiKhoan.Name = "txbLoaiTaiKhoan";
            this.txbLoaiTaiKhoan.Size = new System.Drawing.Size(191, 26);
            this.txbLoaiTaiKhoan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại tài khoản";
            // 
            // txbDangNhap
            // 
            this.txbDangNhap.BackColor = System.Drawing.SystemColors.Menu;
            this.txbDangNhap.Enabled = false;
            this.txbDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDangNhap.Location = new System.Drawing.Point(36, 47);
            this.txbDangNhap.MaxLength = 255;
            this.txbDangNhap.Name = "txbDangNhap";
            this.txbDangNhap.Size = new System.Drawing.Size(189, 26);
            this.txbDangNhap.TabIndex = 0;
            this.txbDangNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên đâng nhập";
            // 
            // fThongTinChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLoaiTaiKhoan);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbDangNhap);
            this.Controls.Add(this.txbTenDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongTinChiTiet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.fThongTinChiTiet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLoaiTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDangNhap;
        private System.Windows.Forms.Label label4;
    }
}