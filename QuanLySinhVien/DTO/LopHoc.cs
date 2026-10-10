using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.DTO
{
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Mã lớp từ 3 đến 20 ký tự")]
        public string MaLop { get; set; }

        [Required(ErrorMessage = "Tên lớp không được để trống")]
        [StringLength(100, ErrorMessage = "Tên lớp tối đa 100 ký tự")]
        public string TenLop { get; set; }

        public LopHoc() { }

        public LopHoc(string maLop, string tenLop)
        {
            MaLop = maLop;
            TenLop = tenLop;
        }

        // Phương thức kiểm tra Validate theo Data Annotations
        public (bool IsValid, List<ValidationResult> Errors) Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            bool isValid = Validator.TryValidateObject(this, context, results, true);
            return (isValid, results);
        }
    }
}
