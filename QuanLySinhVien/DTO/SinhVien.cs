using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.DTO
{
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        [RegularExpression(@"^[a-zA-Z0-9]{5,15}$", ErrorMessage = "Mã SV gồm 5-15 ký tự chữ và số (ví dụ: SV000123)")]
        public string MaSV { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Họ và tên từ 2 đến 100 ký tự")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string GioiTinh { get; set; } // "Nam" hoặc "Nữ"

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng (vd: an.nv@vju.ac.vn)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^(0[3|5|7|8|9])+([0-9]{8})$", ErrorMessage = "Số điện thoại không hợp lệ (10 chữ số, bắt đầu bằng 03, 05, 07, 08, 09)")]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Điểm không được để trống")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        public double Diem { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn lớp học")]
        public string MaLop { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn trạng thái")]
        public string TrangThai { get; set; } // "Đang học", "Bảo lưu", "Đã tốt nghiệp"

        // Thuộc tính phụ trợ để hiển thị Tên Lớp trên DataGridView
        public string TenLop { get; set; }

        public SinhVien() { }

        // Phương thức kiểm tra Validate bản thân đối tượng
        public (bool IsValid, List<ValidationResult> Errors) Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            // Kiểm tra thêm nghiệp vụ ngày sinh (phải đủ từ 16 tuổi trở lên)
            if (DateTime.Now.Year - NgaySinh.Year < 16)
            {
                results.Add(new ValidationResult("Sinh viên phải từ 16 tuổi trở lên", new[] { nameof(NgaySinh) }));
                isValid = false;
            }

            return (isValid, results);
        }
    }
}
