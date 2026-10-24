using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.Models;

namespace QuanLyThuVien.Data;

/// <summary>
/// DbContext quản lý kết nối và ánh xạ Code-First sang Database
/// </summary>
public class LibraryDbContext : DbContext
{
    public DbSet<NguoiMuon> NguoiMuons => Set<NguoiMuon>();
    public DbSet<Sach> Sachs => Set<Sach>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Sử dụng SQLite file local 'library.db' trong thư mục dự án
        optionsBuilder.UseSqlite("Data Source=library.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Cấu hình Fluent API cho mối quan hệ 1 - N:
        // Một NguoiMuon có nhiều Sach, Sach có thể thuộc về 1 NguoiMuon hoặc chưa mượn (nullable FK)
        modelBuilder.Entity<NguoiMuon>()
            .HasMany(n => n.DanhSachSachMuon)
            .WithOne(s => s.NguoiMuonHienTai)
            .HasForeignKey(s => s.NguoiMuonId)
            .OnDelete(DeleteBehavior.SetNull); // Khi xóa người mượn, sách được trả về kho (NguoiMuonId = null)
    }
}
