using System;
using System.Collections.Generic;
using QuanLySinhVien.DAL;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.BLL
{
    public class SinhVienBLL
    {
        private readonly SinhVienDAL _sinhVienDAL = new SinhVienDAL();
        private readonly LopHocDAL _lopHocDAL = new LopHocDAL();

        // Gán Tên Lớp cho danh sách sinh viên trước khi trả về Presentation Layer
        private void MapTenLop(List<SinhVien> list)
        {
            var classes = _lopHocDAL.GetAll();
            foreach (var sv in list)
            {
                var lop = classes.Find(l => l.MaLop.Equals(sv.MaLop, StringComparison.OrdinalIgnoreCase));
                sv.TenLop = lop != null ? lop.TenLop : sv.MaLop;
            }
        }

        public List<SinhVien> LayTatCaSinhVien()
        {
            var list = _sinhVienDAL.GetAll();
            MapTenLop(list);
            return list;
        }

        public SinhVien LaySinhVienTheoMa(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return null;
            var sv = _sinhVienDAL.GetById(maSV.Trim());
            if (sv != null)
            {
                var lop = _lopHocDAL.GetById(sv.MaLop);
                sv.TenLop = lop != null ? lop.TenLop : sv.MaLop;
            }
            return sv;
        }

        public List<SinhVien> LaySinhVienTheoLop(string maLop)
        {
            var list = _sinhVienDAL.GetByClassId(maLop);
            MapTenLop(list);
            return list;
        }

        public (bool Success, string Message) ThemSinhVien(SinhVien sv)
        {
            // 1. Kiểm tra Validate DTO
            var (isValid, errors) = sv.Validate();
            if (!isValid)
                return (false, errors[0].ErrorMessage);

            // 2. Kiểm tra trùng mã
            if (_sinhVienDAL.GetById(sv.MaSV) != null)
                return (false, $"Mã sinh viên '{sv.MaSV}' đã tồn tại trong hệ thống.");

            // 3. Thực hiện thêm
            bool res = _sinhVienDAL.Insert(sv);
            return res ? (true, "Thêm sinh viên thành công.") : (false, "Lỗi khi lưu dữ liệu.");
        }

        public (bool Success, string Message) CapNhatSinhVien(SinhVien sv)
        {
            var (isValid, errors) = sv.Validate();
            if (!isValid)
                return (false, errors[0].ErrorMessage);

            if (_sinhVienDAL.GetById(sv.MaSV) == null)
                return (false, $"Không tìm thấy sinh viên có mã '{sv.MaSV}' để cập nhật.");

            bool res = _sinhVienDAL.Update(sv);
            return res ? (true, "Cập nhật thông tin sinh viên thành công.") : (false, "Lỗi khi sửa dữ liệu.");
        }

        public (bool Success, string Message) XoaSinhVien(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                return (false, "Mã sinh viên không hợp lệ.");

            if (_sinhVienDAL.GetById(maSV) == null)
                return (false, $"Không tồn tại sinh viên có mã '{maSV}'.");

            bool res = _sinhVienDAL.Delete(maSV);
            return res ? (true, "Đã xóa sinh viên thành công.") : (false, "Xóa thất bại.");
        }

        public List<SinhVien> TimKiem(string keyword, string maLop, double? diemTu)
        {
            var list = _sinhVienDAL.Search(keyword, maLop, diemTu);
            MapTenLop(list);
            return list;
        }
    }
}
