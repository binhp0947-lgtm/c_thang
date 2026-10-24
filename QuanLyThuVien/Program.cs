using System.Text;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.Data;
using QuanLyThuVien.Models;

// Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt trên Console
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("==================================================");
Console.WriteLine("   HỆ THỐNG QUẢN LÝ THƯ VIỆN (EF CORE CODE FIRST)  ");
Console.WriteLine("==================================================\n");

using var context = new LibraryDbContext();

// 1. Tự động sinh Database và bảng dựa trên các lớp thực thể (Code First)
Console.WriteLine("--> Đang khởi tạo Database từ Model (EnsureCreated)...");
context.Database.EnsureCreated();
Console.WriteLine("--> Database đã sẵn sàng (library.db)!\n");

// 2. Thêm dữ liệu mẫu nếu Database chưa có dữ liệu
if (!context.NguoiMuons.Any() && !context.Sachs.Any())
{
    Console.WriteLine("--> Database trống, đang thêm dữ liệu mẫu...");

    var docGia1 = new NguoiMuon
    {
        HoTen = "Nguyễn Văn An",
        SoDienThoai = "0912345678",
        Email = "an.nguyen@example.com"
    };

    var docGia2 = new NguoiMuon
    {
        HoTen = "Trần Thị Bích",
        SoDienThoai = "0987654321",
        Email = "bich.tran@example.com"
    };

    context.NguoiMuons.AddRange(docGia1, docGia2);
    context.SaveChanges(); // Lưu để sinh Id cho người mượn

    var sach1 = new Sach
    {
        TieuDe = "Lập trình C# từ cơ bản đến nâng cao",
        TacGia = "Microsoft Press",
        TheLoai = "Công nghệ thông tin",
        NamXuatBan = 2024,
        NguoiMuonId = docGia1.Id // Sách này đang do bạn An mượn
    };

    var sach2 = new Sach
    {
        TieuDe = "Clean Architecture & Design Patterns",
        TacGia = "Robert C. Martin",
        TheLoai = "Công nghệ thông tin",
        NamXuatBan = 2023,
        NguoiMuonId = docGia1.Id // Sách này cũng do bạn An mượn
    };

    var sach3 = new Sach
    {
        TieuDe = "Đắc Nhân Tâm",
        TacGia = "Dale Carnegie",
        TheLoai = "Tâm lý kỹ năng",
        NamXuatBan = 2022,
        NguoiMuonId = null // Sách đang có sẵn trong thư viện
    };

    var sach4 = new Sach
    {
        TieuDe = "Nhà Giả Kim",
        TacGia = "Paulo Coelho",
        TheLoai = "Văn học",
        NamXuatBan = 2021,
        NguoiMuonId = docGia2.Id // Sách do bạn Bích mượn
    };

    context.Sachs.AddRange(sach1, sach2, sach3, sach4);
    context.SaveChanges();

    Console.WriteLine("--> Thêm dữ liệu mẫu thành công!\n");
}

// 3. Hiển thị danh sách Người Mượn và số sách đang mượn
Console.WriteLine("---------------- DANH SÁCH NGƯỜI MƯỢN ----------------");
var danhSachNguoiMuon = context.NguoiMuons
    .Include(n => n.DanhSachSachMuon)
    .ToList();

foreach (var nm in danhSachNguoiMuon)
{
    Console.WriteLine($"[Mã: {nm.Id}] {nm.HoTen} - SĐT: {nm.SoDienThoai} - Email: {nm.Email}");
    Console.WriteLine($"   Số sách đang mượn: {nm.DanhSachSachMuon.Count} cuốn");
    foreach (var s in nm.DanhSachSachMuon)
    {
        Console.WriteLine($"    + Tựa sách: \"{s.TieuDe}\" ({s.NamXuatBan})");
    }
    Console.WriteLine();
}

// 4. Hiển thị danh sách Toàn bộ Sách và trạng thái mượn
Console.WriteLine("---------------- DANH SÁCH TẤT CẢ SÁCH ----------------");
var danhSachSach = context.Sachs
    .Include(s => s.NguoiMuonHienTai)
    .ToList();

foreach (var s in danhSachSach)
{
    string trangThai = s.NguoiMuonHienTai != null
        ? $"ĐANG MƯỢN (Bởi: {s.NguoiMuonHienTai.HoTen})"
        : "CÓ SẴN TRONG KHO";

    Console.WriteLine($"[Mã sách: {s.Id}] \"{s.TieuDe}\" - Tác giả: {s.TacGia} - Thể loại: {s.TheLoai}");
    Console.WriteLine($"   Trạng thái: {trangThai}");
    Console.WriteLine();
}

Console.WriteLine("==================================================");
Console.WriteLine(" Chạy dự án thành công và hoàn tất demo Code First!");
Console.WriteLine("==================================================");
