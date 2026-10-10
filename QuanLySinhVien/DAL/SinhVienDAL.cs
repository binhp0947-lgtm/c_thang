using System;
using System.Collections.Generic;
using System.Linq;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAL
{
    public class SinhVienDAL
    {
        // Nguồn dữ liệu mô phỏng DataList trong bộ nhớ (20 sinh viên mẫu)
        private static List<SinhVien> _danhSachSinhVien;

        static SinhVienDAL()
        {
            _danhSachSinhVien = new List<SinhVien>()
            {
                new SinhVien {
                    MaSV = "SV000123", HoTen = "Nguyễn Văn An", NgaySinh = new DateTime(2006, 8, 15),
                    GioiTinh = "Nam", Email = "an.nv@vju.ac.vn", DienThoai = "0912345678",
                    Diem = 8.5, MaLop = "LH01", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000124", HoTen = "Trần Minh Anh", NgaySinh = new DateTime(2006, 1, 22),
                    GioiTinh = "Nữ", Email = "anh.tm@vju.ac.vn", DienThoai = "0987654321",
                    Diem = 9.0, MaLop = "LH02", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000125", HoTen = "Lê Hoàng Bình", NgaySinh = new DateTime(2006, 5, 9),
                    GioiTinh = "Nam", Email = "binh.lh@vju.ac.vn", DienThoai = "0355556677",
                    Diem = 7.4, MaLop = "LH01", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000126", HoTen = "Đỗ Thị Hồng", NgaySinh = new DateTime(2006, 11, 30),
                    GioiTinh = "Nữ", Email = "hong.dt@vju.ac.vn", DienThoai = "0777888999",
                    Diem = 8.1, MaLop = "LH03", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000127", HoTen = "Phạm Quốc Bảo", NgaySinh = new DateTime(2006, 3, 14),
                    GioiTinh = "Nam", Email = "bao.pq@vju.ac.vn", DienThoai = "0934123456",
                    Diem = 8.8, MaLop = "LH02", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000128", HoTen = "Vũ Thùy Dung", NgaySinh = new DateTime(2006, 7, 5),
                    GioiTinh = "Nữ", Email = "dung.vt@vju.ac.vn", DienThoai = "0968112233",
                    Diem = 9.2, MaLop = "LH04", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000129", HoTen = "Hoàng Đức Duy", NgaySinh = new DateTime(2005, 12, 18),
                    GioiTinh = "Nam", Email = "duy.hd@vju.ac.vn", DienThoai = "0389445566",
                    Diem = 6.8, MaLop = "LH01", TrangThai = "Bảo lưu"
                },
                new SinhVien {
                    MaSV = "SV000130", HoTen = "Bùi Mai Phương", NgaySinh = new DateTime(2006, 9, 25),
                    GioiTinh = "Nữ", Email = "phuong.bm@vju.ac.vn", DienThoai = "0823667788",
                    Diem = 8.7, MaLop = "LH03", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000131", HoTen = "Đặng Tiến Đạt", NgaySinh = new DateTime(2006, 2, 10),
                    GioiTinh = "Nam", Email = "dat.dt@vju.ac.vn", DienThoai = "0945998877",
                    Diem = 7.9, MaLop = "LH04", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000132", HoTen = "Ngô Thu Hà", NgaySinh = new DateTime(2006, 6, 19),
                    GioiTinh = "Nữ", Email = "ha.nt@vju.ac.vn", DienThoai = "0918776655",
                    Diem = 9.5, MaLop = "LH02", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000133", HoTen = "Trương Văn Hùng", NgaySinh = new DateTime(2006, 4, 3),
                    GioiTinh = "Nam", Email = "hung.tv@vju.ac.vn", DienThoai = "0376223344",
                    Diem = 7.2, MaLop = "LH01", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000134", HoTen = "Dương Bích Ngọc", NgaySinh = new DateTime(2006, 8, 28),
                    GioiTinh = "Nữ", Email = "ngoc.db@vju.ac.vn", DienThoai = "0855334455",
                    Diem = 8.4, MaLop = "LH03", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000135", HoTen = "Phan Tuấn Kiệt", NgaySinh = new DateTime(2005, 10, 11),
                    GioiTinh = "Nam", Email = "kiet.pt@vju.ac.vn", DienThoai = "0903112244",
                    Diem = 6.5, MaLop = "LH04", TrangThai = "Bảo lưu"
                },
                new SinhVien {
                    MaSV = "SV000136", HoTen = "Lâm Khánh Linh", NgaySinh = new DateTime(2006, 1, 17),
                    GioiTinh = "Nữ", Email = "linh.lk@vju.ac.vn", DienThoai = "0974889900",
                    Diem = 9.1, MaLop = "LH02", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000137", HoTen = "Đoàn Hữu Thắng", NgaySinh = new DateTime(2006, 4, 24),
                    GioiTinh = "Nam", Email = "thang.dh@vju.ac.vn", DienThoai = "0398665544",
                    Diem = 8.0, MaLop = "LH01", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000138", HoTen = "Trịnh Yến Nhi", NgaySinh = new DateTime(2006, 11, 8),
                    GioiTinh = "Nữ", Email = "nhi.ty@vju.ac.vn", DienThoai = "0789123321",
                    Diem = 8.9, MaLop = "LH03", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000139", HoTen = "Mai Trọng Tấn", NgaySinh = new DateTime(2005, 3, 12),
                    GioiTinh = "Nam", Email = "tan.mt@vju.ac.vn", DienThoai = "0922445566",
                    Diem = 7.6, MaLop = "LH04", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000140", HoTen = "Võ Thảo My", NgaySinh = new DateTime(2006, 5, 29),
                    GioiTinh = "Nữ", Email = "my.vt@vju.ac.vn", DienThoai = "0888999111",
                    Diem = 9.8, MaLop = "LH02", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000141", HoTen = "Hà Quang Huy", NgaySinh = new DateTime(2006, 7, 16),
                    GioiTinh = "Nam", Email = "huy.hq@vju.ac.vn", DienThoai = "0915332211",
                    Diem = 8.3, MaLop = "LH01", TrangThai = "Đang học"
                },
                new SinhVien {
                    MaSV = "SV000142", HoTen = "Tạ Thanh Vân", NgaySinh = new DateTime(2005, 9, 21),
                    GioiTinh = "Nữ", Email = "van.tt@vju.ac.vn", DienThoai = "0366778899",
                    Diem = 8.6, MaLop = "LH03", TrangThai = "Đã tốt nghiệp"
                }
            };
        }

        public List<SinhVien> GetAll() => _danhSachSinhVien.ToList();

        public SinhVien GetById(string maSV) => 
            _danhSachSinhVien.FirstOrDefault(sv => sv.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));

        public List<SinhVien> GetByClassId(string maLop) =>
            _danhSachSinhVien.Where(sv => sv.MaLop.Equals(maLop, StringComparison.OrdinalIgnoreCase)).ToList();

        public bool Insert(SinhVien sv)
        {
            if (GetById(sv.MaSV) != null) return false;
            _danhSachSinhVien.Add(sv);
            return true;
        }

        public bool Update(SinhVien sv)
        {
            var existing = GetById(sv.MaSV);
            if (existing == null) return false;

            existing.HoTen = sv.HoTen;
            existing.NgaySinh = sv.NgaySinh;
            existing.GioiTinh = sv.GioiTinh;
            existing.Email = sv.Email;
            existing.DienThoai = sv.DienThoai;
            existing.Diem = sv.Diem;
            existing.MaLop = sv.MaLop;
            existing.TrangThai = sv.TrangThai;
            return true;
        }

        public bool Delete(string maSV)
        {
            var existing = GetById(maSV);
            if (existing == null) return false;
            return _danhSachSinhVien.Remove(existing);
        }

        // Tìm kiếm nâng cao phía Data layer
        public List<SinhVien> Search(string keyword, string maLop, double? diemTu)
        {
            var query = _danhSachSinhVien.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim().ToLower();
                query = query.Where(s => s.MaSV.ToLower().Contains(kw) ||
                                         s.HoTen.ToLower().Contains(kw) ||
                                         s.Email.ToLower().Contains(kw) ||
                                         s.DienThoai.Contains(kw));
            }

            if (!string.IsNullOrWhiteSpace(maLop) && maLop != "ALL")
            {
                query = query.Where(s => s.MaLop.Equals(maLop, StringComparison.OrdinalIgnoreCase));
            }

            if (diemTu.HasValue)
            {
                query = query.Where(s => s.Diem >= diemTu.Value);
            }

            return query.ToList();
        }
    }
}
