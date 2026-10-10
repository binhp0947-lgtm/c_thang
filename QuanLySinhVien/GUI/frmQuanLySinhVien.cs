using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLySinhVien.BLL;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.GUI
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly SinhVienBLL _sinhVienBLL = new SinhVienBLL();
        private readonly LopHocBLL _lopHocBLL = new LopHocBLL();
        private bool _isBinding = false; // Cờ tránh sự kiện lặp

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        #region Form Load & Khởi tạo
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            ThietLapTabIndex();
            KhoiTaoCboTrangThai();
            LoadDanhSachLopLenCombobox();
            LoadDanhSachSinhVien();
            ThietLapTrangThaiNut(isTonTai: false);

            txtMaSV.Focus();
        }

        // Thiết lập TabIndex từ trên xuống dưới, trái qua phải
        private void ThietLapTabIndex()
        {
            txtMaSV.TabIndex = 0;
            txtHoTen.TabIndex = 1;
            cboLopHoc.TabIndex = 2;
            dtpNgaySinh.TabIndex = 3;
            rdoNam.TabIndex = 4;
            rdoNu.TabIndex = 5;
            nudDiem.TabIndex = 6;
            txtEmail.TabIndex = 7;
            txtDienThoai.TabIndex = 8;
            cboTrangThai.TabIndex = 9;

            btnThem.TabIndex = 10;
            btnSua.TabIndex = 11;
            btnXoa.TabIndex = 12;
            btnLamMoi.TabIndex = 13;

            txtTimKiem.TabIndex = 14;
            cboLocLop.TabIndex = 15;
            nudLocDiem.TabIndex = 16;
            btnTimKiem.TabIndex = 17;
            btnHienThiTatCa.TabIndex = 18;
            dgvSinhVien.TabIndex = 19;
        }

        private void KhoiTaoCboTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp" });
            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadDanhSachLopLenCombobox()
        {
            var dsLop = _lopHocBLL.LayDanhSachLop();

            // 1. Gán cho cboLopHoc (phần nhập thông tin SV)
            cboLopHoc.DataSource = new BindingSource(dsLop, null);
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";

            // 2. Gán cho cboLocLop (phần tìm kiếm/lọc)
            var dsLoc = new List<LopHoc> { new LopHoc("ALL", "Tất cả lớp") };
            dsLoc.AddRange(dsLop);

            cboLocLop.DataSource = new BindingSource(dsLoc, null);
            cboLocLop.DisplayMember = "TenLop";
            cboLocLop.ValueMember = "MaLop";
            cboLocLop.SelectedIndex = 0;
        }

        private void LoadDanhSachSinhVien(List<SinhVien> list = null)
        {
            var data = list ?? _sinhVienBLL.LayTatCaSinhVien();
            dgvSinhVien.DataSource = null;
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.DataSource = data;
            lblTongSo.Text = $"Tổng số: {data.Count} sinh viên";
        }
        #endregion

        #region Xử lý Trạng thái Nút & Nhập Mã SV
        private void ThietLapTrangThaiNut(bool isTonTai)
        {
            btnThem.Enabled = !isTonTai;
            btnSua.Enabled = isTonTai;
            btnXoa.Enabled = isTonTai;
        }

        // Khi gõ hoặc rời khỏi ô txtMaSV
        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            if (_isBinding) return;

            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                XoaTrangThongTinChiTiet(giuLaiMaSV: true);
                ThietLapTrangThaiNut(isTonTai: false);
                errorProvider.SetError(txtMaSV, "");
                return;
            }

            var sv = _sinhVienBLL.LaySinhVienTheoMa(maSV);
            if (sv != null)
            {
                // Tồn tại: hiển thị lên các điều khiển, disable Thêm, enable Sửa/Xóa
                HienThiThongTinLenDieuKhien(sv);
                ThietLapTrangThaiNut(isTonTai: true);
                errorProvider.Clear();
            }
            else
            {
                // Chưa tồn tại: xóa trống các điều khiển còn lại, enable Thêm, disable Sửa/Xóa
                XoaTrangThongTinChiTiet(giuLaiMaSV: true);
                ThietLapTrangThaiNut(isTonTai: false);
            }
        }

        private void HienThiThongTinLenDieuKhien(SinhVien sv)
        {
            _isBinding = true;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh >= dtpNgaySinh.MinDate ? sv.NgaySinh : DateTime.Today;
            if (sv.GioiTinh == "Nữ") rdoNu.Checked = true; else rdoNam.Checked = true;
            txtEmail.Text = sv.Email;
            txtDienThoai.Text = sv.DienThoai;
            nudDiem.Value = (decimal)sv.Diem;
            cboLopHoc.SelectedValue = sv.MaLop;
            cboTrangThai.SelectedItem = sv.TrangThai;
            _isBinding = false;
        }

        private void XoaTrangThongTinChiTiet(bool giuLaiMaSV = false)
        {
            _isBinding = true;
            if (!giuLaiMaSV) txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = new DateTime(2006, 1, 1);
            rdoNam.Checked = true;
            txtEmail.Clear();
            txtDienThoai.Clear();
            nudDiem.Value = 0;
            if (cboLopHoc.Items.Count > 0) cboLopHoc.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            _isBinding = false;
        }
        #endregion

        #region Kiểm tra Data Annotation và hiển thị ErrorProvider
        private bool KiemTraVaBaoLoi(SinhVien sv)
        {
            errorProvider.Clear();
            var (isValid, errors) = sv.Validate();
            if (isValid) return true;

            // Duyệt từng lỗi trả về từ Data Annotations và gắn vào đúng Control trên giao diện
            foreach (var err in errors)
            {
                foreach (var memberName in err.MemberNames)
                {
                    Control targetControl = null;
                    switch (memberName)
                    {
                        case nameof(SinhVien.MaSV): targetControl = txtMaSV; break;
                        case nameof(SinhVien.HoTen): targetControl = txtHoTen; break;
                        case nameof(SinhVien.NgaySinh): targetControl = dtpNgaySinh; break;
                        case nameof(SinhVien.Email): targetControl = txtEmail; break;
                        case nameof(SinhVien.DienThoai): targetControl = txtDienThoai; break;
                        case nameof(SinhVien.Diem): targetControl = nudDiem; break;
                        case nameof(SinhVien.MaLop): targetControl = cboLopHoc; break;
                        case nameof(SinhVien.TrangThai): targetControl = cboTrangThai; break;
                    }

                    if (targetControl != null && string.IsNullOrEmpty(errorProvider.GetError(targetControl)))
                    {
                        errorProvider.SetError(targetControl, err.ErrorMessage);
                    }
                }
            }
            return false;
        }

        private SinhVien ThuThapDuLieuTuForm()
        {
            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                Email = txtEmail.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Diem = (double)nudDiem.Value,
                MaLop = cboLopHoc.SelectedValue?.ToString(),
                TrangThai = cboTrangThai.SelectedItem?.ToString()
            };
        }
        #endregion

        #region Các Thao Tác Thêm, Sửa, Xóa, Làm Mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            var sv = ThuThapDuLieuTuForm();
            if (!KiemTraVaBaoLoi(sv)) return;

            var (success, msg) = _sinhVienBLL.ThemSinhVien(sv);
            if (success)
            {
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachSinhVien();
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtMaSV, msg);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sv = ThuThapDuLieuTuForm();
            if (!KiemTraVaBaoLoi(sv)) return;

            var (success, msg) = _sinhVienBLL.CapNhatSinhVien(sv);
            if (success)
            {
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachSinhVien();
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chức năng nguy hiểm: Xác thực trước khi thực hiện
            DialogResult dialog = MessageBox.Show(
                $"Hành động này không thể hoàn tác!\nBạn có chắc chắn muốn xóa sinh viên '{txtHoTen.Text}' (Mã: {maSV}) không?",
                "Xác nhận xóa sinh viên",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.Yes)
            {
                var (success, msg) = _sinhVienBLL.XoaSinhVien(maSV);
                if (success)
                {
                    MessageBox.Show(msg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            XoaTrangThongTinChiTiet(giuLaiMaSV: false);
            ThietLapTrangThaiNut(isTonTai: false);
            txtMaSV.Focus();
        }
        #endregion

        #region Lọc và Tìm Kiếm (Phía Giao diện & Cơ sở dữ liệu/BLL)
        // Khi chọn lớp ở phần tìm kiếm: lọc sinh viên theo lớp
        private void cboLocLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThucHienTimKiemVaLoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ThucHienTimKiemVaLoc();
        }

        private void ThucHienTimKiemVaLoc()
        {
            string keyword = txtTimKiem.Text.Trim();
            string maLop = cboLocLop.SelectedValue?.ToString();
            double diemTu = (double)nudLocDiem.Value;

            // Gọi qua BLL -> DAL để tìm kiếm
            var ketQua = _sinhVienBLL.TimKiem(keyword, maLop, diemTu);
            LoadDanhSachSinhVien(ketQua);
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocLop.SelectedIndex = 0;
            nudLocDiem.Value = 0;
            LoadDanhSachSinhVien();
        }

        // Click trên DataGridView để xem chi tiết
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                string maSV = row.Cells["colMaSV"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(maSV))
                {
                    txtMaSV.Text = maSV; // Sẽ kích hoạt txtMaSV_TextChanged
                }
            }
        }
        #endregion
    }
}
