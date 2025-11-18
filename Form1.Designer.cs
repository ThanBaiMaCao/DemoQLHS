namespace DemoQLHS
{
    partial class Form1
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
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.dgvDanhMucHocSinh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.txtDiemToan = new System.Windows.Forms.TextBox();
            this.txtDiemVan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.BackColor = System.Drawing.Color.MistyRose;
            this.lblQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuanLy.Location = new System.Drawing.Point(185, 23);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(254, 29);
            this.lblQuanLy.TabIndex = 0;
            this.lblQuanLy.Text = "Trang quản lý học sinh";
            this.lblQuanLy.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDanhMucHocSinh
            // 
            this.dgvDanhMucHocSinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvDanhMucHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.MaSo,
            this.NgaySinh,
            this.DiemToan,
            this.DiemVan,
            this.GioiTinh});
            this.dgvDanhMucHocSinh.Location = new System.Drawing.Point(64, 287);
            this.dgvDanhMucHocSinh.Name = "dgvDanhMucHocSinh";
            this.dgvDanhMucHocSinh.RowHeadersWidth = 51;
            this.dgvDanhMucHocSinh.RowTemplate.Height = 24;
            this.dgvDanhMucHocSinh.Size = new System.Drawing.Size(985, 227);
            this.dgvDanhMucHocSinh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điểm toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điểm văn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(81, 89);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(206, 22);
            this.txtHoTen.TabIndex = 7;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(81, 121);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(206, 22);
            this.txtMaSo.TabIndex = 8;
            // 
            // txtDiemToan
            // 
            this.txtDiemToan.Location = new System.Drawing.Point(80, 182);
            this.txtDiemToan.Name = "txtDiemToan";
            this.txtDiemToan.Size = new System.Drawing.Size(206, 22);
            this.txtDiemToan.TabIndex = 10;
            // 
            // txtDiemVan
            // 
            this.txtDiemVan.Location = new System.Drawing.Point(81, 213);
            this.txtDiemVan.Name = "txtDiemVan";
            this.txtDiemVan.Size = new System.Drawing.Size(206, 22);
            this.txtDiemVan.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(367, 90);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 28);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm học sinh";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(500, 91);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 28);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa học sinh";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(367, 144);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 28);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(503, 144);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 28);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát!";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(367, 211);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 16;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(503, 211);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 17;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(81, 150);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(248, 22);
            this.dtpNgaySinh.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(80, 244);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(206, 22);
            this.txtDiaChi.TabIndex = 20;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 125;
            // 
            // MaSo
            // 
            this.MaSo.DataPropertyName = "MaSo";
            this.MaSo.HeaderText = "Mã số";
            this.MaSo.MinimumWidth = 6;
            this.MaSo.Name = "MaSo";
            this.MaSo.ReadOnly = true;
            this.MaSo.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 125;
            // 
            // DiemToan
            // 
            this.DiemToan.DataPropertyName = "DiemToan";
            this.DiemToan.HeaderText = "Điểm toán";
            this.DiemToan.MinimumWidth = 6;
            this.DiemToan.Name = "DiemToan";
            this.DiemToan.ReadOnly = true;
            this.DiemToan.Width = 125;
            // 
            // DiemVan
            // 
            this.DiemVan.DataPropertyName = "DiemVan";
            this.DiemVan.HeaderText = "Điểm văn";
            this.DiemVan.MinimumWidth = 6;
            this.DiemVan.Name = "DiemVan";
            this.DiemVan.ReadOnly = true;
            this.DiemVan.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1199, 526);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiemVan);
            this.Controls.Add(this.txtDiemToan);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhMucHocSinh);
            this.Controls.Add(this.lblQuanLy);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.DataGridView dgvDanhMucHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.TextBox txtDiemToan;
        private System.Windows.Forms.TextBox txtDiemVan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemVan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}

