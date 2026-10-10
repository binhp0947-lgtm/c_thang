namespace QuanLySinhVien.GUI
{
    partial class frmQuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblLopHoc = new Label();
            cboLopHoc = new ComboBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            lblDiem = new Label();
            nudDiem = new NumericUpDown();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTuKhoa = new Label();
            txtTimKiem = new TextBox();
            lblLocLop = new Label();
            cboLocLop = new ComboBox();
            lblLocDiem = new Label();
            nudLocDiem = new NumericUpDown();
            btnTimKiem = new Button();
            btnHienThiTatCa = new Button();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            colTenLop = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLocDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 50, 90);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // lblMaSV
            // 
            lblMaSV.Location = new Point(30, 65);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(100, 23);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã sinh viên *";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(130, 62);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(180, 27);
            txtMaSV.TabIndex = 2;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(350, 65);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ và tên *";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(430, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 27);
            txtHoTen.TabIndex = 4;
            // 
            // lblLopHoc
            // 
            lblLopHoc.Location = new Point(670, 65);
            lblLopHoc.Name = "lblLopHoc";
            lblLopHoc.Size = new Size(100, 23);
            lblLopHoc.TabIndex = 5;
            lblLopHoc.Text = "Lớp học *";
            // 
            // cboLopHoc
            // 
            cboLopHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopHoc.Location = new Point(750, 62);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(220, 28);
            cboLopHoc.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(30, 105);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 7;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(130, 102);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(180, 27);
            dtpNgaySinh.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(350, 105);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 9;
            lblGioiTinh.Text = "Giới tính";
            // 
            // rdoNam
            // 
            rdoNam.Checked = true;
            rdoNam.Location = new Point(430, 102);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(60, 25);
            rdoNam.TabIndex = 10;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.CheckedChanged += rdoNam_CheckedChanged;
            // 
            // rdoNu
            // 
            rdoNu.Location = new Point(500, 102);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(60, 25);
            rdoNu.TabIndex = 11;
            rdoNu.Text = "Nữ";
            // 
            // lblDiem
            // 
            lblDiem.Location = new Point(670, 105);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(100, 23);
            lblDiem.TabIndex = 12;
            lblDiem.Text = "Điểm *";
            // 
            // nudDiem
            // 
            nudDiem.DecimalPlaces = 1;
            nudDiem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDiem.Location = new Point(750, 102);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(220, 27);
            nudDiem.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(30, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 15;
            // 
            // lblDienThoai
            // 
            lblDienThoai.Location = new Point(350, 145);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(100, 23);
            lblDienThoai.TabIndex = 16;
            lblDienThoai.Text = "Điện thoại *";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(430, 142);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(200, 27);
            txtDienThoai.TabIndex = 17;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(670, 145);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 23);
            lblTrangThai.TabIndex = 18;
            lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Location = new Point(750, 142);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(220, 28);
            cboTrangThai.TabIndex = 19;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(28, 135, 78);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(620, 185);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 32);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(51, 103, 173);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(710, 185);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 32);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(195, 45, 45);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(800, 185);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 32);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(890, 185);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(80, 32);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.Location = new Point(30, 240);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(100, 23);
            lblTuKhoa.TabIndex = 24;
            lblTuKhoa.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(90, 237);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Mã, họ tên, email hoặc điện thoại";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 25;
            // 
            // lblLocLop
            // 
            lblLocLop.Location = new Point(330, 240);
            lblLocLop.Name = "lblLocLop";
            lblLocLop.Size = new Size(100, 23);
            lblLocLop.TabIndex = 26;
            lblLocLop.Text = "Lớp";
            // 
            // cboLocLop
            // 
            cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLop.Location = new Point(365, 237);
            cboLocLop.Name = "cboLocLop";
            cboLocLop.Size = new Size(180, 28);
            cboLocLop.TabIndex = 27;
            cboLocLop.SelectedIndexChanged += cboLocLop_SelectedIndexChanged;
            // 
            // lblLocDiem
            // 
            lblLocDiem.Location = new Point(560, 240);
            lblLocDiem.Name = "lblLocDiem";
            lblLocDiem.Size = new Size(100, 23);
            lblLocDiem.TabIndex = 28;
            lblLocDiem.Text = "Điểm từ";
            // 
            // nudLocDiem
            // 
            nudLocDiem.DecimalPlaces = 1;
            nudLocDiem.Location = new Point(620, 237);
            nudLocDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudLocDiem.Name = "nudLocDiem";
            nudLocDiem.Size = new Size(70, 27);
            nudLocDiem.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(30, 80, 140);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(710, 234);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 30);
            btnTimKiem.TabIndex = 30;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHienThiTatCa
            // 
            btnHienThiTatCa.Location = new Point(810, 234);
            btnHienThiTatCa.Name = "btnHienThiTatCa";
            btnHienThiTatCa.Size = new Size(110, 30);
            btnHienThiTatCa.TabIndex = 31;
            btnHienThiTatCa.Text = "Hiển thị tất cả";
            btnHienThiTatCa.Click += btnHienThiTatCa_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.ColumnHeadersHeight = 29;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colNgaySinh, colGioiTinh, colEmail, colDienThoai, colDiem, colTenLop, colTrangThai });
            dgvSinhVien.Location = new Point(30, 280);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1020, 340);
            dgvSinhVien.TabIndex = 32;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            colMaSV.Width = 90;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            colHoTen.Width = 140;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            colNgaySinh.Width = 95;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            colGioiTinh.Width = 80;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 140;
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            colDienThoai.ReadOnly = true;
            // 
            // colDiem
            // 
            colDiem.DataPropertyName = "Diem";
            colDiem.HeaderText = "Điểm";
            colDiem.MinimumWidth = 6;
            colDiem.Name = "colDiem";
            colDiem.ReadOnly = true;
            colDiem.Width = 60;
            // 
            // colTenLop
            // 
            colTenLop.DataPropertyName = "TenLop";
            colTenLop.HeaderText = "Lớp";
            colTenLop.MinimumWidth = 6;
            colTenLop.Name = "colTenLop";
            colTenLop.ReadOnly = true;
            colTenLop.Width = 160;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // lblTongSo
            // 
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.Location = new Point(880, 282);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(170, 20);
            lblTongSo.TabIndex = 33;
            lblTongSo.Text = "Tổng số: 0 sinh viên";
            lblTongSo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmQuanLySinhVien
            // 
            ClientSize = new Size(1080, 680);
            Controls.Add(lblTitle);
            Controls.Add(lblMaSV);
            Controls.Add(txtMaSV);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblLopHoc);
            Controls.Add(cboLopHoc);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(rdoNam);
            Controls.Add(rdoNu);
            Controls.Add(lblDiem);
            Controls.Add(nudDiem);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblDienThoai);
            Controls.Add(txtDienThoai);
            Controls.Add(lblTrangThai);
            Controls.Add(cboTrangThai);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTuKhoa);
            Controls.Add(txtTimKiem);
            Controls.Add(lblLocLop);
            Controls.Add(cboLocLop);
            Controls.Add(lblLocDiem);
            Controls.Add(nudLocDiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnHienThiTatCa);
            Controls.Add(dgvSinhVien);
            Controls.Add(lblTongSo);
            Font = new Font("Segoe UI", 9F);
            Name = "frmQuanLySinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng quản lý sinh viên";
            Load += frmQuanLySinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLocDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle, lblMaSV, lblHoTen, lblLopHoc, lblNgaySinh, lblGioiTinh, lblDiem, lblEmail, lblDienThoai, lblTrangThai, lblTongSo;
        private System.Windows.Forms.Label lblTuKhoa, lblLocLop, lblLocDiem;
        private System.Windows.Forms.TextBox txtMaSV, txtHoTen, txtEmail, txtDienThoai, txtTimKiem;
        private System.Windows.Forms.ComboBox cboLopHoc, cboTrangThai, cboLocLop;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNam, rdoNu;
        private System.Windows.Forms.NumericUpDown nudDiem, nudLocDiem;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi, btnTimKiem, btnHienThiTatCa;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV, colHoTen, colNgaySinh, colGioiTinh, colEmail, colDienThoai, colDiem, colTenLop, colTrangThai;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
