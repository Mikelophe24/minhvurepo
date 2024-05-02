namespace QuanLyNhanVien.GUI
{
    partial class fDoiMatKhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txbMatKhauCu = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu  mới";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(62, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu cũ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(57, 162);
            this.txbMatKhauMoi.MaxLength = 255;
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(218, 26);
            this.txbMatKhauMoi.TabIndex = 1;
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(57, 90);
            this.txbMatKhauCu.MaxLength = 255;
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(218, 26);
            this.txbMatKhauCu.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCapNhat.Location = new System.Drawing.Point(105, 206);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(109, 38);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.TabStop = false;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // fDoiMatKhau
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(343, 294);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.txbMatKhauCu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "fDoiMatKhau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMatKhauMoi;
        private System.Windows.Forms.TextBox txbMatKhauCu;
        private System.Windows.Forms.Button btnCapNhat;
    }
}