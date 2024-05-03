namespace QuanLyNhanVien.GUI
{
    partial class fQuanLyDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numPhanTramThi = new System.Windows.Forms.NumericUpDown();
            this.numPhanTramLop = new System.Windows.Forms.NumericUpDown();
            this.cmbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.cmbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDiemTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDiemThi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDiemLop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 602);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 602);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 456);
            this.panel1.TabIndex = 5;
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Loai});
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiem.MultiSelect = false;
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.RowHeadersVisible = false;
            this.dgvDiem.RowTemplate.Height = 30;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(1092, 456);
            this.dgvDiem.TabIndex = 1;
            this.dgvDiem.TabStop = false;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            this.dgvDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel4.Controls.Add(this.numPhanTramThi);
            this.panel4.Controls.Add(this.numPhanTramLop);
            this.panel4.Controls.Add(this.cmbMaMonHoc);
            this.panel4.Controls.Add(this.cmbLoai);
            this.panel4.Controls.Add(this.cmbMaSinhVien);
            this.panel4.Controls.Add(this.btnLamMoi);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbDiemTB);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txbDiemThi);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txbDiemLop);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txbID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1092, 146);
            this.panel4.TabIndex = 4;
            // 
            // numPhanTramThi
            // 
            this.numPhanTramThi.Location = new System.Drawing.Point(838, 20);
            this.numPhanTramThi.Name = "numPhanTramThi";
            this.numPhanTramThi.Size = new System.Drawing.Size(67, 26);
            this.numPhanTramThi.TabIndex = 4;
            this.numPhanTramThi.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // numPhanTramLop
            // 
            this.numPhanTramLop.Location = new System.Drawing.Point(666, 18);
            this.numPhanTramLop.Name = "numPhanTramLop";
            this.numPhanTramLop.Size = new System.Drawing.Size(67, 26);
            this.numPhanTramLop.TabIndex = 3;
            this.numPhanTramLop.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cmbMaMonHoc
            // 
            this.cmbMaMonHoc.FormattingEnabled = true;
            this.cmbMaMonHoc.Location = new System.Drawing.Point(430, 17);
            this.cmbMaMonHoc.Name = "cmbMaMonHoc";
            this.cmbMaMonHoc.Size = new System.Drawing.Size(121, 27);
            this.cmbMaMonHoc.TabIndex = 2;
            // 
            // cmbLoai
            // 
            this.cmbLoai.Enabled = false;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.cmbLoai.Location = new System.Drawing.Point(530, 71);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(71, 27);
            this.cmbLoai.TabIndex = 8;
            this.cmbLoai.Visible = false;
            this.cmbLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLoai_SelectedIndexChanged);
            // 
            // cmbMaSinhVien
            // 
            this.cmbMaSinhVien.FormattingEnabled = true;
            this.cmbMaSinhVien.Location = new System.Drawing.Point(210, 19);
            this.cmbMaSinhVien.Name = "cmbMaSinhVien";
            this.cmbMaSinhVien.Size = new System.Drawing.Size(121, 27);
            this.cmbMaSinhVien.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(872, 63);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 34);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.TabStop = false;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(799, 63);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "P.trăm thi";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(726, 63);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "P. trăm lớp";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(636, 63);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // txbDiemTB
            // 
            this.txbDiemTB.Enabled = false;
            this.txbDiemTB.Location = new System.Drawing.Point(395, 71);
            this.txbDiemTB.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiemTB.MaxLength = 255;
            this.txbDiemTB.Name = "txbDiemTB";
            this.txbDiemTB.ShortcutsEnabled = false;
            this.txbDiemTB.Size = new System.Drawing.Size(61, 26);
            this.txbDiemTB.TabIndex = 7;
            this.txbDiemTB.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Điểm tb:";
            this.label10.Visible = false;
            // 
            // txbDiemThi
            // 
            this.txbDiemThi.Location = new System.Drawing.Point(240, 67);
            this.txbDiemThi.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiemThi.MaxLength = 10;
            this.txbDiemThi.Name = "txbDiemThi";
            this.txbDiemThi.Size = new System.Drawing.Size(61, 26);
            this.txbDiemThi.TabIndex = 6;
            this.txbDiemThi.TextChanged += new System.EventHandler(this.txbDiemThi_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Điểm thi";
            // 
            // txbDiemLop
            // 
            this.txbDiemLop.Location = new System.Drawing.Point(90, 68);
            this.txbDiemLop.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiemLop.MaxLength = 10;
            this.txbDiemLop.Name = "txbDiemLop";
            this.txbDiemLop.Size = new System.Drawing.Size(61, 26);
            this.txbDiemLop.TabIndex = 5;
            this.txbDiemLop.TextChanged += new System.EventHandler(this.txbDiemLop_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điểm lớp";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(45, 15);
            this.txbID.Margin = new System.Windows.Forms.Padding(4);
            this.txbID.MaxLength = 255;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(61, 26);
            this.txbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.MaxInputLength = 255;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSV";
            this.Column2.HeaderText = "MÃSV";
            this.Column2.MaxInputLength = 255;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaMH";
            this.Column3.HeaderText = "Mã Môn Học";
            this.Column3.MaxInputLength = 255;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PhanTranTrenLop";
            this.Column4.HeaderText = "P.TRĂM LỚP";
            this.Column4.MaxInputLength = 255;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PhanTramThi";
            this.Column5.HeaderText = "P.TRĂM THI";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DiemTrenLop";
            this.Column6.HeaderText = "ĐIỂM LỚP";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiemThi";
            this.Column7.HeaderText = "ĐIỂM THI";
            this.Column7.MaxInputLength = 255;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DiemTB";
            dataGridViewCellStyle1.Format = "N2";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column8.HeaderText = "ĐIỂM TB";
            this.Column8.MaxInputLength = 255;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "LOẠI";
            this.Loai.MaxInputLength = 255;
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            // 
            // fQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 602);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.fQuanLyDiem_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPhanTramThi;
        private System.Windows.Forms.NumericUpDown numPhanTramLop;
        private System.Windows.Forms.ComboBox cmbMaMonHoc;
        private System.Windows.Forms.ComboBox cmbMaSinhVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDiemTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDiemThi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDiemLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}