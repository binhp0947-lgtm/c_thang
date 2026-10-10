using System.Collections.Generic;
using System.Linq;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAL
{
    public class LopHocDAL
    {
        // Giả lập nguồn dữ liệu bằng static List
        private static List<LopHoc> _danhSachLop;

        static LopHocDAL()
        {
            _danhSachLop = new List<LopHoc>()
            {
                new LopHoc("LH01", "Kỹ thuật phần mềm 01"),
                new LopHoc("LH02", "Trí tuệ nhân tạo 01"),
                new LopHoc("LH03", "Khoa học dữ liệu 01"),
                new LopHoc("LH04", "An toàn thông tin 01")
            };
        }

        public List<LopHoc> GetAll() => _danhSachLop.ToList();

        public LopHoc GetById(string maLop) => 
            _danhSachLop.FirstOrDefault(l => l.MaLop.Equals(maLop, System.StringComparison.OrdinalIgnoreCase));

        public bool Insert(LopHoc lop)
        {
            if (GetById(lop.MaLop) != null) return false;
            _danhSachLop.Add(lop);
            return true;
        }

        public bool Update(LopHoc lop)
        {
            var existing = GetById(lop.MaLop);
            if (existing == null) return false;
            existing.TenLop = lop.TenLop;
            return true;
        }

        public bool Delete(string maLop)
        {
            var existing = GetById(maLop);
            if (existing == null) return false;
            return _danhSachLop.Remove(existing);
        }
    }
}
